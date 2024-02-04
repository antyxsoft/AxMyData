# AxMyData

A C# library for [AADE's](https://www.aade.gr) (Greek Tax Authority) [MyData Web API](https://www.aade.gr/mydata).

The libray is based on the [v1.0.8](https://www.aade.gr/sites/default/files/2023-12/myDATA%20API%20Documentation%20v1.0.8_preofficial_erp_1.pdf) version of MyData Web API and covers all the calls of the service.

## The **Api** static class
The library contains the **Api** static class which provides an **async** static method for each MyData Web API call.

 This **Api** static class "talks" to MyData Web API. It contains a ["typed" HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-8.0), the **ApiClient** class, which is **internal** to the library and carries out all the `HTTP` calls.

The client code must call the `Api.Initialize()` of the **Api** static class before any other call, passing the `BaseUrl`. 

```static public void Initialize(string BaseUrl, bool IsInvoicingProvider)```

The `BaseUrl` could be the "development" URL or the "production" URL of MyData's API.

- PROD:   https://mydatapi.aade.gr/myDATA/
- DEV:    https://mydataapidev.aade.gr

The methods of the **Api** class that call to MyData Web API require the `UserName` and the `UserKey` of the caller.

```static public async Task<ResponseDoc> SendInvoice(string UserName, string UserKey, AadeBookInvoiceType Invoice)```

## The Models

MyData is an `XML` Web API. Not a `JSON` one.

MyData provides a set of `XSD` files describing the Models used when sending and receiving information.

Converting MyData's `XSD` files to `C#` classes is not an easy task. The excellent [XmlSchemaClassGenerator](https://github.com/mganss/XmlSchemaClassGenerator) library is used for this task, properly modified. I wrote a desktop application, the [XsdToCsharp](https://github.com/tbebekis/XsdToCsharp), which uses that modified version of `XmlSchemaClassGenerator`, just to make the job easy. 

The generated `C#` Model classes can be found in the `MyData.Xsd` folder of this library. The original `XSD` files are in the `_XSD` folder.


## The Lookup classes

MyData's API contains a large number of enumeration or numeric (`int[]`) types, such as the `QuantityType` `XSD` type (which actually is the Measurement Unit) or the `VatType` `XSD` type.

This library provides a class for each of those `XSD` types to ease the work.

These "Lookup" classes are used in providing safe values to Model properties.

## Validation

MyData Web API involves a great number of rules. Total validation is not a feasible task.

Model validation provided by this library is done automatically when a method of the **Api** class is called.
```
static public async Task<ResponseDoc> SendInvoiceList(string UserName, string UserKey, InvoicesDoc List)
{
    CheckIsInitialized();
    CheckErrors(Validators.Validate(List));
    string ActionUrl = "SendInvoices";

    ApiCall CI = await Client.PostAsync(UserName, UserKey, ActionUrl, List).ConfigureAwait(false);
            
    if (!CI.IsSuccess)
        Throw(CI.ReasonPhrase);

    ResponseDoc Result = ApiXml.Deserialize<ResponseDoc>(CI.ResponseText);
    return Result;
}
```

The **Validators** static class is the validation headquarter. 

The **Validators** static class provides methods for validating the **top** Models, i.e. the Models that are the containers for all the other Models. A top Model contains a list of sub-models, e.g. the `InvoicesDoc` contains a list of `AadeBookInvoiceType` items. 

The `Validators.Validate()` method is an overloaded method and there are versions of this method accepting all the top Models. These methods return a string list which is empty in case of no error.

Error messages produced by the Validation contain the Model class name and the property name along with the error message.

```
static public List<string> Validate(InvoicesDoc Model);

static public List<string> Validate(IncomeClassificationsDoc Model);

...
```

## Validator class and ValidatorAttribute 

For each top Model or sub-model there is a **Validator** derived class which "knows" how to validate the Model.

**Validator** derived classes are marked with the **ValidatorAttribute** specifying the Model class they are responsible for.

```
    [Validator(typeof(AadeBookInvoiceType))]
    public class ValidatorAadeBookInvoiceType : Validator
    {
        public ValidatorAadeBookInvoiceType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }
        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
            Validate_taxesTotals();

            ...
        }

        void Validate_taxesTotals()
        {
            ...
        }
        
    }
```

A **Validator** derived class contains the virtual `Validate()` method. 

The `Validate()` method first calls the `ValidatePropertiesByAttributes()` which validates the Model based on the Attributes marking the properties of the Model, such as the `RequiredAttribute` or the `MaxLengthAttribute`. It then calls any Model-specific validation methods such as the `Validate_taxesTotals()` in the above example.

**Validator** classes are registered automatically by the **Validators** static class as long as they are marked with the **ValidatorAttribute** attribute.

An instance of the `ValidatorContext` class is passed to each `Validator`. The `ValidatorContext` contains the top Model and sub-model being validated. It also contains a string list of error messages, if any.

## The Models helper class

The **Models** static class is a helper class. It may used in constructing Model and sub-model instances, adding lines, e.g. `AddIncomeLine()`, etc.
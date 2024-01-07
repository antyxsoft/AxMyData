namespace MyData.ApiLib 
{
    static public class PaymentMethodsValidator
    {
        static public void Validate(List<string> ErrorList, PaymentMethodsDoc Model)
        {
            ModelValidator.ValidateModel(ErrorList, Model);
        }
    }
}

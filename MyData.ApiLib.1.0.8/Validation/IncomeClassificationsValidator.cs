namespace MyData.ApiLib
{
    static public class IncomeClassificationsValidator
    {
        static public void Validate(List<string> ErrorList, IncomeClassificationsDoc Model)
        {
            ModelValidator.ValidateModel(ErrorList, Model);
        }
    }
}

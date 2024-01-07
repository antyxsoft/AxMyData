namespace MyData.ApiLib
{
    static public class ExpensesClassificationsValidator
    {
        static public void Validate(List<string> ErrorList, ExpensesClassificationsDoc Model)
        {
            ModelValidator.ValidateModel(ErrorList, Model);
        }
    }
}

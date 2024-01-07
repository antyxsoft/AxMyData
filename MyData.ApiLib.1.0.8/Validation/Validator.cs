using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.ApiLib
{

    /*
     Template
    ----------------------------------------------------------------------------
    namespace MyData.ApiLib 
    {
        public class ValidatorREPLACE : Validator
        {
            public ValidatorREPLACE()
                : base(typeof(REPLACE))
            {
            }
            public override void Validate(object Model, object ParentModel, List<string> ErrorList)
            {
                Validate(Model as REPLACE, ParentModel, ErrorList);
            }

            void Validate(REPLACE Model, object ParentModel, List<string> ErrorList)
            { 
                Validators.ValidatePropertiesByAttributes(Model, ErrorList); 
            }
        }
    }


     */

    /// <summary>
    /// Base validator class
    /// </summary>
    public abstract class Validator
    {
        /*
        protected void HandleEmptyList(string PropName, List<string> ErrorList)
        {
            PropertyInfo Prop = Validators.GetProperty(this.Type, PropName);
            string PropDescription = Validators.GetPropertyDescription(Prop);

            string ErrorMessage = $"{PropDescription} - Η λίστα είναι κενή.";
            ErrorList.Add(ErrorMessage);
        }
        */

        /// <summary>
        /// Constructor
        /// </summary>
        protected Validator(Type Type)
        {
            this.Type = Type;
            this.TypeDescription = Validators.GetTypeDescription(Type);
        }

        /// <summary>
        /// Validates a model
        /// </summary>
        public abstract void Validate(object Model, object ParentModel, List<string> ErrorList);
        /// <summary>
        /// The Model Type this validator is able to validate
        /// </summary>
        public Type Type { get; }
        /// <summary>
        /// The description of the Model Type
        /// </summary>
        public string TypeDescription { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyData.ApiLib
{

    /// <summary>
    /// Base validator class
    /// </summary>
    public abstract class Validator
    {
        protected object fModel;

        /// <summary>
        /// Throws an exception if a specified Model Type, an instance of which is passed for validation,
        /// is NOT the Model Type defined in the <see cref="ValidatorAttribute"/> of this class.
        /// </summary>
        void CheckModelType(Type ModelType)
        {
            ValidatorAttribute Attr = Attribute.GetCustomAttribute(this.GetType(), typeof(ValidatorAttribute)) as ValidatorAttribute;
            if (Attr != null)
            {
                if (Attr.ModelType != ModelType)
                    throw new ApplicationException($"Wrong Model Type in Validator class: {this.GetType()}");
            }
        }
        /// <summary>
        /// Adds a property validation error to the error list of the <see cref="ValidatorContext"/>
        /// </summary>
        protected void AddPropertyError(string PropName, string ErrorMessage)
        {
            ErrorMessage = Validators.FormatPropertyError(fModel, PropName, ErrorMessage);
            Context.ErrorList.Add(ErrorMessage);
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        protected Validator(object Model, ValidatorContext Context)
        {
            if (Model == null) 
                throw new ArgumentNullException($"{this.GetType().Name}: cannot validate a null model.");

            CheckModelType(Model.GetType());

            this.fModel = Model;
            this.ModelType = Model.GetType();
            this.TypeDescription = Validators.GetTypeDescription(this.ModelType);
            this.Context = Context; 
        }

        /* public */
        /// <summary>
        /// Validates the model.
        /// <para>Adds error messages to the context error list if the model does not pass the validation checks.</para>
        /// </summary>
        public abstract void Validate();

        /* properties */
        /// <summary>
        /// The Model Type this validator is able to validate
        /// </summary>
        public Type ModelType { get; }
        /// <summary>
        /// The description of the Model Type
        /// </summary>
        public string TypeDescription { get; }
        /// <summary>
        /// Returns the validation context
        /// </summary>
        public ValidatorContext Context { get;  }
    }
}

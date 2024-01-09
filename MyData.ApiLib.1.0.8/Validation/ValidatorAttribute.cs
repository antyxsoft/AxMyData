using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.ApiLib
{

    /// <summary>
    /// Decorates classes derived from <see cref="Validator"/> class.
    /// <para>The single parameter denotes the Model type, the validator decorated with this attribute, can handle. </para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ValidatorAttribute: Attribute
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ModelType"><The Model type the validator decorated with this attribute can handle./param>
        public ValidatorAttribute(Type ModelType) 
        {
            this.ModelType = ModelType;
        }

        /// <summary>
        /// The Model type the validator decorated with this attribute can handle.
        /// </summary>
        public Type ModelType { get;  }
    }
}

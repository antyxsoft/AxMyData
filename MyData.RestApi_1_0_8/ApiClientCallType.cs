using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.RestApi
{
    /// <summary>
    /// The type of a HttpClient call
    /// </summary>
    internal enum ApiClientCallType
    {
        /// <summary>
        /// Get
        /// </summary>
        Get,
        /// <summary>
        /// Post
        /// </summary>
        Post, 
    }
}

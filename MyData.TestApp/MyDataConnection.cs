using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.TestApp
{
    /// <summary>
    /// MyData connection information
    /// </summary>
    public class MyDataConnection
    {
        /// <summary>
        /// User
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Subscription Key
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// MyData API EndPoint
        /// </summary>
        public string ApiEndPoint { get; set; } = @"https://mydataapidev.aade.gr";
    }
}

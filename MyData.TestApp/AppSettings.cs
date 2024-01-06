using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.TestApp
{
    /// <summary>
    /// Application settings
    /// </summary>
    public class AppSettings
    {
        const string FileName = "AppSettings.json";

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public AppSettings()
        {
            Load();
        }
        /// <summary>
        /// Loads this instance from a json file
        /// </summary>        
        public void Load()
        {
            if (File.Exists(FileName))
            {
                Json.LoadFromFile(this, FileName);
            }
        }
        /// <summary>
        /// Saves this instance to a json file
        /// </summary>
        public void Save()
        {
            Json.SaveToFile(this, FileName);
        }

        /* properties */
        /// <summary>
        /// MyData connection information
        /// </summary>
        public MyDataConnection MyDataConnection { get; set; } = new MyDataConnection();
    }
}

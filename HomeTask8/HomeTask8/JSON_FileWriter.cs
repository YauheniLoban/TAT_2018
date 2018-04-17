using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace HomeTask8
{
    /// <summary>
    /// Create file writer
    /// </summary>
    class JSON_FileWriter
    {
        /// <summary>
        /// Write list of users into JSON-file
        /// </summary>
        /// <param name="users">List of users</param>
        /// <param name="fileWay">Way to JSON-file</param>
        public void WriteToLsonFile(List<User> users, string fileWay)
        {
            try
            {
                File.WriteAllText(fileWay, JsonConvert.SerializeObject(users));
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException(ex.Message);
            }
        }
    }
}

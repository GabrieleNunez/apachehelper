using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApacheHelper
{
    /// <summary>
    /// Class that represents VHOST settings
    /// </summary>
    public class VhostSettings
    {
        
        public string PublicRoot { get; set; }
        public string LogLocation { get; set; }
        public string ServerName { get; set; }
        public string ServerAdmin { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApacheHelper
{
    /// <summary>
    /// A static class that represents the windows HOSTS file and provides safe methods to working with this file
    /// </summary>
    public static class WindowsHost
    {


        private static string HOSTS = null;

        /// <summary>
        /// Will be called the first time any method is called in this class. But this will only execute once in it's lifetime
        /// </summary>
        static WindowsHost()
        {
            WindowsHost.HOSTS = Path.Combine(Environment.SystemDirectory, "drivers\\etc\\HOSTS");
        }

        /// <summary>
        /// Loads all host file entries
        /// </summary>
        /// <returns>An array containing all host file entries</returns>
        public static string[] GetEntries()
        {
            List<string> entries = new List<string>();
            using (StreamReader reader = new StreamReader(WindowsHost.HOSTS))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine(); // consume line
                    if (line.Length > 0 && line[0] != '#') // ignore blank lines and comment lines
                        entries.Add(line);

                }
            }

            return entries.ToArray();

        }

        /// <summary>
        /// Add entry to the HOSTS file
        /// </summary>
        public static void AddEntry(string destination, string domain)
        {
            File.AppendAllText(WindowsHost.HOSTS, "\r\n" + destination + " " + domain);
        }
    }
}

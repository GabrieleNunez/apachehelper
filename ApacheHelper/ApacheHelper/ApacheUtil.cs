using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApacheHelper
{
    public class ApacheUtil
    {
        private string baseDir = null;
        private string vhosts = null;
        private string conf = null;
        
        /// <summary>
        /// Gets the base directory for the apache installation
        /// </summary>
        public string BaseDir
        {
            get { return this.baseDir;  }
        }

        /// <summary>
        /// Constructs a apache helper utility
        /// </summary>
        /// <param name="baseDirectory">The base directory that apache is located at</param>
        public ApacheUtil(string baseDirectory)
        {
            this.baseDir = baseDirectory;
            this.vhosts = Path.Combine(this.baseDir, "conf\\extra\\httpd-vhosts.conf");
            this.conf = Path.Combine(this.baseDir, "conf\\httpd.conf");

        }

        /// <summary>
        /// Retrieves the path to the vhosts file (httpd-vhosts)
        /// </summary>
        /// <returns></returns>
        public string[] GetVHostEntries()
        {
            List<string> entries = new List<string>();

            using (StreamReader reader = new StreamReader(this.vhosts))
            {
                bool openingElement = false;
                string serverName = "";
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if(line.Length > 0 && line[0] != '#')
                    {
                        // now figure out where we are
                        if(line.Length >= 12 && line.Contains("VirtualHost"))
                        {
                            openingElement = true;
                        }
                        else if(line.Length >= 13 && line.Contains("/VirtualHost"))
                        {
                            openingElement = false;
                        }
                        else if(openingElement && line.Contains("ServerName"))
                        {
                            serverName = line.Replace("ServerName", "").Trim();
                            entries.Add(serverName);
                        }
                       
                    }
                }
            }
            return entries.ToArray();
        }
       
        /// <summary>
        /// Loads the document root specified inside httpd.conf
        /// </summary>
        /// <returns></returns>
        public string GetDocumentRoot()
        {

            string documentRoot = "";

            using (StreamReader reader = new StreamReader(this.conf))
            {
                while(!reader.EndOfStream)
                {
                    string tmpLine = reader.ReadLine();

                    //if the line matches all of the following criteria then we have found our document root!
                    if (tmpLine.Length > 12 && tmpLine[0] != '#' && tmpLine.Substring(0, 12).Contains("DocumentRoot"))
                        documentRoot = tmpLine;
                }
            }

            return documentRoot.Substring(12).Trim().Trim('"');

        }

        /// <summary>
        /// Update the document root
        /// </summary>
        /// <param name="newRoot"></param>
        public void UpdateDocumentRoot(string newRoot)
        {
            string tmp = Path.Combine(this.baseDir, "conf\\http.conf.tmp");
            StringBuilder lines = new StringBuilder();

            // load the httpd.conf file and go ahead and 
            using (StreamReader reader = new StreamReader(this.conf))
            {
                while (!reader.EndOfStream)
                {


                    string tmpLine = reader.ReadLine();
                    //if the line matches all of the following criteria lets go ahead and insert this instead
                    if (tmpLine.Length > 12 && tmpLine[0] != '#' && tmpLine.Substring(0, 12).Contains("DocumentRoot"))
                    {
                        // write the new document root out
                        lines.AppendLine("DocumentRoot \"" + newRoot + "\"");

                        // now write the new Directory permissions for this
                        lines.AppendLine("<Directory \"" + newRoot + "\">");
                        lines.AppendLine("\tOptions Indexes FollowSymLinks Includes ExecCGI");
                        lines.AppendLine("\tAllowOverride All");
                        lines.AppendLine("\tRequire all granted");
                        lines.AppendLine("</Directory>");
                    }
                    else
                    {
                        lines.AppendLine(tmpLine); // no matter what go ahead and add the line
                    }
                    
                }
            }

            // write to a temporary file now
            using (StreamWriter writer = new StreamWriter(tmp))
            {
                writer.WriteLine(lines.ToString());
            }

            // now that everything is set. Copy the file over
            File.Copy(tmp, this.conf, true);
            File.Delete(tmp); // delete temporary file
        }

        /// <summary>
        /// Creates a VHOST entry based on supplied parameters
        /// </summary>
        /// <param name="serverName">The name of the server</param>
        /// <param name="documentRoot">Where are we storing it</param>
        public void CreateVHost(string serverName, string publicRoot)
        {

            string basename = Directory.GetParent(publicRoot).FullName;

            StringBuilder entry = new StringBuilder();
            entry.AppendLine("<VirtualHost *:80>");
            entry.AppendLine("\tServerAdmin admin@localhost.com");
            entry.AppendLine("\tDocumentRoot \"" + publicRoot + "\"");
            entry.AppendLine("\tServerName " + serverName);
            entry.AppendLine("\tErrorLog \"" + basename + "\\error.log\"");
            entry.AppendLine("\tCustomLog \"" + basename + "\\access.log\" combine");
            entry.AppendLine("</VirtualHost>");

            File.AppendAllText(this.vhosts, entry.ToString());

        }

    }


}

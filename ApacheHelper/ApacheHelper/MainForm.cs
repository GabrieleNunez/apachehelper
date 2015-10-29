using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApacheHelper
{
    public partial class MainForm : Form
    {   
        // apache utiliy object
        private ApacheUtil apacheUtility = null;

        public MainForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Launches a folder browse dialog for the apache directory
        /// </summary>
        private void BrowseForApache()
        {

            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // update and save the settings
                    Properties.Settings.Default.ApacheDir = dialog.SelectedPath;
                    Properties.Settings.Default.Save();

                    this.apacheDirLabel.Text = dialog.SelectedPath;
                }
            }
        }

        /// <summary>
        /// As soon as the form loads run this code
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            // check our apache directory setting
            if(Properties.Settings.Default.ApacheDir.Length == 0) // we have no location. Go ahead and prompt the user for it
            {
                MessageBox.Show("For this utility to work please point it toward your apache installation");

                // browse for our apache folder
                BrowseForApache();

                // make sure we have a apache folder to work with
                if (Properties.Settings.Default.ApacheDir.Length == 0)
                {
                    // alert the user that this application cannot run without this setting. Then exit the application
                    MessageBox.Show("This application cannot run without knowing your apache installation directory");
                    Application.Exit();

                }
            }
            else // we have a location to work with
            {
                // simply set the label to our apache location
                this.apacheDirLabel.Text = Properties.Settings.Default.ApacheDir;
            }

            // create our apache utility class using our stored respective setting
            this.apacheUtility = new ApacheUtil(Properties.Settings.Default.ApacheDir);
            
            // load the host file entries
            string[] hostEntries = WindowsHost.GetEntries();
            hostsListBox.Items.AddRange(hostEntries);

            // load vhosts
            string[] vhosts = this.apacheUtility.GetVHostEntries();
            vhostListBox.Items.AddRange(vhosts);

            // load the document root information
            documentRootLabel.Text = this.apacheUtility.GetDocumentRoot();

            base.OnLoad(e);
        }
            
        /// <summary>
        /// Event hook for when our apache directory button is clicked. Will allow users to browse for a new apache directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void apacheDirButton_Click(object sender, EventArgs e)
        {
            // browse for apache
            BrowseForApache();
        }

        /// <summary>
        /// Try to change the document root
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeDocumentRootButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.apacheUtility.UpdateDocumentRoot(dialog.SelectedPath);
                    this.documentRootLabel.Text = dialog.SelectedPath;
                }
            }
        }

        /// <summary>
        /// Create a new vhost and hosts entry whenver this button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createVHost_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                 if(dialog.ShowDialog() == DialogResult.OK)
                {
                    string[] directoryParts = Path.GetDirectoryName(dialog.SelectedPath).Split('\\');
                    string serverName = directoryParts[directoryParts.Length - 1].ToLower().Replace('-', '_').Replace(" ", "").Replace(".","_").Trim();
                    
                    // use our utility classes to add a HOSTS file entry and a VHOSTS entry at the same time
                    WindowsHost.AddEntry("127.0.0.1", serverName);
                    this.apacheUtility.CreateVHost(serverName, dialog.SelectedPath);
        
                    // add items to respective list boxes
                    hostsListBox.Items.Add("127.0.0.1 " + serverName);
                    vhostListBox.Items.Add(serverName);
                }
            }
        }
    }
}

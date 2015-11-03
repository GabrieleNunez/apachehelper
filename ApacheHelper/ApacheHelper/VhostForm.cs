using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApacheHelper
{
    public partial class VhostForm : Form
    {

        /// <summary>
        /// Returns the forms control values in the form of a string dictionary
        /// </summary>
        public VhostSettings Settings
        {
            get
            {
                VhostSettings settings = new VhostSettings();
                settings.PublicRoot = this.publicRootTextbox.Text;
                settings.ServerAdmin = this.serverAdminTextBox.Text;
                settings.ServerName = this.serverNameTextbox.Text;
                settings.LogLocation = this.logLocationTextBox.Text;

                return settings;
            }
        }

        /// <summary>
        /// Creates a VHOST form with empty values
        /// </summary>
        public VhostForm() : this(new VhostSettings()) { }

        /// <summary>
        /// Creates a VHOST form with the specified values
        /// </summary>
        /// <param name="defaultValues">Default values that will be placed into the appropriate controls</param>
        public VhostForm(VhostSettings defaultValues)
        {
            InitializeComponent();

            // based on what default values we where passed go ahead and populate our controls as appropriate
            this.publicRootTextbox.Text = defaultValues.PublicRoot;
            this.serverNameTextbox.Text = defaultValues.ServerName;
            this.serverAdminTextBox.Text = defaultValues.ServerAdmin;
            this.logLocationTextBox.Text = defaultValues.LogLocation;

        }

        /// <summary>
        /// Pops a dialog up to determine where the public root of the server is located
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void publicRootButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    this.publicRootTextbox.Text = dialog.SelectedPath;
                }
            }
        }

        /// <summary>
        /// Pops a dialog up to determine the location of the log location for this server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logLocationButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    this.logLocationTextBox.Text = dialog.SelectedPath;
                }
            }
        }

        /// <summary>
        /// Returns a boolean indiciating if all form values have been populated
        /// </summary>
        /// <returns></returns>
        private bool validFormValues() {

            return this.serverAdminTextBox.Text.Length > 0 && this.serverNameTextbox.Text.Length > 0 &&
                    this.logLocationTextBox.Text.Length > 0 && this.publicRootTextbox.Text.Length > 0;

        }

        /// <summary>
        /// Enable or disable the ok button based on if we have valid form values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkFormValues(object sender, EventArgs e)
        {
            this.okButton.Enabled = this.validFormValues();
        }
    }
}

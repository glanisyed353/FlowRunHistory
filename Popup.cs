using System.Diagnostics;
using System.Windows.Forms;

namespace MyXrmToolBoxTool1
{
    public partial class Popup : Form
    {
        public string clientId => textClientId.Text;
        public string clientSecret => textClientSecret.Text;

        public Popup()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            textClientId.Text = "";

            textClientSecret.Text = "";           
            btnOK.Click += (s, e) => { this.DialogResult = DialogResult.OK; this.Close(); };

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://learn.microsoft.com/en-us/entra/identity-platform/howto-create-service-principal-portal";
            if (!string.IsNullOrEmpty(url))
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://learn.microsoft.com/en-us/entra/identity-platform/quickstart-register-app";
            if (!string.IsNullOrEmpty(url))
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }        
        }
    }
}

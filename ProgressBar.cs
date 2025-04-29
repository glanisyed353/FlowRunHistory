using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyXrmToolBoxTool1
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
            this.Resize += (s, e) => CenterLabel(); 
            this.Load += (s, e) => CenterLabel(); 
        }

        public void UpdateStatus(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => label1.Text = message));
            }
            else
            {
                label1.Text = message;
            }
        }
        private void CenterLabel()
        {
            label1.Location = new Point(
                (this.ClientSize.Width - label1.Width) / 2,
                (this.ClientSize.Height - label1.Height) / 2);
        }
    }
}

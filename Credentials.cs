using System;
using System.Windows.Forms;

namespace Hadoop.Conf
{
    public partial class Credentials : Form
    {
        public string Host { get { return txtHost.Text; } }
        
        public int Port { get { return int.Parse(txtPort.Text); } }
        
        public string Username { get { return txtUsername.Text; } }
        
        public string Pasword { get { return txtPassword.Text; } }

        public string Path { get { return txtPath.Text; } }

        public Credentials()
        {
            InitializeComponent();
        }

        private void OnAccept(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
using System;
using System.Windows.Forms;

namespace Hadoop.Conf
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        public Preview(string filename, string xml)
        {
            InitializeComponent();

            Text = string.Format("Preview: {0}", filename);
            txtXml.Text = xml;
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

        private void OnToggleReadOnly(object sender, MouseEventArgs e)
        {
            txtXml.ReadOnly = !txtXml.ReadOnly;
        }
    }
}
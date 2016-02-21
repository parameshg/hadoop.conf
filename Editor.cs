using System.Windows.Forms;

namespace Hadoop.Conf
{
    public partial class Editor : Form
    {
        public string ConfigName { get { return txtName.Text; } }

        public string ConfigValue { get { return txtValue.Text; } }

        public Editor()
        {
            InitializeComponent();
        }

        public Editor(string filename, string configName, string configValue)
        {
            InitializeComponent();

            Text = filename;
            txtName.Text = configName;
            txtValue.Text = configValue;
        }

        private void OnAccept(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
using System;
using System.Windows.Forms;

namespace Hadoop.Conf
{
    public static class Extender
    {
        public static void Handle(this Exception e)
        {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
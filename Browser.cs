using Hadoop.Conf.Tools;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Hadoop.Conf
{
    public partial class Browser : Form
    {
        private Dictionary<string, Configuration> _default;

        private Dictionary<string, Configuration> _site;

        public Browser()
        {
            try
            {
                InitializeComponent();

                _default = new Dictionary<string, Configuration>();
                _site = new Dictionary<string, Configuration>();

                foreach (string i in cbFilename.Items)
                {
                    _default.Add(i, new Configuration());
                    _site.Add(i, new Configuration());
                }

                Load += (sender, e) => { cbFilename.SelectedIndex = 0; };
            }
            catch(Exception e)
            {
                e.Handle();
            }
        }

        private void OnFileChanged(object sender, EventArgs args)
        {
            try
            {
                string filename = string.Format("Hadoop.Conf.Xml.{0}", cbFilename.SelectedItem.ToString()).Replace("site", "default");

                using (StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(filename)))
                {
                    string xml = reader.ReadToEnd();

                    _default[cbFilename.SelectedItem.ToString()] = Serializer<Configuration>.Current.Deserialize(xml);

                    lvConfiguration.Items.Clear();

                    foreach (ConfigurationProperty i in _default[cbFilename.SelectedItem.ToString()].Items)
                    {
                        string configValue = _site[cbFilename.SelectedItem.ToString()].IsPropertyExists(i.Name) ? _site[cbFilename.SelectedItem.ToString()].GetProperty(i.Name) : i.Value;

                        ListViewItem item = new ListViewItem(new string[] { i.Name, configValue });

                        item.Tag = i;

                        if (_site[cbFilename.SelectedItem.ToString()].IsPropertyExists(i.Name))
                            item.Font = new Font(item.Font.FontFamily, item.Font.SizeInPoints, System.Drawing.FontStyle.Bold);

                        lvConfiguration.Items.Add(item);
                    }
                }
            }
            catch (Exception e)
            {
                e.Handle();
            }
        }

        private void OnSelect(object sender, EventArgs args)
        {
            try
            {
                foreach (ListViewItem i in lvConfiguration.SelectedItems)
                {
                    ConfigurationProperty property = i.Tag as ConfigurationProperty;

                    if (property != null)
                        txtDescription.Text = property.Description;
                }
            }
            catch (Exception e)
            {
                e.Handle();
            }
        }

        private void OnEdit(object sender, MouseEventArgs args)
        {
            try
            {
                foreach (ListViewItem i in lvConfiguration.SelectedItems)
                {
                    ConfigurationProperty property = i.Tag as ConfigurationProperty;

                    if (property != null)
                    {
                        using (Editor dialog = new Editor(cbFilename.SelectedItem.ToString(), property.Name, property.Value))
                        {
                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                if (_default[cbFilename.SelectedItem.ToString()].GetProperty(property.Name) != dialog.ConfigValue)
                                {
                                    _site[cbFilename.SelectedItem.ToString()].SetProperty(dialog.ConfigName, dialog.ConfigValue);

                                    OnFileChanged(sender, args);

                                    Application.DoEvents();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                e.Handle();
            }
        }

        private void OnSearch(object sender, EventArgs args)
        {
            try
            {
                lvConfiguration.Items.Clear();

                foreach (ConfigurationProperty i in _default[cbFilename.SelectedItem.ToString()].Items)
                {
                    if (string.IsNullOrEmpty(txtSearch.Text) || i.Name.IndexOf(txtSearch.Text) >= 0)
                    {
                        string configValue = _site[cbFilename.SelectedItem.ToString()].IsPropertyExists(i.Name) ? _site[cbFilename.SelectedItem.ToString()].GetProperty(i.Name) : i.Value;

                        ListViewItem item = new ListViewItem(new string[] { i.Name, configValue });

                        item.Tag = i;

                        if (_site[cbFilename.SelectedItem.ToString()].IsPropertyExists(i.Name))
                            item.Font = new Font(item.Font.FontFamily, item.Font.SizeInPoints, System.Drawing.FontStyle.Bold);

                        lvConfiguration.Items.Add(item);
                    }
                }
            }
            catch (Exception e)
            {
                e.Handle();
            }
        }

        private void OnSave(object sender, EventArgs args)
        {
            try
            {
                string xml = Serializer<Configuration>.Current.Serialize(_site[cbFilename.SelectedItem.ToString()]);

                using (Preview dialog = new Preview(cbFilename.SelectedItem.ToString(), xml))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (Credentials credentials = new Credentials())
                        {
                            if (credentials.ShowDialog() == DialogResult.OK)
                            {
                                SshClient ssh = new SshClient(credentials.Host, credentials.Port, credentials.Username, credentials.Pasword);

                                ssh.Connect();

                                if (ssh.IsConnected)
                                {
                                    StringBuilder sb = new StringBuilder();

                                    string path = credentials.Path.EndsWith("/") ? credentials.Path : credentials.Path + "/";

                                    string filename = path + cbFilename.SelectedItem.ToString();

                                    sb.AppendFormat("echo '{0}' >> {1}", xml, filename);

                                    ssh.RunCommand(sb.ToString());
                                }

                                ssh.Disconnect();

                                MessageBox.Show("Configuration file saved in remote server", "Hadoop Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                e.Handle();
            }
        }
    }
}
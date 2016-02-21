using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Hadoop.Conf
{
    [GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "configuration")]
    public partial class Configuration
    {
        private ConfigurationProperty[] _items;

        [XmlElementAttribute("property", Form = XmlSchemaForm.Unqualified)]
        public ConfigurationProperty[] Items
        {
            get
            {
                return _items;
            }

            set
            {
                _items = value;
            }
        }

        public bool IsPropertyExists(string name)
        {
            bool result = false;

            result = !string.IsNullOrEmpty(GetProperty(name));

            return result;
        }

        public string GetProperty(string name)
        {
            string result = string.Empty;

            if (_items != null)
            {
                IEnumerator enumerator = _items.GetEnumerator();

                while (enumerator.MoveNext() && enumerator.Current != null)
                {
                    ConfigurationProperty property = enumerator.Current as ConfigurationProperty;

                    if (property != null && property.Name.Equals(name))
                    {
                        result = property.Value;
                        break;
                    }
                }
            }

            return result;
        }

        public void SetProperty(string name, string value)
        {
            if (IsPropertyExists(name))
            {
                IEnumerator enumerator = _items.GetEnumerator();

                while (enumerator.MoveNext() && enumerator.Current != null)
                {
                    ConfigurationProperty property = enumerator.Current as ConfigurationProperty;

                    if (property != null && property.Name.Equals(name))
                    {
                        property.Value = value;
                        break;
                    }
                }
            }
            else
            {
                ConfigurationProperty property = new ConfigurationProperty() { Name = name, Value = value };

                List<ConfigurationProperty> list = _items != null ? new List<ConfigurationProperty>(_items) : new List<ConfigurationProperty>();

                list.Add(property);

                _items = list.ToArray();
            }
        }
    }

    [GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigurationProperty
    {
        private string _name;

        private string _value;

        private string _description;

        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, ElementName = "name")]
        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, ElementName = "value")]
        public string Value
        {
            get { return _value; }

            set { _value = value; }
        }

        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, ElementName = "description")]
        public string Description
        {
            get { return _description; }

            set { _description = value; }
        }
    }
}
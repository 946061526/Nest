using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace Nest.Framework.Core
{
    public class PluginServiceImp : IPluginService
    {
        private ISystemApplication _SystemApplication = null;

        private PluginConfigurationSection _config = null;

        public Dictionary<string, IPlugin> plugins = new Dictionary<string, IPlugin>();

        private XmlDocument doc = new XmlDocument();

        public ISystemApplication SystemApplication
        {
            get
            {
                return this._SystemApplication;
            }
            set
            {
                this._SystemApplication = value;
            }
        }

        public PluginServiceImp()
        {
        }

        public PluginServiceImp(ISystemApplication pSystemApplication)
        {
            this._SystemApplication = pSystemApplication;
        }

        public void AddPlugin(string pluginName, string pluginType, string assembly, string pluginDescription)
        {
            this.doc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            XmlNode xmlNode = this.doc.SelectSingleNode("/configuration/PluginSection");
            XmlElement xmlElement = this.doc.CreateElement("add");
            XmlAttribute xmlAttribute = this.doc.CreateAttribute("Name");
            xmlAttribute.Value = pluginName;
            xmlElement.SetAttributeNode(xmlAttribute);
            XmlAttribute xmlAttribute2 = this.doc.CreateAttribute("Type");
            xmlAttribute2.Value = pluginType;
            xmlElement.SetAttributeNode(xmlAttribute2);
            XmlAttribute xmlAttribute3 = this.doc.CreateAttribute("Assembly");
            xmlAttribute3.Value = assembly;
            xmlElement.SetAttributeNode(xmlAttribute3);
            XmlAttribute xmlAttribute4 = this.doc.CreateAttribute("Description");
            xmlAttribute4.Value = pluginDescription;
            xmlElement.SetAttributeNode(xmlAttribute4);
            xmlNode.AppendChild(xmlElement);
            this.doc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("PluginSection");
        }

        public void RemovePlugin(string pluginName)
        {
            this.doc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            XmlNode xmlNode = this.doc.SelectSingleNode("/configuration/PluginSection");
            foreach (XmlNode xmlNode2 in xmlNode.ChildNodes)
            {
                if (xmlNode2.Attributes != null)
                {
                    if (xmlNode2.Attributes[0].Value == pluginName)
                    {
                        xmlNode.RemoveChild(xmlNode2);
                    }
                }
            }
            this.doc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("PluginSection");
        }

        public string[] GetAllPluginNames()
        {
            this._config = (PluginConfigurationSection)ConfigurationManager.GetSection("PluginSection");
            PluginConfigurationElement pluginConfigurationElement = new PluginConfigurationElement();
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < this._config.PluginCollection.Count; i++)
            {
                pluginConfigurationElement = this._config.PluginCollection[i];
                arrayList.Add(pluginConfigurationElement.Name);
            }
            return (string[])arrayList.ToArray(typeof(string));
        }

        public bool Contains(string pluginName)
        {
            this._config = (PluginConfigurationSection)ConfigurationManager.GetSection("PluginSection");
            PluginConfigurationElement pluginConfigurationElement = new PluginConfigurationElement();
            List<string> list = new List<string>();
            for (int i = 0; i < this._config.PluginCollection.Count; i++)
            {
                pluginConfigurationElement = this._config.PluginCollection[i];
                list.Add(pluginConfigurationElement.Name);
            }
            return list.Contains(pluginName);
        }

        public bool UsePlugin(string pluginName)
        {
            bool result = false;
            try
            {
                if (!this.plugins.ContainsKey(pluginName))
                {
                    this.LoadPlugin(pluginName);
                }
                IPlugin pluginInstance = this.GetPluginInstance(pluginName);
                pluginInstance.Load_Form();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public bool LoadPlugin(string pluginName)
        {
            bool flag = false;
            this._config = (PluginConfigurationSection)ConfigurationManager.GetSection("PluginSection");
            PluginConfigurationElement pluginConfigurationElement = new PluginConfigurationElement();
            string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
            try
            {
                for (int i = 0; i < this._config.PluginCollection.Count; i++)
                {
                    pluginConfigurationElement = this._config.PluginCollection[i];
                    if (pluginConfigurationElement.Name == pluginName)
                    {
                        Assembly assembly = Assembly.LoadFile(directoryName + "\\" + pluginConfigurationElement.Assembly);
                        Type type = assembly.GetType(pluginConfigurationElement.Type);
                        IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                        plugin.SystemApplication = this._SystemApplication;
                        this.plugins[pluginName] = plugin;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Not Found the Plugin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            return flag;
        }

        public bool UnLoadPlugin(string pluginName)
        {
            bool flag = false;
            bool result;
            try
            {
                IPlugin pluginInstance = this.GetPluginInstance(pluginName);
                if (pluginInstance == null)
                {
                    result = true;
                    return result;
                }
                pluginInstance.Close_Form();
                this.plugins.Remove(pluginName);
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            result = flag;
            return result;
        }

        public bool UnLoadPlugin(IPlugin plugin)
        {
            bool result = false;
            try
            {
                plugin.Close_Form();
                this.plugins.Remove(plugin.Name);
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public bool LoadPlugin(string pluginName, string pluginFile, string pluginType)
        {
            bool result = false;
            string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
            try
            {
                string path = directoryName + "\\" + pluginFile;
                Assembly assembly = Assembly.LoadFile(path);
                Type type = assembly.GetType(pluginType);
                IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                plugin.SystemApplication = this._SystemApplication;
                plugin.Text = pluginName;
                this.plugins[pluginName] = plugin;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            return result;
        }

        public bool LoadPlugin(PluginInfo pluginInfo)
        {
            bool flag = false;
            string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
            bool result;
            try
            {
                string path = directoryName + "\\" + pluginInfo.PluginFile;
                Assembly assembly = Assembly.LoadFile(path);
                Type type = assembly.GetType(pluginInfo.PluginType);
                IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                pluginInfo.Plugin = plugin;
                pluginInfo.Type = type;
                plugin.SystemApplication = this._SystemApplication;
                this.plugins[pluginInfo.PluginName] = plugin;
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
                return result;
            }
            result = flag;
            return result;
        }

        public void LoadAllPlugin()
        {
            PluginConfigurationElement pluginConfigurationElement = new PluginConfigurationElement();
            this._config = (PluginConfigurationSection)ConfigurationManager.GetSection("PluginSection");
            string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
            try
            {
                for (int i = 0; i < this._config.PluginCollection.Count; i++)
                {
                    pluginConfigurationElement = this._config.PluginCollection[i];
                    Assembly assembly = Assembly.LoadFile(directoryName + "\\" + pluginConfigurationElement.Assembly);
                    Type type = assembly.GetType(pluginConfigurationElement.Type);
                    IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                    plugin.SystemApplication = this._SystemApplication;
                    this.plugins[pluginConfigurationElement.Name] = plugin;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IPlugin GetPluginInstance(string pluginName)
        {
            IPlugin result = null;
            if (this.plugins.ContainsKey(pluginName))
            {
                result = this.plugins[pluginName];
            }
            return result;
        }
    }
}

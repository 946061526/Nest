using System.Configuration;

namespace Nest.Framework.Core
{
    public class PluginConfigurationCollection : ConfigurationElementCollection
    {
        public new PluginConfigurationElement this[string Name]
        {
            get
            {
                return (PluginConfigurationElement)base.BaseGet(Name);
            }
        }

        public PluginConfigurationElement this[int index]
        {
            get
            {
                return (PluginConfigurationElement)base.BaseGet(index);
            }
            set
            {
                if (base.BaseGet(index) != null)
                {
                    base.BaseRemoveAt(index);
                }
                this.BaseAdd(index, value);
            }
        }

        public new int Count
        {
            get
            {
                return base.Count;
            }
        }

        public new string RemoveElementName
        {
            get
            {
                return base.RemoveElementName;
            }
        }

        public new string ClearElementName
        {
            get
            {
                return base.ClearElementName;
            }
            set
            {
                base.AddElementName = value;
            }
        }

        public new string AddElementName
        {
            get
            {
                return base.AddElementName;
            }
            set
            {
                base.AddElementName = value;
            }
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.AddRemoveClearMap;
            }
        }

        protected override void BaseAdd(ConfigurationElement element)
        {
            base.BaseAdd(element, false);
        }

        public void Remove(PluginConfigurationElement pluginElement)
        {
            if (base.BaseIndexOf(pluginElement) >= 0)
            {
                base.BaseRemove(pluginElement.Name);
            }
        }

        public void RemoveAt(int index)
        {
            base.BaseRemoveAt(index);
        }

        public void Remove(string name)
        {
            base.BaseRemove(name);
        }

        public void Clear()
        {
            base.BaseClear();
        }

        public void Add(PluginConfigurationElement pluginElement)
        {
            this.BaseAdd(pluginElement);
        }

        public int IndexOf(PluginConfigurationElement pluginElement)
        {
            return base.BaseIndexOf(pluginElement);
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((PluginConfigurationElement)element).Name;
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new PluginConfigurationElement();
        }
    }
}

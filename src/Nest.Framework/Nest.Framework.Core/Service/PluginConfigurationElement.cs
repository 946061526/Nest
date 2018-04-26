using System.Configuration;

namespace Nest.Framework.Core
{
    public class PluginConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("Name")]
        public string Name
        {
            get
            {
                return (string)base["Name"];
            }
            set
            {
                base["Name"] = value;
            }
        }

        [ConfigurationProperty("Type")]
        public string Type
        {
            get
            {
                return (string)base["Type"];
            }
            set
            {
                base["Type"] = value;
            }
        }

        [ConfigurationProperty("Assembly")]
        public string Assembly
        {
            get
            {
                return (string)base["Assembly"];
            }
            set
            {
                base["Assembly"] = value;
            }
        }

        [ConfigurationProperty("Description")]
        public string Description
        {
            get
            {
                return (string)base["Description"];
            }
            set
            {
                base["Description"] = value;
            }
        }
    }
}

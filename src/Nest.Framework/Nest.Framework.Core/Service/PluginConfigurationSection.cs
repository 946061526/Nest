using System.Configuration;

namespace Nest.Framework.Core
{
    public class PluginConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true)]
        public PluginConfigurationCollection PluginCollection
        {
            get
            {
                return (PluginConfigurationCollection)base[""];
            }
        }
    }
}

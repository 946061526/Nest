using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nest.Framework.Core
{
    public interface IPluginService
    {
        ISystemApplication SystemApplication { get; set; }

        void AddPlugin(string pluginName, string pluginType, string Assembly, string pluginDescription);

        void RemovePlugin(string pluginName);

        string[] GetAllPluginNames();

        bool Contains(string pluginName);

        bool UsePlugin(string pluginName);

        bool LoadPlugin(string pluginName);

        bool LoadPlugin(string pluginName, string pluginFile, string pluginType);

        bool LoadPlugin(PluginInfo pluginInfo);

        bool UnLoadPlugin(string pluginName);

        IPlugin GetPluginInstance(string pluginName);

        void LoadAllPlugin();
    }
}

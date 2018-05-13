using System;
using System.Reflection;

namespace Nest.Framework.Core
{
    public class PluginInfo
    {
        private string modelName;

        private string levelName;

        private string pluginName;

        private string pluginType;

        private string pluginFile;

        private IPlugin plugin;

        private string methodName;

        private Type type;

        public string ModelName
        {
            get
            {
                return this.modelName;
            }
            set
            {
                this.modelName = value;
            }
        }

        public string LevelName
        {
            get
            {
                return this.levelName;
            }
            set
            {
                this.levelName = value;
            }
        }

        public string PluginName
        {
            get
            {
                return this.pluginName;
            }
            set
            {
                this.pluginName = value;
            }
        }

        public string PluginType
        {
            get
            {
                return this.pluginType;
            }
            set
            {
                this.pluginType = value;
            }
        }

        public string PluginFile
        {
            get
            {
                return this.pluginFile;
            }
            set
            {
                this.pluginFile = value;
            }
        }

        public IPlugin Plugin
        {
            get
            {
                return this.plugin;
            }
            set
            {
                this.plugin = value;
            }
        }

        public string MethodName
        {
            get
            {
                return this.methodName;
            }
            set
            {
                this.methodName = value;
            }
        }

        public Type Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public void DoInvoke(string parm)
        {
            try
            {
                string[] parameters = new string[]
                {
                    parm
                };
                MethodInfo method = this.type.GetMethod(this.methodName);
                method.Invoke(this.plugin, parameters);
            }
            catch (Exception ex)
            {
                //throw new Exception("Nest.Framework.Core,PluginInfo.DoInvoke: " + ex.Message);
                System.Windows.Forms.MessageBox.Show("Nest.Framework.Core,PluginInfo.DoInvoke：" + ex.Message);
            }
        }

        public void DoInvoke(object[] obj)
        {
            try
            {
                MethodInfo method = this.type.GetMethod(this.methodName);
                method.Invoke(this.plugin, obj);
            }
            catch (Exception ex)
            {
                //throw new Exception("Nest.Framework.Core,PluginInfo.DoInvoke: " + ex.Message);
                System.Windows.Forms.MessageBox.Show("Nest.Framework.Core,PluginInfo.DoInvoke：" + ex.Message);
            }
        }

        public void DoInvoke(object obj)
        {
            try
            {
                object[] parameters = new object[]
                {
                    obj
                };
                MethodInfo method = this.type.GetMethod(this.methodName);
                method.Invoke(this.plugin, parameters);
            }
            catch (Exception ex)
            {
                //throw new Exception("Nest.Framework.Core,PluginInfo.DoInvoke: " + ex.Message);
                System.Windows.Forms.MessageBox.Show("Nest.Framework.Core,PluginInfo.DoInvoke：" + ex.Message);
            }
        }
    }
}

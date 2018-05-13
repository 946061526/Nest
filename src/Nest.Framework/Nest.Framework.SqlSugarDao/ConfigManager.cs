using Nest.Framework.SysManage;
using System;
using System.IO;
using System.Xml;

namespace Nest.Framework.SqlSugarDao
{
    /// <summary>
    /// 系统配置管理
    /// </summary>
    internal class ConfigManager
    {
        ///// <summary>
        ///// 配置详情
        ///// </summary>
        //public static SystemConfig ConfigInfo
        //{
        //    get
        //    {
        //        return LoadConfig();
        //    }
        //}

        //public void Load()
        //{
        //    ConfigInfo = LoadConfig();

        //    //Task.Factory.StartNew(() => Monitor());
        //}

        public static string DbConnectionStr
        {
            get
            {
                var con = "";
                SystemConfig config = LoadConfig();
                if (config.DbInfo.Type == Utility.DatabaseType.SqlServer)
                    con = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3};"
                        , config.DbInfo.Server, config.DbInfo.DbName, config.DbInfo.Uid, config.DbInfo.Pwd);
                else if (config.DbInfo.Type == Utility.DatabaseType.MySql)
                {
                    con = "";
                }
                return con;
            }
        }

        /// <summary>
        /// 加载配置
        /// </summary>
        /// <returns></returns>
        private static SystemConfig LoadConfig()
        {
            try
            {
                SystemConfig config = new SystemConfig();
                string xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SystemConfig.xml");
                XmlDocument doc = new XmlDocument();
                if (File.Exists(xmlPath))
                {
                    doc.Load(xmlPath);
                    config = Utility.XmlTool.XmlDeserialize<SystemConfig>(doc.OuterXml);
                }
                return config;
            }
            catch
            {
                throw new Exception("加载数据库配置出错：Nest.Framework.SqlSugarDao,ConfigManager.LoadConfig");
            }
        }
    }
}

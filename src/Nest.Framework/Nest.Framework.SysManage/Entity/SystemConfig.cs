using System.Xml.Serialization;

namespace Nest.Framework.SysManage
{
    [XmlRoot("SystemConfig", IsNullable = false)]
    /// <summary>
    /// 系统配置
    /// </summary>
    public class SystemConfig
    {
        /// <summary>
        /// 系统信息
        /// </summary>
        public SysInfo SysInfo { get; set; }
        /// <summary>
        /// 数据库信息
        /// </summary>
        public DbInfo DbInfo { get; set; }
    }

    /// <summary>
    /// 系统信息
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class SysInfo
    {
        /// <summary>
        /// 系统名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 系统版本号
        /// </summary>
        public string Ver { get; set; }
    }

    /// <summary>
    /// 数据库信息
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class DbInfo
    {
        /// <summary>
        /// 数据库类型(oracle,mysql,mssql)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 数据库地址(服务器名或IP)
        /// </summary>
        public string Server { get; set; }

        /// <summary>
        /// 数据库端口号
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// 数据库登录名
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// 数据库登录密码
        /// </summary>
        public string Pwd { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public string DbName { get; set; }
    }
}

using SqlSugar;

namespace Nest.Framework.SqlSugarDao
{
    internal class DbFactory
    {
        /// <summary>  
        /// 获取ORM数据库连接对象(只操作数据库一次的使用, 否则会进行多次数据库连接和关闭)  
        /// 默认超时时间为30秒  
        /// 默认为SqlServer数据库  
        /// 默认自动关闭数据库链接, 多次操作数据库请勿使用该属性, 可能会造成性能问题  
        /// 要自定义请使用GetIntance()方法或者直接使用Exec方法, 传委托  
        /// </summary>  
        public static SqlSugarClient DbClient
        {
            get
            {
                return InitDB(30, DBType.SqlServer, true);
            }
        }

        /// <summary>  
        /// 数据库连接字符串  
        /// </summary>  
        //public static string DBConnectionString { private get; set; } = "Data Source=.;Initial Catalog=hy;Persist Security Info=True;User ID=sa;Password=sa123!@#;";// Configs.DB_ConnectionString;
        public static string DBConnectionString { private get; set; } = ConfigManager.DbConnectionStr;

        /// <summary>  
        /// 获得SqlSugarClient(使用该方法, 默认请手动释放资源, 如using(var db = SugarBase.GetIntance()){你的代码}, 如果把isAutoCloseConnection参数设置为true, 则无需手动释放, 会每次操作数据库释放一次, 可能会影响性能, 请自行判断使用)  
        /// </summary>  
        /// <param name="commandTimeOut">等待超时时间, 默认为30秒 (单位: 秒)</param>  
        /// <param name="dbType">数据库类型, 默认为SQL Server</param>  
        /// <param name="isAutoCloseConnection">是否自动关闭数据库连接, 默认不是, 如果设置为true, 则会在每次操作完数据库后, 即时关闭, 如果一个方法里面多次操作了数据库, 建议保持为false, 否则可能会引发性能问题</param>  
        /// <returns></returns>  
        public static SqlSugarClient GetIntance(int commandTimeOut = 30, DBType dbType = DBType.SqlServer, bool isAutoCloseConnection = false)
        {
            return InitDB(commandTimeOut, dbType, isAutoCloseConnection);
        }

        /// <summary>  
        /// 初始化ORM连接对象, 一般无需调用, 除非要自己写很复杂的数据库逻辑  
        /// </summary>  
        /// <param name="commandTimeOut">等待超时时间, 默认为30秒 (单位: 秒)</param>  
        /// <param name="dbType">数据库类型, 默认为SQL Server</param>  
        /// <param name="isAutoCloseConnection">是否自动关闭数据库连接, 默认不是, 如果设置为true, 则会在每次操作完数据库后, 即时关闭, 如果一个方法里面多次操作了数据库, 建议保持为false, 否则可能会引发性能问题</param>  
        private static SqlSugarClient InitDB(int commandTimeOut = 30, DBType dbType = DBType.SqlServer, bool isAutoCloseConnection = false)
        {
            var db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = DBConnectionString,
                DbType = dbType == DBType.SqlServer ? SqlSugar.DbType.SqlServer : SqlSugar.DbType.MySql,
                InitKeyType = InitKeyType.Attribute,
                IsAutoCloseConnection = isAutoCloseConnection
            });
            db.Ado.CommandTimeOut = commandTimeOut;
            return db;
        }
    }

    /// <summary>  
    /// 数据库类型  
    /// </summary>  
    public enum DBType
    {
        SqlServer = 1,

        MySql = 2
    }
}


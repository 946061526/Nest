namespace Nest.Framework.SysManage
{
    /// <summary>
    /// 菜单及操作项
    /// </summary>
    public class MenuOperation
    {
        /// <summary>
        /// 菜单编号
        /// </summary>
        public int MenuID { get; set; }
        /// <summary>
        /// 操作项编码(如：Add,Delete,Update,Query....)
        /// </summary>
        public string OperationCode { get; set; }
    }
}


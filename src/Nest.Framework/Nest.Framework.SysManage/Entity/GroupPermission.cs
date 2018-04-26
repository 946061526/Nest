namespace Nest.Framework.SysManage
{
    /// <summary>
    /// 用户组权限
    /// </summary>
    public class GroupPermission
    {
        /// <summary>
        /// 用户组编号
        /// </summary>
        public int GroupID { get; set; }
        /// <summary>
        /// 菜单编号
        /// </summary>
        public int MenuID { get; set; }
        /// <summary>
        /// 菜单操作
        /// </summary>
        public string OperationCode { get; set; }
    }
}

namespace Nest.Framework.SysManage
{
    /// <summary>
    /// 用户组信息
    /// </summary>
    public class GroupInfo
    {
        /// <summary>
        /// 用户组编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 用户组名称
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        ///// <summary>
        ///// 用户组权限列表，包括菜单及菜单操作权限
        ///// </summary>
        //public List<GroupPermission> GroupPermissionList { get; set; }
    }
}

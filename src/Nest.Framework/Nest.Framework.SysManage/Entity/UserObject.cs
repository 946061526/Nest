using System.Collections.Generic;

namespace Nest.Framework.SysManage
{
    /// <summary>
    /// 当前登陆用户信息
    /// </summary>
    public class UserObject
    {
        /// <summary>
        /// 用户详细信息
        /// </summary>
        public UserInfo UserInfo { get; set; }
        /// <summary>
        /// 所在部门
        /// </summary>
        public DeptInfo DeptInfo { get; set; }
        /// <summary>
        /// 所在用户组
        /// </summary>
        public GroupInfo GroupInfo { get; set; }
        /// <summary>
        /// 角色权限集合
        /// </summary>
        public List<GroupPermission> GroupPermissionList { get; set; }
        /// <summary>
        /// 角色菜单集合
        /// </summary>
        public List<MenuInfo> MenuList { get; set; }
        /// <summary>
        /// 菜单操作集合
        /// </summary>
        public List<MenuOperation> MenuOperationList { get; set; }
    }
}

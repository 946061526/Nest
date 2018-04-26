namespace Nest.Framework.SysManage
{
    /// <summary>
    /// 菜单信息
    /// </summary>
    public class MenuInfo
    {
        /// <summary>
        /// 菜单编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string CnName { get; set; }
        /// <summary>
        /// 菜单标识
        /// </summary>
        public string EnName { get; set; }
        /// <summary>
        /// 上级菜单编号
        /// </summary>
        public int Pid { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// dll名称
        /// </summary>
        public string DllName { get; set; }
        /// <summary>
        /// 反射名称
        /// </summary>
        public string ReflectType { get; set; }
        /// <summary>
        /// 状态(1.正常 2.不可见 3.删除)
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }
        ///// <summary>
        ///// 菜单操作项集合
        ///// </summary>
        //public List<MenuOperation> MenuOperationList { get; set; }
    }
}

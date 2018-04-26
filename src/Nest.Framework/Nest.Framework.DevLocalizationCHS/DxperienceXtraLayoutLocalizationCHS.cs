using DevExpress.XtraLayout.Localization;

namespace Nest.Framework.DevLocalizationCHS
{
    public class DxperienceXtraLayoutLocalizationCHS : LayoutLocalizer
    {
        public override string GetLocalizedString(LayoutStringId id)
        {
            switch (id)
            {
                case LayoutStringId.CustomizationParentName:
                    return "自定义";
                case LayoutStringId.DefaultItemText:
                    return "项目";
                case LayoutStringId.DefaultActionText:
                    return "默认方式";
                case LayoutStringId.DefaultEmptyText:
                    return "无";
                case LayoutStringId.LayoutItemDescription:
                    return "版面";
                case LayoutStringId.LayoutGroupDescription:
                    return "版面分组";
                case LayoutStringId.TabbedGroupDescription:
                    return "版面标签组";
                case LayoutStringId.LayoutControlDescription:
                    return "版面控件";
                case LayoutStringId.CustomizationFormTitle:
                    return "自定义";
                case LayoutStringId.HiddenItemsPageTitle:
                    return "隐藏项目";
                case LayoutStringId.TreeViewPageTitle:
                    return "版面视图";
                case LayoutStringId.RenameSelected:
                    return "重命名";
                case LayoutStringId.HideItemMenutext:
                    return "隐藏项目";
                case LayoutStringId.LockItemSizeMenuText:
                    return "锁定项目大小";
                case LayoutStringId.UnLockItemSizeMenuText:
                    return "解开锁定项目大小";
                case LayoutStringId.GroupItemsMenuText:
                    return "分组";
                case LayoutStringId.UnGroupItemsMenuText:
                    return "取消分组";
                case LayoutStringId.CreateTabbedGroupMenuText:
                    return "创建标签";
                case LayoutStringId.AddTabMenuText:
                    return "新增标签";
                case LayoutStringId.UnGroupTabbedGroupMenuText:
                    return "移除标签";
                case LayoutStringId.TreeViewRootNodeName:
                    return "根目录";
                case LayoutStringId.ShowCustomizationFormMenuText:
                    return "显示自定义窗体";
                case LayoutStringId.HideCustomizationFormMenuText:
                    return "隐藏自定义窗体";
                case LayoutStringId.EmptySpaceItemDefaultText:
                    return "空项";
                case LayoutStringId.ControlGroupDefaultText:
                    return "组";
                case LayoutStringId.EmptyRootGroupText:
                    return "拖动到这";
                case LayoutStringId.EmptyTabbedGroupText:
                    return "拖动分组到标题区";
                case LayoutStringId.ResetLayoutMenuText:
                    return "重置版面";
                case LayoutStringId.RenameMenuText:
                    return "重命名";
                case LayoutStringId.TextPositionMenuText:
                    return "文本位置";
                case LayoutStringId.TextPositionLeftMenuText:
                    return "左";
                case LayoutStringId.TextPositionRightMenuText:
                    return "右";
                case LayoutStringId.TextPositionTopMenuText:
                    return "上";
                case LayoutStringId.TextPositionBottomMenuText:
                    return "下";
                case LayoutStringId.ShowTextMenuItem:
                    return "显示文本";
                case LayoutStringId.LockSizeMenuItem:
                    return "锁定大小";
                case LayoutStringId.LockWidthMenuItem:
                    return "锁定宽度";
                case LayoutStringId.LockHeightMenuItem:
                    return "锁定高度";
            }
            return base.GetLocalizedString(id);
        }
        public override string Language
        {
            get
            {
                return "简体中文";
            }
        }
    }
}

using DevExpress.XtraPivotGrid.Localization;

namespace Nest.Framework.DevLocalizationCHS
{
    public class DxperienceXtraPivotGridLocalizationCHS : PivotGridLocalizer
    {
        public override string GetLocalizedString(PivotGridStringId id)
        {
            switch (id)
            {
                case PivotGridStringId.RowHeadersCustomization:
                    return "拖动行至此";
                case PivotGridStringId.ColumnHeadersCustomization:
                    return "拖动列至此";
                case PivotGridStringId.FilterHeadersCustomization:
                    return "拖动筛选字段至此";
                case PivotGridStringId.DataHeadersCustomization:
                    return "拖动数据项至此";
                case PivotGridStringId.RowArea:
                    return "行区";
                case PivotGridStringId.ColumnArea:
                    return "列区";
                case PivotGridStringId.FilterArea:
                    return "筛选区";
                case PivotGridStringId.DataArea:
                    return "数据区";
                case PivotGridStringId.FilterShowAll:
                    return "显示全部";
                case PivotGridStringId.FilterShowBlanks:
                    return "显示空白";
                case PivotGridStringId.CustomizationFormCaption:
                    return "PivotGrid字段列表";
                case PivotGridStringId.CustomizationFormText:
                    return "拖动数据项至PivotGrid";
                case PivotGridStringId.CustomizationFormAddTo:
                    return "添加到";
                case PivotGridStringId.Total:
                    return "合计";
                case PivotGridStringId.GrandTotal:
                    return "总计";
                case PivotGridStringId.TotalFormat:
                    return "{0} 合计";
                case PivotGridStringId.TotalFormatCount:
                    return "{0} 计数";
                case PivotGridStringId.TotalFormatSum:
                    return "{0} 总数";
                case PivotGridStringId.TotalFormatMin:
                    return "{0} 最小";
                case PivotGridStringId.TotalFormatMax:
                    return "{0} 最大";
                case PivotGridStringId.TotalFormatAverage:
                    return "{0} 平均";
                case PivotGridStringId.TotalFormatStdDev:
                    return "{0} 标准差估计";
                case PivotGridStringId.TotalFormatStdDevp:
                    return "{0} 扩展标准差";
                case PivotGridStringId.TotalFormatVar:
                    return "{0} 变异数估计";
                case PivotGridStringId.TotalFormatVarp:
                    return "{0} 扩展变异数";
                case PivotGridStringId.TotalFormatCustom:
                    return "{0} 自定义";
                case PivotGridStringId.PrintDesignerPageOptions:
                    return "选项";
                case PivotGridStringId.PrintDesignerPageBehavior:
                    return "状态";
                case PivotGridStringId.PrintDesignerCategoryDefault:
                    return "默认";
                case PivotGridStringId.PrintDesignerCategoryLines:
                    return "线";
                case PivotGridStringId.PrintDesignerCategoryHeaders:
                    return "标题";
                case PivotGridStringId.PrintDesignerHorizontalLines:
                    return "水平线";
                case PivotGridStringId.PrintDesignerVerticalLines:
                    return "垂直线";
                case PivotGridStringId.PrintDesignerFilterHeaders:
                    return "筛选标题";
                case PivotGridStringId.PrintDesignerDataHeaders:
                    return "数据标题";
                case PivotGridStringId.PrintDesignerColumnHeaders:
                    return "列标题";
                case PivotGridStringId.PrintDesignerRowHeaders:
                    return "行标题";
                case PivotGridStringId.PrintDesignerUsePrintAppearance:
                    return "使用打印版面";
                case PivotGridStringId.PopupMenuRefreshData:
                    return "更新数据";
                case PivotGridStringId.PopupMenuHideField:
                    return "隐藏";
                case PivotGridStringId.PopupMenuShowFieldList:
                    return "显示字段列表";
                case PivotGridStringId.PopupMenuHideFieldList:
                    return "隐藏字段列表";
                case PivotGridStringId.PopupMenuFieldOrder:
                    return "排序";
                case PivotGridStringId.PopupMenuMovetoBeginning:
                    return "移到开头";
                case PivotGridStringId.PopupMenuMovetoLeft:
                    return "移到左边";
                case PivotGridStringId.PopupMenuMovetoRight:
                    return "移到右边";
                case PivotGridStringId.PopupMenuMovetoEnd:
                    return "移到最后";
                case PivotGridStringId.PopupMenuCollapse:
                    return "收缩";
                case PivotGridStringId.PopupMenuExpand:
                    return "展开";
                case PivotGridStringId.PopupMenuCollapseAll:
                    return "全部收缩";
                case PivotGridStringId.PopupMenuExpandAll:
                    return "全部展开";
                case PivotGridStringId.DataFieldCaption:
                    return "数据";
                case PivotGridStringId.TopValueOthersRow:
                    return "其它";
            }
            return base.GetLocalizedString(id);
        }
    }
}

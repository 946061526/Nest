using DevExpress.XtraBars.Customization;
using DevExpress.XtraBars.Localization;

namespace Nest.Framework.DevLocalizationCHS
{
    public class DxperienceXtraBarsLocalizationCHS : BarLocalizer
    {
        protected override CustomizationControl CreateCustomizationControl()
        {
            return new DevExpressXtraBarsCustomizationLocalizationCHS();
        }
        public override string GetLocalizedString(BarString id)
        {
            switch (id)
            {
                case BarString.None:
                    return "";
                case BarString.AddOrRemove:
                    return "新增或删除按钮(&A)";
                case BarString.ResetBar:
                    return "是否确实要重置对 '{0}' 工具栏所作的修改？";
                case BarString.ResetBarCaption:
                    return "自定义";
                case BarString.ResetButton:
                    return "重设工具栏(&R)";
                case BarString.CustomizeButton:
                    return "自定义(&C)";
                case BarString.ToolBarMenu:
                    return "重设(&R)$删除(&D)$!命名(&N)$!标准(&L)$总使用文字(&T)$在菜单中只用文字(&O)$图像与文本(&A)$!开始一组(&G)$常用的(&M)";
                case BarString.ToolbarNameCaption:
                    return "工具栏名称(&T):";
                case BarString.NewToolbarCaption:
                    return "新建工具栏";
                case BarString.NewToolbarCustomNameFormat:
                    return "自定义 {0}";
                case BarString.RenameToolbarCaption:
                    return "重新命名";
                case BarString.CustomizeWindowCaption:
                    return "自定义";
                case BarString.MenuAnimationSystem:
                    return "(系统默认)";
                case BarString.MenuAnimationNone:
                    return "空";
                case BarString.MenuAnimationSlide:
                    return "滚动";
                case BarString.MenuAnimationFade:
                    return "减弱";
                case BarString.MenuAnimationUnfold:
                    return "展开";
                case BarString.MenuAnimationRandom:
                    return "随机";
            }
            return base.GetLocalizedString(id);
        }
    }
}

using DevExpress.XtraNavBar;

namespace Nest.Framework.DevLocalizationCHS
{
    public class DxperienceXtraNavBarLocalizationCHS : NavBarLocalizer
    {
        public override string GetLocalizedString(NavBarStringId id)
        {
            switch (id)
            {
                case NavBarStringId.NavPaneMenuShowMoreButtons:
                    return "显示更多的按钮(&M)";
                case NavBarStringId.NavPaneMenuShowFewerButtons:
                    return "显示较少的按钮(&F)";
                case NavBarStringId.NavPaneMenuAddRemoveButtons:
                    return "添加或删除按钮(&A)";
                case NavBarStringId.NavPaneChevronHint:
                    return "配置按钮";
            }
            return base.GetLocalizedString(id);
        }
    }
}

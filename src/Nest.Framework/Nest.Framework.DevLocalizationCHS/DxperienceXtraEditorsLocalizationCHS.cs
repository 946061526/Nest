using DevExpress.XtraEditors.Controls;

namespace Nest.Framework.DevLocalizationCHS
{
    public class DxperienceXtraEditorsLocalizationCHS : Localizer
    {
        public override string GetLocalizedString(StringId id)
        {
            switch (id)
            {
                case StringId.None:
                    return "";
                case StringId.CaptionError:
                    return "错误";
                case StringId.InvalidValueText:
                    return "无效的值";
                case StringId.CheckChecked:
                    return "选中";
                case StringId.CheckUnchecked:
                    return "未选中";
                case StringId.CheckIndeterminate:
                    return "未选择";
                case StringId.DateEditToday:
                    return "今天";
                case StringId.DateEditClear:
                    return "清除";
                case StringId.OK:
                    return "确定(&O)";
                case StringId.Cancel:
                    return "取消(&C)";
                case StringId.NavigatorFirstButtonHint:
                    return "第一条";
                case StringId.NavigatorPreviousButtonHint:
                    return "上一条";
                case StringId.NavigatorPreviousPageButtonHint:
                    return "上一页";
                case StringId.NavigatorNextButtonHint:
                    return "下一条";
                case StringId.NavigatorNextPageButtonHint:
                    return "下一页";
                case StringId.NavigatorLastButtonHint:
                    return "最后一条";
                case StringId.NavigatorAppendButtonHint:
                    return "添加";
                case StringId.NavigatorRemoveButtonHint:
                    return "删除";
                case StringId.NavigatorEditButtonHint:
                    return "编辑";
                case StringId.NavigatorEndEditButtonHint:
                    return "结束编辑";
                case StringId.NavigatorCancelEditButtonHint:
                    return "取消编辑";
                case StringId.NavigatorTextStringFormat:
                    return "记录{0}/{1}";
                case StringId.PictureEditMenuCut:
                    return "剪贴";
                case StringId.PictureEditMenuCopy:
                    return "复制";
                case StringId.PictureEditMenuPaste:
                    return "粘贴";
                case StringId.PictureEditMenuDelete:
                    return "删除";
                case StringId.PictureEditMenuLoad:
                    return "读取";
                case StringId.PictureEditMenuSave:
                    return "保存";
                case StringId.PictureEditOpenFileFilter:
                    return "Bitmap Files (*.bmp)|*.bmp|Graphics Interchange Format (*.gif)|*.gif|JPEG File Interchange Format (*.jpg;*.jpeg)|*.jpg;*.jpeg|Icon Files (*.ico)|*.ico|All Picture Files |*.bmp;*.gif;*.jpg;*.jpeg;*.ico;*.png;*.tif|All Files |*.*";
                case StringId.PictureEditSaveFileFilter:
                    return "Bitmap Files (*.bmp)|*.bmp|Graphics Interchange Format (*.gif)|*.gif|JPEG File Interchange Format (*.jpg)|*.jpg";
                case StringId.PictureEditOpenFileTitle:
                    return "打开";
                case StringId.PictureEditSaveFileTitle:
                    return "另存为";
                case StringId.PictureEditOpenFileError:
                    return "错误的图片格式";
                case StringId.PictureEditOpenFileErrorCaption:
                    return "打开错误";
                case StringId.LookUpEditValueIsNull:
                    return "[无数据]";
                case StringId.LookUpInvalidEditValueType:
                    return "无效的数据类型";
                case StringId.LookUpColumnDefaultName:
                    return "名称";
                case StringId.MaskBoxValidateError:
                    return "输入数值不完整. 是否须要修改?\r\n\r\n是 - 回到编辑模式以修改数值.\r\n否 - 保持原来数值.\r\n取消 - 回复原来数值.\r\n";
                case StringId.UnknownPictureFormat:
                    return "不明图片格式";
                case StringId.DataEmpty:
                    return "无图像";
                case StringId.NotValidArrayLength:
                    return "无效的数组长度.";
                case StringId.ImagePopupEmpty:
                    return "(空)";
                case StringId.ImagePopupPicture:
                    return "(图片)";
                case StringId.ColorTabCustom:
                    return "自定";
                case StringId.ColorTabWeb:
                    return "网络";
                case StringId.ColorTabSystem:
                    return "系统";
                case StringId.CalcButtonMC:
                    return "MC";
                case StringId.CalcButtonMR:
                    return "MR";
                case StringId.CalcButtonMS:
                    return "MS";
                case StringId.CalcButtonMx:
                    return "M+";
                case StringId.CalcButtonSqrt:
                    return "sqrt";
                case StringId.CalcButtonBack:
                    return "Back";
                case StringId.CalcButtonCE:
                    return "CE";
                case StringId.CalcButtonC:
                    return "C";
                case StringId.CalcError:
                    return "计算错误";
                case StringId.TabHeaderButtonPrev:
                    return "向左滚动";
                case StringId.TabHeaderButtonNext:
                    return "向右滚动";
                case StringId.TabHeaderButtonClose:
                    return "关闭";
                case StringId.XtraMessageBoxOkButtonText:
                    return "确定(&O)";
                case StringId.XtraMessageBoxCancelButtonText:
                    return "取消(&C)";
                case StringId.XtraMessageBoxYesButtonText:
                    return "是(&Y)";
                case StringId.XtraMessageBoxNoButtonText:
                    return "否(&N)";
                case StringId.XtraMessageBoxAbortButtonText:
                    return "中断(&A)";
                case StringId.XtraMessageBoxRetryButtonText:
                    return "重试(&R)";
                case StringId.XtraMessageBoxIgnoreButtonText:
                    return "忽略(&I)";
                case StringId.TextEditMenuUndo:
                    return "撤消(&U)";
                case StringId.TextEditMenuCut:
                    return "剪贴(&T)";
                case StringId.TextEditMenuCopy:
                    return "复制(&C)";
                case StringId.TextEditMenuPaste:
                    return "粘贴(&P)";
                case StringId.TextEditMenuDelete:
                    return "删除(&D)";
                case StringId.TextEditMenuSelectAll:
                    return "全选(&A)";
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

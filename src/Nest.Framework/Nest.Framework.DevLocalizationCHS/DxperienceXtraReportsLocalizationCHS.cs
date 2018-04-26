using DevExpress.XtraReports.Localization;

namespace Nest.Framework.DevLocalizationCHS
{
    public class DxperienceXtraReportsLocalizationCHS : ReportLocalizer
    {
        public override string GetLocalizedString(ReportStringId id)
        {
            switch (id)
            {
                case ReportStringId.Msg_FileNotFound:
                    return "文件没有找到";
                case ReportStringId.Msg_WrongReportClassName:
                    return "一个错误发生在并行化期间 - 可能是报表类名错误";
                case ReportStringId.Msg_CreateReportInstance:
                    return "您试图打开一个不同类型的报表来编辑。\r\n是否确定建立实例？";
                case ReportStringId.Msg_FileCorrupted:
                    return "不能加载报表，文件可能被破坏或者报表组件丢失。";
                case ReportStringId.Msg_FileContentCorrupted:
                    return "不能加载报表布局，文件可能损坏或包含错误的信息。";
                case ReportStringId.Msg_IncorrectArgument:
                    return "参数值输入不正确";
                case ReportStringId.Msg_InvalidMethodCall:
                    return "对象的当前状态下不能调用此方法";
                case ReportStringId.Msg_ScriptError:
                    return "在脚本中发现错误：\r\n{0}";
                case ReportStringId.Msg_ScriptExecutionError:
                    return "在脚本执行过程中发现错误 {0}:\r\n {1}\r\n过程 {0} 被运行，将不能再被调用。";
                case ReportStringId.Msg_InvalidReportSource:
                    return "无法设置原报表";
                case ReportStringId.Msg_IncorrectBandType:
                    return "无效的带型";
                //case ReportStringId.Msg_InvPropName:
                //    return "无效的属性名";
                //case ReportStringId.Msg_CantFitBarcodeToControlBounds:
                //    return "条形码控件的边界太小";
                //case ReportStringId.Msg_InvalidBarcodeText:
                //    return "在文本中有无效的字符";
                //case ReportStringId.Msg_InvalidBarcodeTextFormat:
                //    return "无效的文本格式";
                case ReportStringId.Msg_CreateSomeInstance:
                    return "在窗体中不能建立两个实例类。";
                case ReportStringId.Msg_DontSupportMulticolumn:
                    return "详细报表不支持多字段。";
                case ReportStringId.Msg_FillDataError:
                    return "数据加载时发生错误。错误为：";
                //case ReportStringId.Msg_CyclicBoormarks:
                //    return "报表循环书签";
                case ReportStringId.Msg_LargeText:
                    return "文本太长";
                case ReportStringId.Msg_ScriptingPermissionErrorMessage:
                    return "在此报表不允许运行脚本。\n\n信息:\n\n{0}";
                //case ReportStringId.Msg_ScriptingErrorTitle:
                //    return "脚本错误";
                case ReportStringId.Cmd_InsertDetailReport:
                    return "插入详细报表";
                case ReportStringId.Cmd_InsertUnboundDetailReport:
                    return "非绑定";
                case ReportStringId.Cmd_ViewCode:
                    return "检视代码";
                case ReportStringId.Cmd_BringToFront:
                    return "移到最上层";
                case ReportStringId.Cmd_SendToBack:
                    return "移到最下层";
                case ReportStringId.Cmd_AlignToGrid:
                    return "对齐网格线";
                case ReportStringId.Cmd_TopMargin:
                    return "顶端边缘";
                case ReportStringId.Cmd_BottomMargin:
                    return "底端边缘";
                case ReportStringId.Cmd_ReportHeader:
                    return "报表首";
                case ReportStringId.Cmd_ReportFooter:
                    return "报表尾";
                case ReportStringId.Cmd_PageHeader:
                    return "页首";
                case ReportStringId.Cmd_PageFooter:
                    return "页尾";
                case ReportStringId.Cmd_GroupHeader:
                    return "群组首";
                case ReportStringId.Cmd_GroupFooter:
                    return "群组尾";
                case ReportStringId.Cmd_Detail:
                    return "详细";
                case ReportStringId.Cmd_DetailReport:
                    return "详细报表";
                case ReportStringId.Cmd_RtfClear:
                    return "清除";
                case ReportStringId.Cmd_RtfLoad:
                    return "加载文件";
                case ReportStringId.Cmd_TableInsert:
                    return "插入(&I)";
                case ReportStringId.Cmd_TableInsertRowAbove:
                    return "上行(&A)";
                case ReportStringId.Cmd_TableInsertRowBelow:
                    return "下行(&B)";
                case ReportStringId.Cmd_TableInsertColumnToLeft:
                    return "左列(&L)";
                case ReportStringId.Cmd_TableInsertColumnToRight:
                    return "右列(&R)";
                case ReportStringId.Cmd_TableInsertCell:
                    return "单元格(&C)";
                case ReportStringId.Cmd_TableDelete:
                    return "删除(&L)";
                case ReportStringId.Cmd_TableDeleteRow:
                    return "行(&R)";
                case ReportStringId.Cmd_TableDeleteColumn:
                    return "列(&C)";
                case ReportStringId.Cmd_TableDeleteCell:
                    return "单元格(&L)";
                case ReportStringId.Cmd_Cut:
                    return "剪贴";
                case ReportStringId.Cmd_Copy:
                    return "复制";
                case ReportStringId.Cmd_Paste:
                    return "粘贴";
                case ReportStringId.Cmd_Delete:
                    return "删除";
                case ReportStringId.Cmd_Properties:
                    return "属性";
                case ReportStringId.Cmd_InsertBand:
                    return "插入区段";
                case ReportStringId.CatLayout:
                    return "布局";
                case ReportStringId.CatAppearance:
                    return "版面";
                case ReportStringId.CatData:
                    return "数据";
                case ReportStringId.CatBehavior:
                    return "状态";
                case ReportStringId.CatNavigation:
                    return "导航";
                case ReportStringId.CatPageSettings:
                    return "页面设置";
                case ReportStringId.CatUserDesigner:
                    return "用户设计";
                case ReportStringId.BandDsg_QuantityPerPage:
                    return "一个页面集合";
                case ReportStringId.BandDsg_QuantityPerReport:
                    return "一个报表集合";
                case ReportStringId.UD_ReportDesigner:
                    return "XtraReport设计";
                case ReportStringId.UD_Msg_ReportChanged:
                    return "报表内容已被修改，是否须要储存？";
                case ReportStringId.UD_TTip_FileOpen:
                    return "打开文件";
                case ReportStringId.UD_TTip_FileSave:
                    return "保存文件";
                case ReportStringId.UD_TTip_EditCut:
                    return "剪贴";
                case ReportStringId.UD_TTip_EditCopy:
                    return "复制";
                case ReportStringId.UD_TTip_EditPaste:
                    return "粘贴";
                case ReportStringId.UD_TTip_Undo:
                    return "撤消";
                case ReportStringId.UD_TTip_Redo:
                    return "恢复";
                case ReportStringId.UD_TTip_AlignToGrid:
                    return "对齐网格线";
                case ReportStringId.UD_TTip_AlignLeft:
                    return "对齐主控项的左缘";
                case ReportStringId.UD_TTip_AlignVerticalCenters:
                    return "对齐主控项的水平中央";
                case ReportStringId.UD_TTip_AlignRight:
                    return "对齐主控项的右缘";
                case ReportStringId.UD_TTip_AlignTop:
                    return "对齐主控项的上缘";
                case ReportStringId.UD_TTip_AlignHorizontalCenters:
                    return "对齐主控项的垂直中间";
                case ReportStringId.UD_TTip_AlignBottom:
                    return "对齐主控项的下缘";
                case ReportStringId.UD_TTip_SizeToControlWidth:
                    return "设置成相同宽度";
                case ReportStringId.UD_TTip_SizeToGrid:
                    return "依网格线调整大小";
                case ReportStringId.UD_TTip_SizeToControlHeight:
                    return "设置成相同高度";
                case ReportStringId.UD_TTip_SizeToControl:
                    return "设置成相同大小";
                case ReportStringId.UD_TTip_HorizSpaceMakeEqual:
                    return "将水平间距设成相等";
                case ReportStringId.UD_TTip_HorizSpaceIncrease:
                    return "增加水平间距";
                case ReportStringId.UD_TTip_HorizSpaceDecrease:
                    return "减少水平间距";
                case ReportStringId.UD_TTip_HorizSpaceConcatenate:
                    return "移除水平间距";
                case ReportStringId.UD_TTip_VertSpaceMakeEqual:
                    return "将垂直间距设为相等";
                case ReportStringId.UD_TTip_VertSpaceIncrease:
                    return "增加垂直间距";
                case ReportStringId.UD_TTip_VertSpaceDecrease:
                    return "减少垂直间距";
                case ReportStringId.UD_TTip_VertSpaceConcatenate:
                    return "移除垂直间距";
                case ReportStringId.UD_TTip_CenterHorizontally:
                    return "水平置中";
                case ReportStringId.UD_TTip_CenterVertically:
                    return "垂直置中";
                case ReportStringId.UD_TTip_BringToFront:
                    return "移到最上层";
                case ReportStringId.UD_TTip_SendToBack:
                    return "移到最下层";
                case ReportStringId.UD_TTip_FormatBold:
                    return "粗体";
                case ReportStringId.UD_TTip_FormatItalic:
                    return "斜体";
                case ReportStringId.UD_TTip_FormatUnderline:
                    return "下划线";
                case ReportStringId.UD_TTip_FormatAlignLeft:
                    return "左对齐";
                case ReportStringId.UD_TTip_FormatCenter:
                    return "居中";
                case ReportStringId.UD_TTip_FormatAlignRight:
                    return "右对齐";
                case ReportStringId.UD_TTip_FormatFontName:
                    return "字体";
                case ReportStringId.UD_TTip_FormatFontSize:
                    return "大小";
                case ReportStringId.UD_TTip_FormatForeColor:
                    return "前景颜色";
                case ReportStringId.UD_TTip_FormatBackColor:
                    return "背景颜色";
                case ReportStringId.UD_TTip_FormatJustify:
                    return "两端对齐";
                case ReportStringId.UD_FormCaption:
                    return "XtraReport设计";
                //case ReportStringId.VS_XtraReportsToolboxCategoryName:
                //    return "Developer Express: 报表";
                case ReportStringId.UD_XtraReportsToolboxCategoryName:
                    return "标准控制";
                case ReportStringId.UD_XtraReportsPointerItemCaption:
                    return "指针";
                case ReportStringId.Verb_EditBands:
                    return "编辑区域";
                case ReportStringId.Verb_EditGroupFields:
                    return "编辑组字段";
                case ReportStringId.Verb_Import:
                    return "导入";
                case ReportStringId.Verb_Save:
                    return "保存";
                case ReportStringId.Verb_About:
                    return "关于";
                case ReportStringId.Verb_RTFClear:
                    return "清除";
                case ReportStringId.Verb_RTFLoad:
                    return "加载文件";
                case ReportStringId.Verb_FormatString:
                    return "格式化字符串";
                case ReportStringId.Verb_SummaryWizard:
                    return "总结";
                case ReportStringId.Verb_ReportWizard:
                    return "向导";
                case ReportStringId.Verb_Insert:
                    return "插入";
                case ReportStringId.Verb_Delete:
                    return "删除";
                case ReportStringId.Verb_Bind:
                    return "赋值";
                case ReportStringId.Verb_EditText:
                    return "文本编辑";
                //case ReportStringId.FSForm_Lbl_Category:
                //    return "类别";
                //case ReportStringId.FSForm_Lbl_Prefix:
                //    return "上标";
                //case ReportStringId.FSForm_Lbl_Suffix:
                //    return "下标";
                //case ReportStringId.FSForm_Lbl_CustomGeneral:
                //    return "一般格式不包含特殊数字格式";
                //case ReportStringId.FSForm_GrBox_Sample:
                //    return "范例";
                //case ReportStringId.FSForm_Tab_StandardTypes:
                //    return "标准类型";
                //case ReportStringId.FSForm_Tab_Custom:
                //    return "自定义";
                //case ReportStringId.FSForm_Msg_BadSymbol:
                //    return "损坏的符号";
                //case ReportStringId.FSForm_Btn_Delete:
                //    return "删除";
                case ReportStringId.BCForm_Lbl_Property:
                    return "属性";
                case ReportStringId.BCForm_Lbl_Binding:
                    return "结合";
                //case ReportStringId.SSForm_Caption:
                //    return "式样单编辑";
                //case ReportStringId.SSForm_Btn_Close:
                //    return "关闭";
                case ReportStringId.SSForm_Msg_NoStyleSelected:
                    return "没有式样被选中";
                case ReportStringId.SSForm_Msg_MoreThanOneStyle:
                    return "你选择了多过一个以上的式样";
                case ReportStringId.SSForm_Msg_SelectedStylesText:
                    return "被选中的式样";
                //case ReportStringId.SSForm_Msg_StyleSheetError:
                //    return "StyleSheet错误";
                case ReportStringId.SSForm_Msg_InvalidFileFormat:
                    return "无效的文件格式";
                case ReportStringId.SSForm_Msg_StyleNamePreviewPostfix:
                    return " 式样";
                case ReportStringId.SSForm_Msg_FileFilter:
                    return "Report StyleSheet files (*.repss)|*.repss|All files (*.*)|*.*";
                //case ReportStringId.SSForm_TTip_AddStyle:
                //    return "添加式样";
                //case ReportStringId.SSForm_TTip_RemoveStyle:
                //    return "移除式样";
                //case ReportStringId.SSForm_TTip_ClearStyles:
                //    return "清除式样";
                //case ReportStringId.SSForm_TTip_PurgeStyles:
                //    return "清除式样";
                //case ReportStringId.SSForm_TTip_SaveStyles:
                //    return "保存式样到文件";
                //case ReportStringId.SSForm_TTip_LoadStyles:
                //    return "从文件中读入式样";
                //case ReportStringId.FindForm_Msg_FinishedSearching:
                //    return "搜索文件完成";
                //case ReportStringId.FindForm_Msg_TotalFound:
                //    return "合计查找:";
                case ReportStringId.RepTabCtl_HtmlView:
                    return "HTML视图";
                case ReportStringId.RepTabCtl_Preview:
                    return "预览";
                case ReportStringId.RepTabCtl_Designer:
                    return "设计";
                case ReportStringId.PanelDesignMsg:
                    return "在此可放置不同控件";
                case ReportStringId.MultiColumnDesignMsg1:
                    return "重复列之间的空位";
                case ReportStringId.MultiColumnDesignMsg2:
                    return "控件位置不正确，将会导致打印错误";
                case ReportStringId.UD_Group_File:
                    return "文件(&F)";
                case ReportStringId.UD_Group_Edit:
                    return "编辑(&E)";
                case ReportStringId.UD_Group_View:
                    return "视图(&V)";
                case ReportStringId.UD_Group_Format:
                    return "格式(&R)";
                case ReportStringId.UD_Group_Font:
                    return "字体(&F)";
                case ReportStringId.UD_Group_Justify:
                    return "两端对齐(&J)";
                case ReportStringId.UD_Group_Align:
                    return "对齐(&A)";
                case ReportStringId.UD_Group_MakeSameSize:
                    return "设置成相同大小(M)";
                case ReportStringId.UD_Group_HorizontalSpacing:
                    return "水平间距(&H)";
                case ReportStringId.UD_Group_VerticalSpacing:
                    return "垂直间距(&V)";
                case ReportStringId.UD_Group_CenterInForm:
                    return "对齐窗体中央(&C)";
                case ReportStringId.UD_Group_Order:
                    return "顺序(&O)";
                case ReportStringId.UD_Group_ToolbarsList:
                    return "工具栏(&T)";
                case ReportStringId.UD_Group_DockPanelsList:
                    return "窗口(&W)";
                case ReportStringId.UD_Capt_MainMenuName:
                    return "主菜单";
                case ReportStringId.UD_Capt_ToolbarName:
                    return "工具栏";
                case ReportStringId.UD_Capt_LayoutToolbarName:
                    return "布局工具栏";
                case ReportStringId.UD_Capt_FormattingToolbarName:
                    return "格式工具栏";
                case ReportStringId.UD_Capt_StatusBarName:
                    return "状态栏";
                case ReportStringId.UD_Capt_NewReport:
                    return "新增(&N)";
                case ReportStringId.UD_Capt_NewWizardReport:
                    return "向导(&W)";
                case ReportStringId.UD_Capt_OpenFile:
                    return "开启(&O)";
                case ReportStringId.UD_Capt_SaveFile:
                    return "保存(&S)";
                case ReportStringId.UD_Capt_SaveFileAs:
                    return "另存为(&A)";
                case ReportStringId.UD_Capt_Exit:
                    return "结束(&X)";
                case ReportStringId.UD_Capt_Cut:
                    return "剪切(&T)";
                case ReportStringId.UD_Capt_Copy:
                    return "复制(&C)";
                case ReportStringId.UD_Capt_Paste:
                    return "粘贴(&P)";
                case ReportStringId.UD_Capt_Delete:
                    return "删除(&D)";
                case ReportStringId.UD_Capt_SelectAll:
                    return "全选(&A)";
                case ReportStringId.UD_Capt_Undo:
                    return "复原(&U)";
                case ReportStringId.UD_Capt_Redo:
                    return "重复(&R)";
                case ReportStringId.UD_Capt_ForegroundColor:
                    return "前景色(&E)";
                case ReportStringId.UD_Capt_BackGroundColor:
                    return "背景色(&K)";
                case ReportStringId.UD_Capt_FontBold:
                    return "粗体(&B)";
                case ReportStringId.UD_Capt_FontItalic:
                    return "斜体(&I)";
                case ReportStringId.UD_Capt_FontUnderline:
                    return "底线(&U)";
                case ReportStringId.UD_Capt_JustifyLeft:
                    return "靠左(&L)";
                case ReportStringId.UD_Capt_JustifyCenter:
                    return "居中(&C)";
                case ReportStringId.UD_Capt_JustifyRight:
                    return "靠右(&R)";
                case ReportStringId.UD_Capt_JustifyJustify:
                    return "两端对齐(&J)";
                case ReportStringId.UD_Capt_AlignLefts:
                    return "左(&L)";
                case ReportStringId.UD_Capt_AlignCenters:
                    return "置中(&C)";
                case ReportStringId.UD_Capt_AlignRights:
                    return "右(&R)";
                case ReportStringId.UD_Capt_AlignTops:
                    return "上(&T)";
                case ReportStringId.UD_Capt_AlignMiddles:
                    return "中间(&M)";
                case ReportStringId.UD_Capt_AlignBottoms:
                    return "下(&B)";
                case ReportStringId.UD_Capt_AlignToGrid:
                    return "网格线(&G)";
                case ReportStringId.UD_Capt_MakeSameSizeWidth:
                    return "宽度(&W)";
                case ReportStringId.UD_Capt_MakeSameSizeSizeToGrid:
                    return "依网格线调整大小(&D)";
                case ReportStringId.UD_Capt_MakeSameSizeHeight:
                    return "高度(&H)";
                case ReportStringId.UD_Capt_MakeSameSizeBoth:
                    return "两者(&B)";
                case ReportStringId.UD_Capt_SpacingMakeEqual:
                    return "设成相等(&E)";
                case ReportStringId.UD_Capt_SpacingIncrease:
                    return "增加(&I)";
                case ReportStringId.UD_Capt_SpacingDecrease:
                    return "减少(&D)";
                case ReportStringId.UD_Capt_SpacingRemove:
                    return "移除(&R)";
                case ReportStringId.UD_Capt_CenterInFormHorizontally:
                    return "水平(&H)";
                case ReportStringId.UD_Capt_CenterInFormVertically:
                    return "垂直(&V)";
                case ReportStringId.UD_Capt_OrderBringToFront:
                    return "提到最上层(&B)";
                case ReportStringId.UD_Capt_OrderSendToBack:
                    return "移到最下层(&S)";
                case ReportStringId.UD_Hint_NewReport:
                    return "创建新报表";
                case ReportStringId.UD_Hint_NewWizardReport:
                    return "用向导创建新报表";
                case ReportStringId.UD_Hint_OpenFile:
                    return "打开报表";
                case ReportStringId.UD_Hint_SaveFile:
                    return "储存报表";
                case ReportStringId.UD_Hint_SaveFileAs:
                    return "另起新名储存报表";
                case ReportStringId.UD_Hint_Exit:
                    return "关闭设计师";
                case ReportStringId.UD_Hint_Cut:
                    return "删除控件和复制到剪贴板";
                case ReportStringId.UD_Hint_Copy:
                    return "复制控件到剪贴板";
                case ReportStringId.UD_Hint_Paste:
                    return "从剪贴板添加控件";
                case ReportStringId.UD_Hint_Delete:
                    return "删除控件";
                case ReportStringId.UD_Hint_SelectAll:
                    return "全选";
                case ReportStringId.UD_Hint_Undo:
                    return "复原最后操作";
                case ReportStringId.UD_Hint_Redo:
                    return "重复最后操作";
                case ReportStringId.UD_Hint_ForegroundColor:
                    return "设置前景色";
                case ReportStringId.UD_Hint_BackGroundColor:
                    return "设置背景色";
                case ReportStringId.UD_Hint_FontBold:
                    return "粗体";
                case ReportStringId.UD_Hint_FontItalic:
                    return "斜体";
                case ReportStringId.UD_Hint_FontUnderline:
                    return "底线";
                case ReportStringId.UD_Hint_JustifyLeft:
                    return "靠左";
                case ReportStringId.UD_Hint_JustifyCenter:
                    return "居中";
                case ReportStringId.UD_Hint_JustifyRight:
                    return "靠右";
                case ReportStringId.UD_Hint_JustifyJustify:
                    return "两端对齐";
                case ReportStringId.UD_Hint_AlignLefts:
                    return "被选控件左对齐";
                case ReportStringId.UD_Hint_AlignCenters:
                    return "被选纵向控件居中对齐";
                case ReportStringId.UD_Hint_AlignRights:
                    return "被选控件右对齐";
                case ReportStringId.UD_Hint_AlignTops:
                    return "被选控件上对齐";
                case ReportStringId.UD_Hint_AlignMiddles:
                    return "被选横向控件居中对齐";
                case ReportStringId.UD_Hint_AlignBottoms:
                    return "被选控件下对齐";
                case ReportStringId.UD_Hint_AlignToGrid:
                    return "被选控件依线格对齐";
                case ReportStringId.UD_Hint_MakeSameSizeWidth:
                    return "被选控件设置成相同宽度";
                case ReportStringId.UD_Hint_MakeSameSizeSizeToGrid:
                    return "被选控件依线格调整大小";
                case ReportStringId.UD_Hint_MakeSameSizeHeight:
                    return "被选控件设置成相同高度";
                case ReportStringId.UD_Hint_MakeSameSizeBoth:
                    return "被选控件设置成相同大小";
                case ReportStringId.UD_Hint_SpacingMakeEqual:
                    return "被选控件间距设成相等";
                case ReportStringId.UD_Hint_SpacingIncrease:
                    return "增加被选控件的间距";
                case ReportStringId.UD_Hint_SpacingDecrease:
                    return "减少被选控件的间距";
                case ReportStringId.UD_Hint_SpacingRemove:
                    return "移除被选控件的间距";
                case ReportStringId.UD_Hint_CenterInFormHorizontally:
                    return "被选控件水平对齐窗体中央";
                case ReportStringId.UD_Hint_CenterInFormVertically:
                    return "被选控件垂直对齐窗体中央";
                case ReportStringId.UD_Hint_OrderBringToFront:
                    return "被选控件提到最上层";
                case ReportStringId.UD_Hint_OrderSendToBack:
                    return "被选控件提到最下层";
                case ReportStringId.UD_Hint_ViewBars:
                    return "显示/隐藏{0}";
                case ReportStringId.UD_Hint_ViewDockPanels:
                    return "显示/隐藏 {0} 窗口";
                case ReportStringId.UD_Hint_ViewTabs:
                    return "转到 {0} 标签";
                case ReportStringId.UD_Title_FieldList:
                    return "字段清单";
                case ReportStringId.UD_Title_ReportExplorer:
                    return "报表资源管理器";
                case ReportStringId.UD_Title_PropertyGrid:
                    return "属性";
                case ReportStringId.UD_Title_ToolBox:
                    return "工具箱";
                //case ReportStringId.STag_Name_Text:
                //    return "文本";
                case ReportStringId.STag_Name_DataBinding:
                    return "数据连接";
                case ReportStringId.STag_Name_FormatString:
                    return "字符串格式";
                //case ReportStringId.STag_Name_ForeColor:
                //    return "前景色";
                //case ReportStringId.STag_Name_BackColor:
                //    return "背景色";
                //case ReportStringId.STag_Name_Font:
                //    return "字体";
                //case ReportStringId.STag_Name_LineDirection:
                //    return "线条方向";
                //case ReportStringId.STag_Name_LineStyle:
                //    return "线条样式";
                //case ReportStringId.STag_Name_LineWidth:
                //    return "线条宽度";
                //case ReportStringId.STag_Name_CanGrow:
                //    return "增长";
                //case ReportStringId.STag_Name_CanShrink:
                //    return "收缩";
                //case ReportStringId.STag_Name_Multiline:
                //    return "多线";
                //case ReportStringId.STag_Name_Summary:
                //    return "摘要";
                //case ReportStringId.STag_Name_Symbology:
                //    return "符号";
                //case ReportStringId.STag_Name_Module:
                //    return "模块数";
                //case ReportStringId.STag_Name_ShowText:
                //    return "显示文本";
                //case ReportStringId.STag_Name_SegmentWidth:
                //    return "分段宽度";
                case ReportStringId.STag_Name_Checked:
                    return "选中";
                //case ReportStringId.STag_Name_Image:
                //    return "图像";
                //case ReportStringId.STag_Name_ImageUrl:
                //    return "图像位置(URL)";
                //case ReportStringId.STag_Name_ImageSizing:
                //    return "图象尺寸";
                //case ReportStringId.STag_Name_ReportSource:
                //    return "报表来源";
                case ReportStringId.STag_Name_PreviewRowCount:
                    return "预览行数";
                    //case ReportStringId.STag_Name_ShrinkSubReportIconArea:
                    //    return "收缩子报表的图标区域";
                    //case ReportStringId.STag_Name_PageInfo:
                    //    return "页码信息";
                    //case ReportStringId.STag_Name_StartPageNumber:
                    //    return "起始页码";
            }
            return base.GetLocalizedString(id);
        }
    }
}

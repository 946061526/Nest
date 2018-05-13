namespace Nest.Framework.Core
{
    public interface IPlugin
    {
        ISystemApplication SystemApplication { get; set; }

        string Name { get; set; }

        string Text { get; set; }

        bool IsAddButtonEnabeld { get; }

        bool IsUpdateButtonEnabeld { get; }

        bool IsQueryButtonEnabeld { get; }

        bool IsDelButtonEnabeld { get; }

        bool IsImportButtonEnabeld { get; }

        bool IsExportButtonEnabeld { get; }

        bool IsReportButtonEnabeld { get; }

        bool IsSaveButtonEnabeld { get; }

        bool IsClearButtonEnabeld { get; }

        void Load_Form();

        void Close_Form();

        void IsAddButton_Click();

        void IsUpdateButton_Click();

        void IsQueryButton_Click();

        void IsDelButton_Click();

        void IsExportButton_Click();

        void IsImportButton_Click();

        void IsReportButton_Click();

        void IsSaveButton_Click();

        void IsClearButton_Click();
    }
}

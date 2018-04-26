using System.Windows.Forms;

namespace Nest.Framework.Utility
{
    /// <summary>
    /// 弹窗辅助类
    /// </summary>
    public class MessageBoxTool
    {
        /// <summary>
        /// 普通消息提示
        /// </summary>
        /// <param name="msg">提示内容</param>
        /// <param name="caption">标题</param>
        public static void Message(string text, string caption = "系统提示")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK);
        }

        /// <summary>
        /// 警告消息提示
        /// </summary>
        /// <param name="msg">提示内容</param>
        /// <param name="title">标题</param>
        public static void Warning(string text, string caption = "系统警告")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 错误消息提示
        /// </summary>
        /// <param name="msg">提示内容</param>
        /// <param name="title">标题</param>
        public static void Error(string text, string caption = "错误提示")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 待确认的消息提示
        /// </summary>
        /// <param name="msg">提示内容</param>
        /// <param name="title">标题</param>
        /// <returns>DialogResult</returns>
        public static DialogResult Confirm(string text, string caption = "系统提示")
        {
            return MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}

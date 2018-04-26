using System;
using System.IO;
using System.Text;

namespace Nest.Framework.Utility
{
    /// <summary>
    /// 文本日志记录辅助类
    /// </summary>
    public class Logger
    {
        static string LogFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
        static bool RecordLog = true;
        static bool DebugLog = false;

        static Logger()
        {
            if (!Directory.Exists(LogFolder))
            {
                Directory.CreateDirectory(LogFolder);
            }
            RecordLog = Common.GetConfigValue("RecordLog") == "1";
            DebugLog = Common.GetConfigValue("DebugLog") == "1";
        }

        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="logType"></param>
        /// <param name="source"></param>
        /// <param name="title"></param>
        /// <param name="content"></param>
        public static void WriteLog(LogType logType, string source, string title, string content)
        {
            string fileName = string.Format("{0}-{1}.log", DateTime.Now.ToString("yyyyMMdd"), logType.ToString());
            StringBuilder str = new StringBuilder(DateTime.Now.ToString("【yyyy-MM-dd HH:mm:ss】\r\n"));
            str.AppendFormat("[{\"source\":{0},\"title\":{1},\"content\":{2}}]", source, title, content);
            str.Append("\r\n\r\n");
            try
            {
                if (RecordLog)
                {
                    File.AppendAllText(Path.Combine(LogFolder, fileName), str.ToString(), Encoding.GetEncoding("GB2312"));
                }
                if (DebugLog)
                {
                    Console.WriteLine(str);
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 异常或错误
        /// </summary>
        /// <param name="source">来源 (类名.函数名)</param>
        /// <param name="title">标题</param>
        /// <param name="content">具体内容</param>
        public static void Error(string source, string title, string content)
        {
            WriteLog(LogType.Error, source, title, content);
        }
        /// <summary>
        /// 一般信息
        /// </summary>
        /// <param name="source">来源 (类名.函数名)</param>
        /// <param name="title">标题</param>
        /// <param name="content">具体内容</param>
        public static void Info(string source, string title, string content)
        {
            WriteLog(LogType.Info, source, title, content);
        }
        /// <summary>
        /// 调试信息
        /// </summary>
        /// <param name="source">来源 (类名.函数名)</param>
        /// <param name="title">标题</param>
        /// <param name="content">具体内容</param>
        public static void Debug(string source, string title, string content)
        {
            WriteLog(LogType.Debug, source, title, content);
        }
    }
}

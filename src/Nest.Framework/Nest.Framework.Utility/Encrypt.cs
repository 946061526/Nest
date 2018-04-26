using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Nest.Framework.Utility
{
    /// <summary>
    /// 加密辅助类
    /// </summary>
    public class Encrypt
    {
        private static string key = Common.GetConfigValue("AesEncryptKey");
        private static string iv = Common.GetConfigValue("AesEncryptIV");

        /// <summary>
        /// aes加密后 进行 Base64 加密
        /// </summary>
        /// <param name="toEncrypt"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        public static string AESEncrypt(string toEncrypt)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(key);
            byte[] ivArray = Encoding.UTF8.GetBytes(iv);
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);

            RijndaelManaged rDel = new RijndaelManaged
            {
                Key = keyArray,
                IV = ivArray,
                Mode = CipherMode.CBC
            };
            //rDel.Padding = PaddingMode.Zeros; //结尾会有\0

            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            string base64Str = Convert.ToBase64String(resultArray, 0, resultArray.Length).Replace("\n", "").Replace("\r", "")
                .Replace('+', '-').Replace('/', '_');
            return base64Str;
        }

        public static string AESDecrypt(string toDecrypt)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(key);
            byte[] ivArray = Encoding.UTF8.GetBytes(iv);
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt.Replace('-', '+').Replace('_', '/'));

            RijndaelManaged rDel = new RijndaelManaged
            {
                Key = keyArray,
                IV = ivArray,
                Mode = CipherMode.CBC
            };
            //rDel.Padding = PaddingMode.Zeros; //结尾会有\0

            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        /// 获取字符串的MD5加密
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string MD5String(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>  
        /// 获取文件的MD5码  
        /// </summary>  
        /// <param name="fileName">传入的文件名（含路径及后缀名）</param>  
        /// <returns></returns>  
        public static string MD5File(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// SHA256加密(返回64位)
        /// </summary>
        /// <param name="strData"></param>
        /// <returns></returns>
        public static string SHA256_64(string strData)
        {
            byte[] bytValue = Encoding.UTF8.GetBytes(strData);
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            byte[] retVal = sha256.ComputeHash(bytValue);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }

    }
}

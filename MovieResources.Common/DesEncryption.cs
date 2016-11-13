using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.Common
{
    /// <summary>
    /// DES加密类
    /// </summary>
    public class DesEncryption
    {
        /// <summary>
        /// 对字符串进行DES加密
        /// </summary>
        /// <param name="pToEncrypt">待加密字符串</param>
        /// <returns>加密后字符串</returns>
        public static string Encrypt(string pToEncrypt)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputeByteArray = Encoding.Default.GetBytes(pToEncrypt);
            des.Key = ASCIIEncoding.ASCII.GetBytes("abcdefgh");
            des.IV = ASCIIEncoding.ASCII.GetBytes("abcdefgh");
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputeByteArray, 0, inputeByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();
            return ret.ToString();
        }
    }
}

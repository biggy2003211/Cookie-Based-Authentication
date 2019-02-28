using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Cookie_Based_Authentication.BLL
{
    public class sha256
    {
        /// <summary>
        /// 使用 sha256 雜湊加密
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public string Encryption_sha256(string password)
        {
            //建立一個SHA256
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            //將字串轉為Byte[]
            Console.WriteLine("請輸入密碼:");
            byte[] source = Encoding.Default.GetBytes(password);
            //進行SHA256加密
            byte[] crypto = sha256.ComputeHash(source);
            //把加密後的字串從Byte[]轉為字串
            string result = Convert.ToBase64String(crypto);
            return result;
        }
    }
}
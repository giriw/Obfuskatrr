using System;
using System.Text;
using System.Security.Cryptography;
namespace Obfuskatr
{
    public static class Engine
    {
        public static string MD5(string value)
        {
          Byte[] originalBytes;
          Byte[] encodedBytes;
          MD5 md5;

          md5 = new MD5CryptoServiceProvider();
          originalBytes = ASCIIEncoding.Default.GetBytes(value);
          encodedBytes = md5.ComputeHash(originalBytes);

          return BitConverter.ToString(encodedBytes).Replace("-", "").ToLower();
        }
    }
}

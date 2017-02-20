
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSA3
{
    class Program
    {
        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="text">加密字符</param>
        /// <param name="password">加密的密码</param>
        /// <param name="iv">密钥</param>
        /// <returns></returns>
        public static string AESEncrypt(string text, string password, string iv)
        {
            int err = 0;
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.None;
            rijndaelCipher.KeySize = 128;
            rijndaelCipher.BlockSize = 128;
            rijndaelCipher.FeedbackSize = 128;
            //byte[] pwdBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] pwdBytes = HexEncoding.GetBytes(password, out err);
            byte[] keyBytes = new byte[16];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length) len = keyBytes.Length;
            System.Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            //byte[] ivBytes = System.Text.Encoding.UTF8.GetBytes(iv);
            byte[] ivBytes = HexEncoding.GetBytes(iv, out err);
            rijndaelCipher.IV = ivBytes;// new byte[16];
            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();
            byte[] plainText = HexEncoding.GetBytes(text, out err); 
            byte[] cipherBytes = transform.TransformFinalBlock(plainText, 0, plainText.Length);
            //Console.WriteLine(HexEncoding.ToString(cipherBytes));
            return HexEncoding.ToString(cipherBytes);
            //return Convert.ToBase64String(cipherBytes);
        }
        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="text"></param>
        /// <param name="password"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        public static string AESDecrypt(string text, string password, string iv)
        {
            int err = 0;
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.None;
            rijndaelCipher.KeySize = 128;
            rijndaelCipher.BlockSize = 128;
            byte[] encryptedData = HexEncoding.GetBytes(text, out err);
            byte[] pwdBytes = HexEncoding.GetBytes(password, out err);
            //System.Text.Encoding.UTF8.GetBytes(password);
            byte[] keyBytes = new byte[16];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length) len = keyBytes.Length;
            System.Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            byte[] ivBytes = HexEncoding.GetBytes(iv, out err); 
            //System.Text.Encoding.UTF8.GetBytes(iv);
            rijndaelCipher.IV = ivBytes;
            ICryptoTransform transform = rijndaelCipher.CreateDecryptor();
            byte[] plainText = transform.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            //Console.WriteLine(HexEncoding.ToString(plainText));
            return HexEncoding.ToString(plainText);
            //return Encoding.UTF8.GetString(plainText);
        }

        static void OutputMark()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Gray;
        }

        static void OutputNormal()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }


        static void Main(string[] args)
        {
            
            //密码
            string passwordhex = CSA3_TestVectors.passwd;
            //加密初始化向量
            string ivhex = CSA3_TestVectors.iv;
            int offset = 0;

            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------Test Case 1--------------------");
            Console.WriteLine("No Adaptation Field");
            string cleartexthex = CSA3_TestVectors.CASE_1_TS_clear;
            offset = 4;
            int length = (188 - 4) / 16 * 16;            
            cleartexthex = cleartexthex.Replace(" ", "");
            cleartexthex = cleartexthex.Substring(offset * 2, length*2);

            OutputMark();
            Console.Write(CSA3_TestVectors.CASE_1_TS_clear.Substring(0, offset * 3));
            OutputNormal();
            string message = AESEncrypt(cleartexthex, passwordhex, ivhex);
            Console.Write(message);
            OutputMark();
            Console.WriteLine(CSA3_TestVectors.CASE_1_TS_clear.Substring((offset + length)*3));
            OutputNormal();

            OutputMark();
            Console.Write(CSA3_TestVectors.CASE_1_TS_clear.Substring(0, offset * 3));
            OutputNormal();
            message = message.Replace(" ", "");
            message = AESDecrypt(message, passwordhex, ivhex);
            Console.Write(message);
            OutputMark();
            Console.WriteLine(CSA3_TestVectors.CASE_1_TS_clear.Substring((offset + length) * 3));
            OutputNormal();

            Console.WriteLine("------------Test Case 2--------------------");
            Console.WriteLine("7-byte Adaptation Field");
            cleartexthex = CSA3_TestVectors.CASE_2_TS_clear;
            offset = 11;
            length = (188 - offset) / 16 * 16;
            cleartexthex = cleartexthex.Replace(" ", "");
            cleartexthex = cleartexthex.Substring(11 * 2, length * 2);

            OutputMark();
            Console.Write(CSA3_TestVectors.CASE_2_TS_clear.Substring(0, offset * 3));
            OutputNormal();
            message = AESEncrypt(cleartexthex, passwordhex, ivhex);
            Console.Write(message);
            OutputMark();
            Console.WriteLine(CSA3_TestVectors.CASE_2_TS_clear.Substring((offset + length) * 3));
            OutputNormal();

            OutputMark();
            Console.Write(CSA3_TestVectors.CASE_2_TS_clear.Substring(0, offset * 3));
            OutputNormal();
            message = message.Replace(" ", "");
            message = AESDecrypt(message, passwordhex, ivhex);
            Console.Write(message);
            OutputMark();
            Console.WriteLine(CSA3_TestVectors.CASE_2_TS_clear.Substring((offset + length) * 3));
            OutputNormal();

            Console.WriteLine("------------Test Case 3--------------------");
            Console.WriteLine("8-byte Adaptation Field");
            cleartexthex = CSA3_TestVectors.CASE_3_TS_clear;
            offset = 12;
            length = (188 - offset) / 16 * 16;
            cleartexthex = cleartexthex.Replace(" ", "");
            cleartexthex = cleartexthex.Substring(offset * 2, length * 2);

            OutputMark();
            Console.Write(CSA3_TestVectors.CASE_3_TS_clear.Substring(0, offset * 3));
            OutputNormal();
            message = AESEncrypt(cleartexthex, passwordhex, ivhex);
            Console.Write(message);
            if((offset + length) < 188)
            {
                OutputMark();
                Console.WriteLine(CSA3_TestVectors.CASE_3_TS_clear.Substring((offset + length) * 3));
                OutputNormal();
            }
            else
            {
                Console.WriteLine();
            }

            OutputMark();
            Console.Write(CSA3_TestVectors.CASE_3_TS_clear.Substring(0, offset * 3));
            OutputNormal();
            message = message.Replace(" ", "");
            message = AESDecrypt(message, passwordhex, ivhex);
            Console.Write(message);
            if ((offset + length) < 188)
            {
                OutputMark();
                Console.WriteLine(CSA3_TestVectors.CASE_3_TS_clear.Substring((offset + length) * 3));
                OutputNormal();
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine("------------Test Case 4--------------------");
            Console.WriteLine("9-byte Adaptation Field");
            cleartexthex = CSA3_TestVectors.CASE_4_TS_clear;
            offset = 13;
            length = (188 - offset) / 16 * 16;
            cleartexthex = cleartexthex.Replace(" ", "");
            cleartexthex = cleartexthex.Substring(offset * 2, length * 2);

            OutputMark();
            Console.Write(CSA3_TestVectors.CASE_4_TS_clear.Substring(0, offset * 3));
            OutputNormal();
            message = AESEncrypt(cleartexthex, passwordhex, ivhex);
            Console.Write(message);
            OutputMark();
            Console.WriteLine(CSA3_TestVectors.CASE_4_TS_clear.Substring((offset + length) * 3));
            OutputNormal();

            OutputMark();
            Console.Write(CSA3_TestVectors.CASE_4_TS_clear.Substring(0, offset * 3));
            OutputNormal();
            message = message.Replace(" ", "");
            message = AESDecrypt(message, passwordhex, ivhex);
            Console.Write(message);
            OutputMark();
            Console.WriteLine(CSA3_TestVectors.CASE_4_TS_clear.Substring((offset + length) * 3));
            OutputNormal();

        }
    }
}

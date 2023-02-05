using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor.Encrypt
{
    public class AESEncrypt
    {
        public string Key { get; set; }
        public CipherMode Mode { get; set; }
        public byte[] Salt { get; set; }

        public AESEncrypt()
        {
            Key = "ENCKEY";
            Mode = CipherMode.CBC;
            Salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        }

        private Aes GetAES()
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(Key);

            Aes AES = Aes.Create();
            AES.KeySize = 256;
            AES.BlockSize = 128;

            var key = new Rfc2898DeriveBytes(passwordBytes, Salt, 1000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Mode = Mode;
            return AES;
        }

        public byte[] Encrypt(string filename)
        {
            byte[] bytes = File.ReadAllBytes(filename);
            return Encrypt(bytes);
        }
        public byte[] Decrypt(string filename)
        {
            byte[] bytes = File.ReadAllBytes(filename);

            return Decrypt(bytes);
        }
        public byte[] Encrypt(byte[] bytes)
        {
            using Aes AES = GetAES();

            using MemoryStream ms = new();
            using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cs.Write(bytes, 0, bytes.Length);
                cs.Close();
            }
            byte[] encryptedBytes = ms.ToArray();

            return encryptedBytes;
        }

        public byte[] Decrypt(byte[] bytes)
        {
            using Aes AES = GetAES();

            using MemoryStream ms = new();
            using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
            {
                cs.Write(bytes, 0, bytes.Length);
                cs.Close();
            }

            return ms.ToArray();
        }
    }
}

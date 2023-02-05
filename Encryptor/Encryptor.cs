using Encryptor.Encrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    internal class Encryptor
    {
        const string CONFIG_FILE = "encryptor.config";
        readonly Config config;
        readonly AESEncrypt encryptor;
        public string Directory {
            get
            {
                return config.Directory;
            }
            set
            {
                config.Directory = value;
                OnChangeKey?.Invoke(value);
            }
        }
        public string Key
        {
            get
            {
                return config.Key;
            }
            set
            {
                encryptor.Key = value;
                config.Key = value;
                OnChangeDirectory?.Invoke(value);
            }
        }

        public Action<string>? OnChangeKey { get; set; }
        public Action<string>? OnChangeDirectory { get; set; }

        public Encryptor()
        {
            config = new Config();
            encryptor = new AESEncrypt();

            config.Load(CONFIG_FILE);

            Directory = config.Directory;
            Key = config.Key;
        }

        public bool EncryptAndExport(string source, string dest)
        {
            try
            {
                var bytes = encryptor.Encrypt(source);
                File.WriteAllBytes(dest, bytes);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public bool DecryptAndExport(string source, string dest)
        {
            try
            {
                var bytes = encryptor.Decrypt(source);
                File.WriteAllBytes(dest, bytes);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public void SaveConfig()
        {
            config.Save(CONFIG_FILE);
        }
    }
}

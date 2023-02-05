using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    public class Config
    {
        public string Key { get; set; }
        public string Directory { get; set; }

        public Config()
        {
            Key = "PleaseTypeKey";
            Directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public void Load(string filename)
        {
            var dict = new Dictionary<string, string>();
            try
            {
                dict.Import(filename);

                Key = dict["key"];
                Directory = dict["directory"];
            }
            catch (Exception)
            {

            }
        }

        public void Save(string filename)
        {
            var dict = new Dictionary<string, string>
            {
                { "key", Key },
                { "directory", Directory }
            };

            dict.Export(filename);
        }
    }
}

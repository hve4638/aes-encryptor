using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    public static class DictionaryExtender
    {
        public static void Export(this Dictionary<string, string> dict, string filename)
        {
            string exportedString = "";
            foreach (KeyValuePair<string, string> pair in dict)
            {
                exportedString += pair.Key + "=" + pair.Value + ";\n";
            }

            File.WriteAllText(filename, exportedString);
        }

        public static void Import(this Dictionary<string, string> dict, string filename)
        {
            var contents = File.ReadAllText(filename);

            string[] keyValuePairs = contents.Replace("\n", "").Split(';');
            foreach (string keyValuePair in keyValuePairs)
            {
                if (keyValuePair.Length > 0)
                {
                    string[] parts = keyValuePair.Split('=');
                    dict.Add(parts[0], parts[1]);
                }
            }
        }
    }
}

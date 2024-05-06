using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace MP3TagEditor.Settings
{
    [Serializable]
    public class CustomRpl
    {
        public string[] arguments;
        string path;

        public CustomRpl(string inputPath)
        {
            path = inputPath + "CustomRpl.cres";
        }

        public bool TestingCustomArg()
        {
            if (File.Exists(path))
            {
                LoadData();
                return true;
            }
            else
            {
                arguments = new string[0];
                return false;
            }
        }

        public void AddNew(string inputString)
        {
            string[] newarguments = new string[arguments.Length + 1];

            for (int i = 0; i < arguments.Length; i++)
                newarguments[i] = arguments[i];

            newarguments[newarguments.Count() - 1] = inputString;
            arguments = newarguments;
        }

        public void Remove(int inputInt)
        {
            string[] newarguments = new string[arguments.Length - 1];

            for (int i = 0; i < arguments.Length; i++)
            {
                if(!(i == inputInt) && i < inputInt)
                    newarguments[i] = arguments[i];
                else if(!(i == inputInt) && i > inputInt)
                    newarguments[i - 1] = arguments[i];
            }
            arguments = newarguments;
        }

        public void LoadData()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            arguments = (string[])bf.Deserialize(fs);
            fs.Close();
        }

        public void SaveData()
        {
            if(arguments.Length > 0)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                bf.Serialize(fs, arguments);
                fs.Close();
            }
            else
            {
                File.Delete(path);
            }
        }
    }
}

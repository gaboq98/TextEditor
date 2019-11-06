using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.FileSaver
{
    class JsonFileSaver : IFileSaver
    {

        public void save(string txt, string file)
        {
            System.Console.WriteLine(txt);
            auxJson formatted = new auxJson(txt);
            System.Console.WriteLine(formatted.getStringList()[0]);
            string jsonTxt = JsonConvert.SerializeObject(formatted);
            System.IO.File.WriteAllText(file, jsonTxt);

        }

        public class auxJson
        {
            public string[] stringList;
            
            public auxJson(String str)
            {
                this.stringList = str.Split('\n');
            }

            public string[] getStringList()
            {
                return this.stringList;
            }

        }

    }
}

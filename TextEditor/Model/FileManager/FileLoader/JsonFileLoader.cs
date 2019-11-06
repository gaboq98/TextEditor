using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.FileLoader
{
    class JsonFileLoader : IFileLoader
    {
        public string load(string file)
        {
            string txt = "";
            string formatted = System.IO.File.ReadAllText(file);

            dynamic d = JObject.Parse(formatted);
            foreach (var s in d.stringList)
            {
                txt = txt + s;
            }

            return txt;
        }

    }
}

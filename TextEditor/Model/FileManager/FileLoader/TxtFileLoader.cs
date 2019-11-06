using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.FileLoader
{
    class TxtFileLoader : IFileLoader
    {
        public string load(string file)
        {
            string text = System.IO.File.ReadAllText(file);
            return text;
        }
    }
}

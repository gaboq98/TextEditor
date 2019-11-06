using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.FileLoader
{
    class CsvFileLoader : IFileLoader
    {
        public string load(string file)
        {
            string formatted = System.IO.File.ReadAllText(file);
            string text = formatted.Replace(",", " ");
            return text;
        }
    }
}

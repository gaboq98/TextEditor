﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.FileSaver
{
    class CsvFileSaver : IFileSaver
    {
        public void save(string txt, string file)
        {
            string formatted = txt.Replace(" ", ",");
            System.IO.File.WriteAllText(file, formatted);
        }
    }
}

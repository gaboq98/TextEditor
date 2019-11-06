using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.FileSaver
{
    class TabFileSaver : IFileSaver
    {
        public void save(string txt, string file)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < txt.Length; i++)
            {
                if (i % 10 == 0)
                    sb.Append('\t');
                sb.Append(txt[i]);
            }
            string formatted = sb.ToString();
            System.IO.File.WriteAllText(file, formatted);
        }

    }
}

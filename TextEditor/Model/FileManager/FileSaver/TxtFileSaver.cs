using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Model.FileSaver
{
    class TxtFileSaver : IFileSaver
    {
        public void save(String txt, string file)
        {
            System.IO.File.WriteAllText(file, txt);
        }
    }
}

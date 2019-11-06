using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Model.FileSaver
{
    interface IFileSaver
    {
        void save(String txt, String file);
    }
}

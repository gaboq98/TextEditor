using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.FileLoader
{
    interface IFileLoader
    {
        string load(String file);
    }
}

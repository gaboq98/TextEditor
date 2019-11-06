using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextEditor.Model.FileSaver
{
    class XmlFileSaver : IFileSaver
    {
        public void save(string txt, string file)
        {
            string[] stringList = txt.Split('\n');
            XDocument xdoc = new XDocument();
            xdoc.Add(new XElement("root", stringList.Select(x => new XElement("paragraph", x))));
            xdoc.Save(file);
        }
    }
}

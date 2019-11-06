using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace TextEditor.Model.FileLoader
{
    class XmlFileLoader : IFileLoader
    {
        public string load(string file)
        {
            string txt = "";
            var doc = XDocument.Load(file);
            var paragraphs = doc.XPathSelectElements("/root/paragraph");
            foreach (var p in paragraphs)
            {
                txt = txt + p.Value;
            }
            return txt;
        }
    }
}

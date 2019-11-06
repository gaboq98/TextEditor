using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.FileSaver
{
    class PdfFileSaver : IFileSaver
    {
        public void save(string txt, string file)
        {
            Document doc = new Document(PageSize.A4);
            var output = new FileStream(file, FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            doc.Add(new Paragraph(txt));

            doc.Close();
            writer.Close();
        }
    }
}

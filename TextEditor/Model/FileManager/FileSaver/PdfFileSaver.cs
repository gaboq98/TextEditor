using Aspose.Words;
using Aspose.Words.Saving;
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
            /*
            Document doc = new Document(PageSize.A4);
            var output = new FileStream(file, FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            doc.Add(new Paragraph(txt));

            doc.Close();
            writer.Close();
            */
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(txt)))
            {
                Document doc = new Document(stream);

                PdfSaveOptions pdfSaveOptions = new PdfSaveOptions
                {
                    SaveFormat = SaveFormat.Pdf

                };

                using (MemoryStream streamText = new MemoryStream())
                {
                    // save will convert to a pdf
                    doc.Save(streamText, pdfSaveOptions);
                    doc.Save(file, pdfSaveOptions);
                    //return streamText.ToArray();
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PdfSharp;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using PdfSharp.Forms;
using PdfSharp.Fonts;
using PdfSharp.Drawing;
using AcroPDFLib;
using AxAcroPDFLib;

namespace archive
{
    class PdfClass
    {
        public String CreatePdfs( DataTable Dt)
        {
            string[] Paths = new string[Dt.Rows.Count];
            byte[][] PdfsData = new byte[Dt.Rows.Count][];
            String FinalPath = System.String.Empty;
            for (int index = 0; index < Dt.Rows.Count; index++)
            {
                PdfsData[index] = Dt.Rows[index][0] as byte[];
                Paths[index] = @"C: \Users\Public\Documents\temp.pdf'" + index.ToString() + "'.pdf";
                System.IO.File.WriteAllBytes(Paths[index], PdfsData[index]);
            }
            FinalPath = CombinePdfs(Paths);
            return FinalPath;
        }

        public String CombinePdfs(string[] Paths)
        {
            String FinalPath = @"C:\Users\Public\Documents\tempfinal.pdf";
            PdfDocument[] Documents = new PdfDocument[Paths.Length];
            PdfDocument OutPdf = new PdfDocument();
            for (int i = 0; i < Paths.Length; i++)
            {
                Documents[i] = PdfReader.Open(Paths[i], PdfDocumentOpenMode.Import);
                CopyPages(Documents[i], OutPdf);
            }
            OutPdf.Save(FinalPath);
            return FinalPath;
        }

        void CopyPages(PdfDocument from, PdfDocument to)
        {
            for (int i = 0; i < from.PageCount; i++)
            {
                to.AddPage(from.Pages[i]);
            }
        }
    }
}

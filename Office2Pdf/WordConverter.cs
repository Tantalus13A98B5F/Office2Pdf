using Word = Microsoft.Office.Interop.Word;

namespace Office2Pdf
{
    public class WordConverter : IConverter
    {
        const Word.WdExportFormat exportAsPDF = Word.WdExportFormat.wdExportFormatPDF;

        public bool Convert2Pdf(string src, string dst)
        {
            Word.Application app = null;
            Word.Document document = null;
            try
            {
                app = new Word.Application();
                document = app.Documents.Open(src);
                if (document != null)
                {
                    document.ExportAsFixedFormat(dst, exportAsPDF);
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (document != null)
                {
                    document.Close();
                    document = null;
                }
                if (app != null)
                {
                    app.Quit();
                    app = null;
                }
            }
        }
    }
}
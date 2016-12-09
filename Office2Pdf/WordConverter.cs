using System;
using Word = Microsoft.Office.Interop.Word;

namespace Office2Pdf
{
	/// <summary>
	/// Description of WordConverter.
	/// </summary>
	public class WordConverter: IConverter
	{
		const Word.WdExportFormat exportAsPDF = Word.WdExportFormat.wdExportFormatPDF;
		public bool Convert2Pdf(string src, string dst)
		{
			dynamic app = null; // Word.ApplicationClass
			dynamic document = null; // Word.Document
			try
			{
				app = new Word.ApplicationClass();
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

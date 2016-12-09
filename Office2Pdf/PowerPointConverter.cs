using System;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;

namespace Office2Pdf
{
	/// <summary>
	/// Description of PowerPointConverter.
	/// </summary>
	public class PowerPointConverter: IConverter
	{
		const MsoTriState msoTrue = MsoTriState.msoTrue;
		const MsoTriState msoFalse = MsoTriState.msoFalse;
		const PowerPoint.PpSaveAsFileType saveAsPDF = PowerPoint.PpSaveAsFileType.ppSaveAsPDF;
		public bool Convert2Pdf(string src, string dst)
		{
			PowerPoint.ApplicationClass app = null;
			PowerPoint.Presentation presentation = null;
			try
			{
				app = new PowerPoint.ApplicationClass();
				presentation = app.Presentations.Open(src, msoTrue, msoFalse, msoFalse);
				presentation.SaveAs(dst, saveAsPDF, msoTrue);
				return true;
			}
			catch
			{
				return false;
			}
			finally
			{
				if (presentation != null)
				{
					presentation.Close();
					presentation = null;
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

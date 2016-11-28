using System;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;

namespace csDemo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		private bool ConvertPpt2Pdf(string src, string dst) {
			var msoTrue = MsoTriState.msoTrue;
			var msoFalse = MsoTriState.msoFalse;
			var saveAsFileType = PowerPoint.PpSaveAsFileType.ppSaveAsPDF;
			PowerPoint.ApplicationClass app = null;
			PowerPoint.Presentation presentation = null;
			try {
				app = new PowerPoint.ApplicationClass();
				presentation = app.Presentations.Open(src, msoTrue, msoFalse, msoFalse);
				presentation.SaveAs(dst, saveAsFileType, msoTrue);
				return true;
			}
			catch{
				return false;
			} finally {
				if (presentation != null) {
					presentation.Close();
				}
				if (app != null) {
					app.Quit();
				}
			}
		}
		void Ppt2PdfButton_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			openFileDialog.Filter = "Slideshow (*.ppt;*.pptx)|*.ppt;*.pptx";
			if (openFileDialog.ShowDialog() != DialogResult.OK) {
				return;
			}
			foreach (var src in openFileDialog.FileNames) {
				string dst = System.IO.Path.ChangeExtension(src, "pdf");
				ConvertPpt2Pdf(src, dst);
			}
			MessageBox.Show("转换完成！");
		}
	}
}

using System;
using System.Windows.Forms;

namespace Office2Pdf
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
		void Multiselect(string filter, IConverter converter) {
			var openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			openFileDialog.Filter = filter;
			if (openFileDialog.ShowDialog() != DialogResult.OK) {
				return;
			}
			foreach (var src in openFileDialog.FileNames) {
				string dst = System.IO.Path.ChangeExtension(src, "pdf");
				converter.Convert2Pdf(src, dst);
			}
			MessageBox.Show("转换完成！");
		}
		void Ppt2PdfButton_Click(object sender, EventArgs e)
		{
			var converter = new PowerPointConverter();
			Multiselect("演示文稿 (*.ppt;*.pptx)|*.ppt;*.pptx", converter);
		}
		void Doc2PdfButton_Click(object sender, EventArgs e)
		{
			var converter = new WordConverter();
			Multiselect("文档 (*.doc;*.docx)|*.doc;*.docx", converter);
		}
	}
}

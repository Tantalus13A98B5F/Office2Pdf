using System;
using System.Windows.Forms;

namespace Office2Pdf
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void Multiselect(string filter, IConverter converter)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = filter;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            foreach (var src in openFileDialog.FileNames)
            {
                string dst = System.IO.Path.ChangeExtension(src, "pdf");
                converter.Convert2Pdf(src, dst);
            }
            MessageBox.Show("转换完成！");
        }

        private void doc2PdfButton_Click(object sender, EventArgs e)
        {
            var converter = new WordConverter();
            Multiselect("文档 (*.doc;*.docx)|*.doc;*.docx", converter);
        }

        private void ppt2PdfButton_Click(object sender, EventArgs e)
        {
            var converter = new PowerPointConverter();
            Multiselect("演示文稿 (*.ppt;*.pptx)|*.ppt;*.pptx", converter);
        }
    }
}

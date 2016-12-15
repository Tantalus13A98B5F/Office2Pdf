namespace Office2Pdf
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ppt2PdfButton = new System.Windows.Forms.Button();
            this.doc2PdfButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ppt2PdfButton
            // 
            this.ppt2PdfButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ppt2PdfButton.Location = new System.Drawing.Point(12, 95);
            this.ppt2PdfButton.Name = "ppt2PdfButton";
            this.ppt2PdfButton.Size = new System.Drawing.Size(358, 75);
            this.ppt2PdfButton.TabIndex = 1;
            this.ppt2PdfButton.TabStop = false;
            this.ppt2PdfButton.Text = "ppt转pdf";
            this.ppt2PdfButton.UseVisualStyleBackColor = true;
            this.ppt2PdfButton.Click += new System.EventHandler(this.ppt2PdfButton_Click);
            // 
            // doc2PdfButton
            // 
            this.doc2PdfButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.doc2PdfButton.Location = new System.Drawing.Point(12, 12);
            this.doc2PdfButton.Name = "doc2PdfButton";
            this.doc2PdfButton.Size = new System.Drawing.Size(358, 75);
            this.doc2PdfButton.TabIndex = 0;
            this.doc2PdfButton.TabStop = false;
            this.doc2PdfButton.Text = "doc转pdf";
            this.doc2PdfButton.UseVisualStyleBackColor = true;
            this.doc2PdfButton.Click += new System.EventHandler(this.doc2PdfButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 182);
            this.Controls.Add(this.doc2PdfButton);
            this.Controls.Add(this.ppt2PdfButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "格式转换工具";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ppt2PdfButton;
        private System.Windows.Forms.Button doc2PdfButton;
    }
}


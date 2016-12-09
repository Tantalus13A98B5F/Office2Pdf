/*
 * Created by SharpDevelop.
 * User: Tantalus
 * Date: 2016/11/24
 * Time: 13:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Office2Pdf
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Ppt2PdfButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Ppt2PdfButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Ppt2PdfButton
			// 
			this.Ppt2PdfButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Ppt2PdfButton.Location = new System.Drawing.Point(12, 12);
			this.Ppt2PdfButton.Name = "Ppt2PdfButton";
			this.Ppt2PdfButton.Size = new System.Drawing.Size(343, 42);
			this.Ppt2PdfButton.TabIndex = 0;
			this.Ppt2PdfButton.Text = "ppt转pdf";
			this.Ppt2PdfButton.UseVisualStyleBackColor = true;
			this.Ppt2PdfButton.Click += new System.EventHandler(this.Ppt2PdfButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 354);
			this.Controls.Add(this.Ppt2PdfButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "格式转换工具";
			this.ResumeLayout(false);

		}
	}
}

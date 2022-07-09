

namespace PDF_Resume_Creator
{
    partial class PDFResumeConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFP = new System.Windows.Forms.Button();
            this.skControl1 = new SkiaSharp.Views.Desktop.SKControl();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFP
            // 
            this.btnFP.Location = new System.Drawing.Point(109, 184);
            this.btnFP.Name = "btnFP";
            this.btnFP.Size = new System.Drawing.Size(86, 22);
            this.btnFP.TabIndex = 0;
            this.btnFP.Text = "Open File";
            this.btnFP.UseVisualStyleBackColor = true;
            this.btnFP.Click += new System.EventHandler(this.btnFP_Click);
            // 
            // skControl1
            // 
            this.skControl1.BackColor = System.Drawing.Color.White;
            this.skControl1.Location = new System.Drawing.Point(356, 12);
            this.skControl1.Name = "skControl1";
            this.skControl1.Size = new System.Drawing.Size(434, 625);
            this.skControl1.TabIndex = 1;
            this.skControl1.Text = "skControl1";
            this.skControl1.PaintSurface += new System.EventHandler<SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs>(this.skControl1_PaintSurface);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(109, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PDFResumeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(802, 660);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.skControl1);
            this.Controls.Add(this.btnFP);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PDFResumeConverter";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnFP;
        private SkiaSharp.Views.Desktop.SKControl skControl1;
        private Button btnSave;
    }
}
namespace BarCode
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Print_btn = new System.Windows.Forms.Button();
            this.PrinterLst_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Barcode_rb = new System.Windows.Forms.RadioButton();
            this.Qrcode_rb = new System.Windows.Forms.RadioButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintPreview_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(206, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 24);
            this.textBox1.TabIndex = 2;
            // 
            // Print_btn
            // 
            this.Print_btn.Location = new System.Drawing.Point(619, 155);
            this.Print_btn.Name = "Print_btn";
            this.Print_btn.Size = new System.Drawing.Size(118, 35);
            this.Print_btn.TabIndex = 5;
            this.Print_btn.Text = "Print";
            this.Print_btn.UseVisualStyleBackColor = true;
            this.Print_btn.Click += new System.EventHandler(this.Print_btn_Click);
            // 
            // PrinterLst_cmb
            // 
            this.PrinterLst_cmb.FormattingEnabled = true;
            this.PrinterLst_cmb.Location = new System.Drawing.Point(206, 74);
            this.PrinterLst_cmb.Name = "PrinterLst_cmb";
            this.PrinterLst_cmb.Size = new System.Drawing.Size(231, 21);
            this.PrinterLst_cmb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Printer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Barcodes";
            // 
            // Barcode_rb
            // 
            this.Barcode_rb.AutoSize = true;
            this.Barcode_rb.Checked = true;
            this.Barcode_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcode_rb.Location = new System.Drawing.Point(192, 168);
            this.Barcode_rb.Name = "Barcode_rb";
            this.Barcode_rb.Size = new System.Drawing.Size(82, 22);
            this.Barcode_rb.TabIndex = 9;
            this.Barcode_rb.TabStop = true;
            this.Barcode_rb.Text = "Barcode";
            this.Barcode_rb.UseVisualStyleBackColor = true;
            // 
            // Qrcode_rb
            // 
            this.Qrcode_rb.AutoSize = true;
            this.Qrcode_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qrcode_rb.Location = new System.Drawing.Point(352, 168);
            this.Qrcode_rb.Name = "Qrcode_rb";
            this.Qrcode_rb.Size = new System.Drawing.Size(89, 22);
            this.Qrcode_rb.TabIndex = 10;
            this.Qrcode_rb.TabStop = true;
            this.Qrcode_rb.Text = "QR Code";
            this.Qrcode_rb.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PrintPreview_btn
            // 
            this.PrintPreview_btn.Location = new System.Drawing.Point(619, 91);
            this.PrintPreview_btn.Name = "PrintPreview_btn";
            this.PrintPreview_btn.Size = new System.Drawing.Size(118, 35);
            this.PrintPreview_btn.TabIndex = 11;
            this.PrintPreview_btn.Text = "Print Preview";
            this.PrintPreview_btn.UseVisualStyleBackColor = true;
            this.PrintPreview_btn.Click += new System.EventHandler(this.PrintPreview_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 221);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrintPreview_btn);
            this.Controls.Add(this.Qrcode_rb);
            this.Controls.Add(this.Barcode_rb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrinterLst_cmb);
            this.Controls.Add(this.Print_btn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Print_btn;
        private System.Windows.Forms.ComboBox PrinterLst_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Barcode_rb;
        private System.Windows.Forms.RadioButton Qrcode_rb;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button PrintPreview_btn;
        private System.Windows.Forms.Label label3;
    }
}


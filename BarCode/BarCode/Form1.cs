using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace BarCode
{
    public partial class Form1 : Form
    {
        public int total=0;
        public Form1()
        {
            InitializeComponent();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                PrinterLst_cmb.Items.Add(printer);
                
            }
            if (PrinterLst_cmb.Items.Count > 0)
                PrinterLst_cmb.SelectedIndex = 0;
        }
      
        private void Print_btn_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrinterSettings.PrinterName=PrinterLst_cmb.Text;            
            doc.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4",390, 75);
            total = Convert.ToInt32(textBox1.Text);
                doc.PrintPage += new PrintPageEventHandler(PrintHandler);
            
            doc.Print();
        }
        private void PrintHandler(object sender, PrintPageEventArgs ppeArgs)
        {

            string DateStr = DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd");
            Font FontNormal = new Font(FontFamily.GenericSerif, 14.0F,FontStyle.Bold, GraphicsUnit.Pixel);
            Graphics g = ppeArgs.Graphics;
            
                BarcodeWriter writer;
                QrCodeEncodingOptions qrCodeOptions;
                qrCodeOptions = new QrCodeEncodingOptions();
                writer = new BarcodeWriter();
                writer.Renderer = new BitmapRenderer { TextFont = FontNormal };
                writer.Format = Barcode_rb.Checked == true ? BarcodeFormat.CODE_128 : BarcodeFormat.QR_CODE;
                qrCodeOptions.Height = Barcode_rb.Checked == true ? 35 : 70;
                qrCodeOptions.Width = Barcode_rb.Checked == true ? 100 : 70;
                qrCodeOptions.PureBarcode = true;
                qrCodeOptions.CharacterSet = "UTF-8";
                qrCodeOptions.Margin = 1;
                qrCodeOptions.ErrorCorrection = ErrorCorrectionLevel.H;
                writer.Options = qrCodeOptions;
                writer.Options.Height = Barcode_rb.Checked == true ? 35 : 70;
                writer.Options.Width = Barcode_rb.Checked == true ? 100 : 70;
                Bitmap bm = writer.Write("1923"+total+",S061");
                Bitmap bm1 = writer.Write("1923" + (total-1) + ",S061");
                PointF textPoint = new PointF(0, 40);
                g.DrawImage(bm, new Point(0, 0));
                g.DrawString("JEROM", FontNormal, new SolidBrush(Color.Black), textPoint);
                g.DrawImage(bm1, new Point(202, 0));
                g.DrawString("KANNAN", FontNormal, new SolidBrush(Color.Black), new PointF(202, 40));

                if (total <= 0) 
                {
                    ppeArgs.HasMorePages = false; // set the HasMorePages property to false , so that no other page will not be added
                }
                else 
                {                    
                    ppeArgs.HasMorePages = true;
                    total -= 2;
                    return;//It will call PrintPage event again

                }
            
        }

        private void PrintPreview_btn_Click(object sender, EventArgs e)
        {
            
            PrintDocument doc = new PrintDocument();
            doc.PrinterSettings.PrinterName = PrinterLst_cmb.Text;
            doc.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4", 390, 75);
            total = Convert.ToInt32(textBox1.Text);
            doc.PrintPage += new PrintPageEventHandler(PrintHandler);
            printPreviewDialog1.Document = doc;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            label3.Text = "";
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    label3.Text+=ip.ToString();
                }
               
            }
        }

        
    }
}

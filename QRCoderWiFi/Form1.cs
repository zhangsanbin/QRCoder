using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using static QRCoder.PayloadGenerator;

namespace QRCoderWiFi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WiFi generator = new WiFi(txtMyWiFisName.Text, txttxtMyWiFisPassword.Text, WiFi.Authentication.WPA);
            string payload = generator.ToString();
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            var qrCodeAsBitmap = qrCode.GetGraphic(20);
            pictureBox1.Image = qrCodeAsBitmap;


            //PhoneNumber generator = new PhoneNumber("+8613700000000");
            //string payload = generator.ToString();
            //QRCodeGenerator qrGenerator = new QRCodeGenerator();
            //QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            //QRCode qrCode = new QRCode(qrCodeData);
            //var qrCodeAsBitmap = qrCode.GetGraphic(20);
            //pictureBox1.Image = qrCodeAsBitmap;


            //SMS generator = new SMS("+8613700000000", "Hi John, do you remember SMS?");
            //string payload = generator.ToString();
            //QRCodeGenerator qrGenerator = new QRCodeGenerator();
            //QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            //QRCode qrCode = new QRCode(qrCodeData);
            //var qrCodeAsBitmap = qrCode.GetGraphic(20);
            //pictureBox1.Image = qrCodeAsBitmap;


            //Url generator = new Url("https://github.com/codebude/QRCoder/");
            //string payload = generator.ToString();
            //QRCodeGenerator qrGenerator = new QRCodeGenerator();
            //QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            //QRCode qrCode = new QRCode(qrCodeData);
            //var qrCodeAsBitmap = qrCode.GetGraphic(20);
            //pictureBox1.Image = qrCodeAsBitmap;
        }
    }
}

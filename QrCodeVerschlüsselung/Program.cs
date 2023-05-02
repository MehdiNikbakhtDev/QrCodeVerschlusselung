using QRCoder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrCodeVerschlüsselung
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var str = "https://github.com/mahdiNik";
            var path = @".\output.jpg";
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
            BitmapByteQRCode qrCode = new BitmapByteQRCode(qrCodeData);
            byte[] qrCodeAsBitmapByteArr = qrCode.GetGraphic(20);
            File.WriteAllBytes(path, qrCodeAsBitmapByteArr);
        }
    }
}

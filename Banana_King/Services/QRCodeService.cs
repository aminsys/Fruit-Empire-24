using QRCoder;

namespace Banana_King.Services
{
    public class QRCodeService
    {
        private readonly QRCodeGenerator _generator;

        // Constructor injection to gain access to an instance of the library's QRCodeGenerator class.
        public QRCodeService(QRCodeGenerator generator)
        {
            _generator = generator;
        }

        public string GetQRCodeAsBase64(string textToEncode)
        {
            QRCodeData qrCodeData = _generator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new PngByteQRCode(qrCodeData);
            return Convert.ToBase64String(qrCode.GetGraphic(4));
        }
    }
}

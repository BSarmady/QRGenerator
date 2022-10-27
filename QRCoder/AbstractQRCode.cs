﻿namespace QRCoder {
    public abstract class AbstractQRCode {
        protected QRCodeData QrCodeData { get; set; }

        protected AbstractQRCode() {
        }

        protected AbstractQRCode(QRCodeData data) {
            this.QrCodeData = data;
        }

        /// <summary>
        /// Set a QRCodeData object that will be used to generate QR code. Used in COM Objects connections
        /// </summary>
        /// <param name="data">Need a QRCodeData object generated by QRCodeGenerator.CreateQrCode()</param>
        virtual public void SetQRCodeData(QRCodeData data) {
            this.QrCodeData = data;
        }

        public void Dispose() {
            this.QrCodeData = null;
        }
    }
}
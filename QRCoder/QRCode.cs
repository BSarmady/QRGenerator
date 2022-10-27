using System.Drawing;
using System.Drawing.Drawing2D;


namespace QRCoder {
    using System;

    public class QRCode: AbstractQRCode, IDisposable {
        /// <summary>
        /// Constructor without params to be used in COM Objects connections
        /// </summary>
        public QRCode() { }

        public QRCode(QRCodeData data) : base(data) { }

        public Bitmap GetGraphic(int pixelsPerModule) {
            return this.GetGraphic(pixelsPerModule, Color.Black, Color.White, true);
        }

        public Bitmap GetGraphic(int pixelsPerModule, Color DotColor, Color BackColor, bool drawQuietZones = true) {
            var size = (this.QrCodeData.ModuleMatrix.Count - (drawQuietZones ? 0 : 8)) * pixelsPerModule;
            var offset = drawQuietZones ? 0 : 4 * pixelsPerModule;

            var bmp = new Bitmap(size, size);
            var gfx = Graphics.FromImage(bmp);
            gfx.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, size, size));
            for (var x = 0;x < size + offset;x = x + pixelsPerModule) {
                for (var y = 0;y < size + offset;y = y + pixelsPerModule) {
                    var module = this.QrCodeData.ModuleMatrix[(y + pixelsPerModule) / pixelsPerModule - 1][(x + pixelsPerModule) / pixelsPerModule - 1];
                    if (module) {
                        gfx.FillRectangle(new SolidBrush(DotColor), new Rectangle(x - offset, y - offset, pixelsPerModule, pixelsPerModule));
                    } else {
                        gfx.FillRectangle(new SolidBrush(BackColor), new Rectangle(x - offset, y - offset, pixelsPerModule, pixelsPerModule));
                    }
                }
            }

            gfx.Save();
            return bmp;
        }

        internal GraphicsPath CreateRoundedRectanglePath(RectangleF rect, int cornerRadius) {
            var roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);
            roundedRect.CloseFigure();
            return roundedRect;
        }
    }
}

using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace QRGen {
    public partial class FrmMain: Form {

        private const string AppTitle = "QR Generator";
        private const string AppRegistryKey = @"Software\JGhost\QRGenerator";
        private QRCodeGenerator generator;

        public FrmMain() {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            this.Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text = AppTitle;
            lblMessage.Text = "";

            Reg.LoadWindowPos(AppRegistryKey, this);
            edtDotColor.Text = Reg.Read(AppRegistryKey, "DotColor", "#000000");
            edtBackColor.Text = Reg.Read(AppRegistryKey, "BackColor", "#FFFFFF");
            edtDotSize.Text = Reg.Read(AppRegistryKey, "DotSize", "4");
            edtText.Text = Reg.Read(AppRegistryKey, "text", edtText.Text);
            cbEccLevel.SelectedIndex = Reg.Read(AppRegistryKey, "EccLevel", 1);
            generator = new QRCodeGenerator();

        }

        private string cleanupfilename(string s) {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in s) {
                if (" !@#$%^&()_+=-{},[]';.,~`01234567890@abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(ch) > -1) {
                    sb.Append(ch);
                } else {
                    sb.Append("_");
                }
            }
            return sb.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {

            try {
                lblMessage.Text = "";
                string text = edtText.Text.Trim();
                if (text == "") {
                    throw new Exception("Enter a text for your QR code");
                }


                int pixelsPerModule = Convert.ToInt32(edtDotSize.Text);
                if (pixelsPerModule > 32)
                    throw new Exception("Dot Size should be between 1 and 32");

                Color dotColor;
                if (edtDotColor.Text == "")
                    edtDotColor.Text = "#000000";
                try {
                    dotColor = ColorTranslator.FromHtml(edtDotColor.Text);
                } catch {

                    dotColor = ColorTranslator.FromHtml(edtDotColor.Text);
                    throw new Exception("Invalid Dot Color, it should be between #000000 and #FFFFFF");
                }
                Color backColor;
                if (edtBackColor.Text == "")
                    edtBackColor.Text = "#FFFFFF";
                try {
                    backColor = ColorTranslator.FromHtml(edtBackColor.Text);
                } catch {
                    edtBackColor.Text = "#FFFFFF";
                    backColor = ColorTranslator.FromHtml(edtBackColor.Text);
                    throw new Exception("Invalid Back Color, it should be between #000000 and #FFFFFF");
                }
                QRCodeGenerator.ECCLevel eccLevel = QRCodeGenerator.ECCLevel.M;
                switch (cbEccLevel.SelectedIndex) {
                    case 0:
                        eccLevel = QRCodeGenerator.ECCLevel.L;
                        break;
                    case 2:
                        eccLevel = QRCodeGenerator.ECCLevel.Q;
                        break;
                    case 3:
                        eccLevel = QRCodeGenerator.ECCLevel.H;
                        break;
                    default:
                        eccLevel = QRCodeGenerator.ECCLevel.M;
                        break;
                }
                QRCodeGenerator.EciMode ecimode = QRCodeGenerator.EciMode.Utf8;
                if (Encoding.ASCII.GetString(Encoding.UTF8.GetBytes(text)) == text) {
                    ecimode = QRCodeGenerator.EciMode.Iso8859_1;
                }

                using (QRCodeData data = generator.CreateQrCode(text, eccLevel, false, false, ecimode)) {

                    using (QRCode code = new QRCode(data)) {
                        using (Bitmap bitmap = code.GetGraphic(pixelsPerModule, dotColor, backColor, true)) {

                            text = cleanupfilename(text);
                            if (text.Length > 50)
                                text = text.Substring(0, 50);
                            bitmap.Save(text + ".png", ImageFormat.Png);
                        }
                    }
                }

                lblMessage.ForeColor = SystemColors.ControlText;
                lblMessage.Text = "Your QR saved as PNG file in same folder as this program";
            } catch (Exception ex) {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = ex.Message;
            }
        }

        private void btnDotColor_Click(object sender, EventArgs e) {
            using (WebColors colordialog = new WebColors()) {
                colordialog.Owner = this;
                colordialog.StartPosition = FormStartPosition.CenterParent;
                if (colordialog.ShowDialog() == DialogResult.OK)
                    edtDotColor.Text = "#" + colordialog.Color.R.ToString("X2") + colordialog.Color.G.ToString("X2") + colordialog.Color.B.ToString("X2");
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e) {
            using (WebColors colordialog = new WebColors())
                if (colordialog.ShowDialog() == DialogResult.OK)
                    edtBackColor.Text = "#" + colordialog.Color.R.ToString("X2") + colordialog.Color.G.ToString("X2") + colordialog.Color.B.ToString("X2");
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            Reg.SaveWindowPos(AppRegistryKey, this);
            Reg.Write(AppRegistryKey, "DotColor", edtDotColor.Text);
            Reg.Write(AppRegistryKey, "BackColor", edtBackColor.Text);
            Reg.Write(AppRegistryKey, "DotSize", edtDotSize.Text);
            Reg.Write(AppRegistryKey, "text", edtText.Text);
            Reg.Write(AppRegistryKey, "EccLevel", cbEccLevel.SelectedIndex);
            generator.Dispose();
        }

    }
}

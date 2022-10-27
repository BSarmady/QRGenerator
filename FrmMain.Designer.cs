namespace QRGen {
    partial class FrmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.edtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtDotSize = new System.Windows.Forms.TextBox();
            this.btnDotColor = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.edtDotColor = new System.Windows.Forms.TextBox();
            this.edtBackColor = new System.Windows.Forms.TextBox();
            this.lblDotColor = new System.Windows.Forms.Label();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.lblDotSize = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEccLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(224, 328);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(72, 26);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // edtText
            // 
            this.edtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtText.Location = new System.Drawing.Point(8, 160);
            this.edtText.Multiline = true;
            this.edtText.Name = "edtText";
            this.edtText.Size = new System.Drawing.Size(288, 160);
            this.edtText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edtDotSize
            // 
            this.edtDotSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtDotSize.Location = new System.Drawing.Point(80, 72);
            this.edtDotSize.Name = "edtDotSize";
            this.edtDotSize.Size = new System.Drawing.Size(216, 23);
            this.edtDotSize.TabIndex = 3;
            // 
            // btnDotColor
            // 
            this.btnDotColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDotColor.Location = new System.Drawing.Point(271, 7);
            this.btnDotColor.Name = "btnDotColor";
            this.btnDotColor.Size = new System.Drawing.Size(25, 25);
            this.btnDotColor.TabIndex = 4;
            this.btnDotColor.Text = "…";
            this.btnDotColor.UseVisualStyleBackColor = true;
            this.btnDotColor.Click += new System.EventHandler(this.btnDotColor_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackColor.Location = new System.Drawing.Point(271, 39);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(25, 25);
            this.btnBackColor.TabIndex = 5;
            this.btnBackColor.Text = "…";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // edtDotColor
            // 
            this.edtDotColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtDotColor.Location = new System.Drawing.Point(80, 8);
            this.edtDotColor.Name = "edtDotColor";
            this.edtDotColor.Size = new System.Drawing.Size(192, 23);
            this.edtDotColor.TabIndex = 6;
            // 
            // edtBackColor
            // 
            this.edtBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtBackColor.Location = new System.Drawing.Point(80, 40);
            this.edtBackColor.Name = "edtBackColor";
            this.edtBackColor.Size = new System.Drawing.Size(192, 23);
            this.edtBackColor.TabIndex = 7;
            // 
            // lblDotColor
            // 
            this.lblDotColor.AutoSize = true;
            this.lblDotColor.Location = new System.Drawing.Point(8, 8);
            this.lblDotColor.Name = "lblDotColor";
            this.lblDotColor.Size = new System.Drawing.Size(61, 16);
            this.lblDotColor.TabIndex = 8;
            this.lblDotColor.Text = "Dot Color";
            this.lblDotColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(8, 40);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(68, 16);
            this.lblBackColor.TabIndex = 9;
            this.lblBackColor.Text = "Back Color";
            this.lblBackColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDotSize
            // 
            this.lblDotSize.AutoSize = true;
            this.lblDotSize.Location = new System.Drawing.Point(8, 72);
            this.lblDotSize.Name = "lblDotSize";
            this.lblDotSize.Size = new System.Drawing.Size(55, 16);
            this.lblDotSize.TabIndex = 10;
            this.lblDotSize.Text = "Dot Size";
            this.lblDotSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.Location = new System.Drawing.Point(8, 328);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(208, 24);
            this.lblMessage.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ECC Level";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbEccLevel
            // 
            this.cbEccLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEccLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEccLevel.FormattingEnabled = true;
            this.cbEccLevel.Items.AddRange(new object[] {
            "Low (7% Error Correction)",
            "Medium (15% Error Correction)",
            "Quality (25% Error Correction)",
            "Highest (30% Error Correction)"});
            this.cbEccLevel.Location = new System.Drawing.Point(80, 104);
            this.cbEccLevel.Name = "cbEccLevel";
            this.cbEccLevel.Size = new System.Drawing.Size(216, 24);
            this.cbEccLevel.TabIndex = 14;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(304, 361);
            this.Controls.Add(this.cbEccLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.btnDotColor);
            this.Controls.Add(this.lblDotSize);
            this.Controls.Add(this.lblBackColor);
            this.Controls.Add(this.lblDotColor);
            this.Controls.Add(this.edtBackColor);
            this.Controls.Add(this.edtDotColor);
            this.Controls.Add(this.edtDotSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtText);
            this.Controls.Add(this.btnGenerate);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(320, 400);
            this.Name = "FrmMain";
            this.Text = "QR Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox edtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtDotSize;
        private System.Windows.Forms.Button btnDotColor;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.TextBox edtDotColor;
        private System.Windows.Forms.TextBox edtBackColor;
        private System.Windows.Forms.Label lblDotColor;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.Label lblDotSize;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEccLevel;
    }
}


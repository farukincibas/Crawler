namespace GetProductInformationFromCDiscount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTakeBarcode = new System.Windows.Forms.Button();
            this.btnDownloadImages = new System.Windows.Forms.Button();
            this.btnReadCSV = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnGetInformation = new System.Windows.Forms.Button();
            this.btnLinkleriDosyadanOku = new System.Windows.Forms.Button();
            this.btnLinkleriDosyayaKaydet = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTakeBarcode);
            this.panel1.Controls.Add(this.btnDownloadImages);
            this.panel1.Controls.Add(this.btnReadCSV);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.btnGetInformation);
            this.panel1.Controls.Add(this.btnLinkleriDosyadanOku);
            this.panel1.Controls.Add(this.btnLinkleriDosyayaKaydet);
            this.panel1.Controls.Add(this.btnScan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 68);
            this.panel1.TabIndex = 0;
            // 
            // btnTakeBarcode
            // 
            this.btnTakeBarcode.Location = new System.Drawing.Point(263, 39);
            this.btnTakeBarcode.Name = "btnTakeBarcode";
            this.btnTakeBarcode.Size = new System.Drawing.Size(143, 23);
            this.btnTakeBarcode.TabIndex = 6;
            this.btnTakeBarcode.Text = "Barkodları Al";
            this.btnTakeBarcode.UseVisualStyleBackColor = true;
            this.btnTakeBarcode.Click += new System.EventHandler(this.btnTakeBarcode_Click);
            // 
            // btnDownloadImages
            // 
            this.btnDownloadImages.Location = new System.Drawing.Point(412, 39);
            this.btnDownloadImages.Name = "btnDownloadImages";
            this.btnDownloadImages.Size = new System.Drawing.Size(168, 23);
            this.btnDownloadImages.TabIndex = 7;
            this.btnDownloadImages.Text = "Resimleri İndir";
            this.btnDownloadImages.UseVisualStyleBackColor = true;
            this.btnDownloadImages.Click += new System.EventHandler(this.btnDownloadImages_Click);
            // 
            // btnReadCSV
            // 
            this.btnReadCSV.Location = new System.Drawing.Point(129, 39);
            this.btnReadCSV.Name = "btnReadCSV";
            this.btnReadCSV.Size = new System.Drawing.Size(128, 23);
            this.btnReadCSV.TabIndex = 5;
            this.btnReadCSV.Text = "CSV Oku";
            this.btnReadCSV.UseVisualStyleBackColor = true;
            this.btnReadCSV.Click += new System.EventHandler(this.btnReadCSV_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(12, 39);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(111, 23);
            this.btnExportExcel.TabIndex = 4;
            this.btnExportExcel.Text = "CSV Aktar";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnGetInformation
            // 
            this.btnGetInformation.Location = new System.Drawing.Point(412, 12);
            this.btnGetInformation.Name = "btnGetInformation";
            this.btnGetInformation.Size = new System.Drawing.Size(168, 23);
            this.btnGetInformation.TabIndex = 3;
            this.btnGetInformation.Text = "Linkleri Aç ve Bilgileri Topla";
            this.btnGetInformation.UseVisualStyleBackColor = true;
            this.btnGetInformation.Click += new System.EventHandler(this.btnGetInformation_Click);
            // 
            // btnLinkleriDosyadanOku
            // 
            this.btnLinkleriDosyadanOku.Location = new System.Drawing.Point(263, 12);
            this.btnLinkleriDosyadanOku.Name = "btnLinkleriDosyadanOku";
            this.btnLinkleriDosyadanOku.Size = new System.Drawing.Size(143, 23);
            this.btnLinkleriDosyadanOku.TabIndex = 2;
            this.btnLinkleriDosyadanOku.Text = "Linkleri Dosyadan Oku";
            this.btnLinkleriDosyadanOku.UseVisualStyleBackColor = true;
            this.btnLinkleriDosyadanOku.Click += new System.EventHandler(this.btnLinkleriDosyadanOku_Click);
            // 
            // btnLinkleriDosyayaKaydet
            // 
            this.btnLinkleriDosyayaKaydet.Location = new System.Drawing.Point(129, 12);
            this.btnLinkleriDosyayaKaydet.Name = "btnLinkleriDosyayaKaydet";
            this.btnLinkleriDosyayaKaydet.Size = new System.Drawing.Size(128, 23);
            this.btnLinkleriDosyayaKaydet.TabIndex = 1;
            this.btnLinkleriDosyayaKaydet.Text = "Linkleri Dosyaya Kaydet";
            this.btnLinkleriDosyayaKaydet.UseVisualStyleBackColor = true;
            this.btnLinkleriDosyayaKaydet.Click += new System.EventHandler(this.btnLinkleriDosyayaKaydet_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(12, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(111, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Tara";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 68);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(800, 382);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("https://www.brico.be/nl/search?currentPage=1&viewSize=24&text=thys", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnLinkleriDosyayaKaydet;
        private System.Windows.Forms.Button btnLinkleriDosyadanOku;
        private System.Windows.Forms.Button btnGetInformation;
        private System.Windows.Forms.Button btnReadCSV;
        private System.Windows.Forms.Button btnDownloadImages;
        private System.Windows.Forms.Button btnTakeBarcode;
    }
}


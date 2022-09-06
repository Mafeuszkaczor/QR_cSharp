namespace qr
{
    partial class QRGen
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRGen));
            this.title = new System.Windows.Forms.Label();
            this.QR = new System.Windows.Forms.PictureBox();
            this.TBscan = new System.Windows.Forms.TextBox();
            this.TBtitle = new System.Windows.Forms.TextBox();
            this.Print = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fixedText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QR)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(30, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 25);
            this.title.TabIndex = 0;
            this.title.Tag = "";
            this.title.Text = "QR Code";
            // 
            // QR
            // 
            this.QR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QR.Location = new System.Drawing.Point(30, 50);
            this.QR.Name = "QR";
            this.QR.Size = new System.Drawing.Size(350, 350);
            this.QR.TabIndex = 1;
            this.QR.TabStop = false;
            // 
            // TBscan
            // 
            this.TBscan.Location = new System.Drawing.Point(390, 85);
            this.TBscan.Multiline = true;
            this.TBscan.Name = "TBscan";
            this.TBscan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TBscan.ShortcutsEnabled = false;
            this.TBscan.Size = new System.Drawing.Size(170, 140);
            this.TBscan.TabIndex = 1;
            this.TBscan.WordWrap = false;
            this.TBscan.TextChanged += new System.EventHandler(this.TBscan_TextChanged);
            // 
            // TBtitle
            // 
            this.TBtitle.Location = new System.Drawing.Point(390, 270);
            this.TBtitle.Multiline = true;
            this.TBtitle.Name = "TBtitle";
            this.TBtitle.Size = new System.Drawing.Size(350, 130);
            this.TBtitle.TabIndex = 2;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(390, 410);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(350, 30);
            this.Print.TabIndex = 14;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            // 
            // pic
            // 
            this.pic.AutoSize = true;
            this.pic.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pic.Location = new System.Drawing.Point(504, 450);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(236, 13);
            this.pic.TabIndex = 15;
            this.pic.Text = "PiC: Mateusz Kaczor mafeuszkaczor@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(386, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 16;
            this.label1.Tag = "";
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(386, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 17;
            this.label2.Tag = "";
            this.label2.Text = "Scan:";
            // 
            // fixedText
            // 
            this.fixedText.Location = new System.Drawing.Point(570, 85);
            this.fixedText.Multiline = true;
            this.fixedText.Name = "fixedText";
            this.fixedText.ReadOnly = true;
            this.fixedText.Size = new System.Drawing.Size(170, 140);
            this.fixedText.TabIndex = 18;
            // 
            // QRGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(774, 476);
            this.Controls.Add(this.fixedText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.TBtitle);
            this.Controls.Add(this.TBscan);
            this.Controls.Add(this.QR);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QRGen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEB QR Code generator";
            ((System.ComponentModel.ISupportInitialize)(this.QR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox QR;
        private System.Windows.Forms.TextBox TBscan;
        private System.Windows.Forms.TextBox TBtitle;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Label pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fixedText;
    }
}


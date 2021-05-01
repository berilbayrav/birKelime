namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKelimeGetir = new System.Windows.Forms.Button();
            this.btnHarfGetir = new System.Windows.Forms.Button();
            this.btnKaristir = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHarfler = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtJoker = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oyunHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtKelime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblPuan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnKelimeGetir);
            this.groupBox1.Location = new System.Drawing.Point(612, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(356, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bir Kelime";
            // 
            // txtKelime
            // 
            this.txtKelime.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKelime.Location = new System.Drawing.Point(182, 64);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(150, 34);
            this.txtKelime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "En Uzun Kelime:";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(92, 144);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(32, 27);
            this.lblPuan.TabIndex = 2;
            this.lblPuan.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puan:";
            // 
            // btnKelimeGetir
            // 
            this.btnKelimeGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(202)))), ((int)(((byte)(199)))));
            this.btnKelimeGetir.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKelimeGetir.Location = new System.Drawing.Point(70, 198);
            this.btnKelimeGetir.Name = "btnKelimeGetir";
            this.btnKelimeGetir.Size = new System.Drawing.Size(210, 71);
            this.btnKelimeGetir.TabIndex = 0;
            this.btnKelimeGetir.Text = "KELİME GETİR";
            this.btnKelimeGetir.UseVisualStyleBackColor = false;
            this.btnKelimeGetir.Click += new System.EventHandler(this.btnKelimeGetir_Click);
            // 
            // btnHarfGetir
            // 
            this.btnHarfGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(202)))), ((int)(((byte)(199)))));
            this.btnHarfGetir.Location = new System.Drawing.Point(8, 87);
            this.btnHarfGetir.Name = "btnHarfGetir";
            this.btnHarfGetir.Size = new System.Drawing.Size(139, 44);
            this.btnHarfGetir.TabIndex = 1;
            this.btnHarfGetir.Text = "HARF GETİR";
            this.btnHarfGetir.UseVisualStyleBackColor = false;
            this.btnHarfGetir.Click += new System.EventHandler(this.btnHarfGetir_Click);
            // 
            // btnKaristir
            // 
            this.btnKaristir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(202)))), ((int)(((byte)(199)))));
            this.btnKaristir.Location = new System.Drawing.Point(153, 87);
            this.btnKaristir.Name = "btnKaristir";
            this.btnKaristir.Size = new System.Drawing.Size(139, 44);
            this.btnKaristir.TabIndex = 2;
            this.btnKaristir.Text = "KARIŞTIR";
            this.btnKaristir.UseVisualStyleBackColor = false;
            this.btnKaristir.Click += new System.EventHandler(this.btnKaristir_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(202)))), ((int)(((byte)(199)))));
            this.btnListele.Location = new System.Drawing.Point(303, 87);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(139, 44);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(287, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 63);
            this.label2.TabIndex = 4;
            this.label2.Text = "KELİME OYUNU";
            // 
            // txtHarfler
            // 
            this.txtHarfler.Location = new System.Drawing.Point(215, 230);
            this.txtHarfler.Name = "txtHarfler";
            this.txtHarfler.Size = new System.Drawing.Size(151, 29);
            this.txtHarfler.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(56, 350);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 124);
            this.listBox1.TabIndex = 6;
            this.listBox1.Visible = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(202)))), ((int)(((byte)(199)))));
            this.btnTemizle.Location = new System.Drawing.Point(448, 87);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(139, 44);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(358, 350);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(211, 124);
            this.listBox2.TabIndex = 8;
            // 
            // txtJoker
            // 
            this.txtJoker.Location = new System.Drawing.Point(490, 228);
            this.txtJoker.Name = "txtJoker";
            this.txtJoker.Size = new System.Drawing.Size(49, 29);
            this.txtJoker.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(380, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Joker Harf:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(29, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Joker harfi kullanmak ister misiniz?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(349, 290);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 28);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evet";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(422, 290);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 28);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hayır";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(202)))), ((int)(((byte)(199)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(941, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 49);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyunHakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 31);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oyunHakkındaToolStripMenuItem
            // 
            this.oyunHakkındaToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunHakkındaToolStripMenuItem.Name = "oyunHakkındaToolStripMenuItem";
            this.oyunHakkındaToolStripMenuItem.Size = new System.Drawing.Size(140, 27);
            this.oyunHakkındaToolStripMenuItem.Text = "Oyun Hakkında";
            this.oyunHakkındaToolStripMenuItem.Click += new System.EventHandler(this.oyunHakkındaToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(32, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kullanılacak Harfler";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(202)))), ((int)(((byte)(199)))));
            this.button2.Location = new System.Drawing.Point(191, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 42);
            this.button2.TabIndex = 17;
            this.button2.Text = "KULLANICI GİRİŞİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 486);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJoker);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtHarfler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnKaristir);
            this.Controls.Add(this.btnHarfGetir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Sitka Text", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKelimeGetir;
        private System.Windows.Forms.Button btnHarfGetir;
        private System.Windows.Forms.Button btnKaristir;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHarfler;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtJoker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oyunHakkındaToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}


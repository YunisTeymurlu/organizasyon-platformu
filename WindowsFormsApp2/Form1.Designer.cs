namespace WindowsFormsApp2
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDepartmanEkle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPozisyon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCalisanlar = new System.Windows.Forms.ListBox();
            this.labelPozisyon = new System.Windows.Forms.Label();
            this.listBoxIslemGecmisi = new System.Windows.Forms.ListBox();
            this.btnGecmisiGoster = new System.Windows.Forms.Button();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treeView1.Location = new System.Drawing.Point(70, 41);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(557, 537);
            this.treeView1.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtAdSoyad.Location = new System.Drawing.Point(28, 45);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(217, 31);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.BackColor = System.Drawing.Color.Salmon;
            this.btnCalisanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanEkle.Location = new System.Drawing.Point(28, 170);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(217, 50);
            this.btnCalisanEkle.TabIndex = 4;
            this.btnCalisanEkle.Text = "Çalışan Ekle\n";
            this.btnCalisanEkle.UseVisualStyleBackColor = false;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Tomato;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(28, 282);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(217, 50);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(28, 396);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(217, 50);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(28, 464);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(217, 50);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDepartmanEkle
            // 
            this.btnDepartmanEkle.BackColor = System.Drawing.Color.Coral;
            this.btnDepartmanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanEkle.Location = new System.Drawing.Point(28, 226);
            this.btnDepartmanEkle.Name = "btnDepartmanEkle";
            this.btnDepartmanEkle.Size = new System.Drawing.Size(217, 50);
            this.btnDepartmanEkle.TabIndex = 9;
            this.btnDepartmanEkle.Text = "Departman Ekle";
            this.btnDepartmanEkle.UseVisualStyleBackColor = false;
            this.btnDepartmanEkle.Click += new System.EventHandler(this.btnDepartmanEkle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtAra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnDepartmanEkle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPozisyon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCalisanEkle);
            this.panel1.Controls.Add(this.txtAdSoyad);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Location = new System.Drawing.Point(685, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 537);
            this.panel1.TabIndex = 10;
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(28, 361);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(217, 29);
            this.txtAra.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(27, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Aranacak Çalışan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pozisyon";
            // 
            // txtPozisyon
            // 
            this.txtPozisyon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPozisyon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPozisyon.Location = new System.Drawing.Point(28, 114);
            this.txtPozisyon.Name = "txtPozisyon";
            this.txtPozisyon.Size = new System.Drawing.Size(217, 31);
            this.txtPozisyon.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ad Soyad";
            // 
            // listBoxCalisanlar
            // 
            this.listBoxCalisanlar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxCalisanlar.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxCalisanlar.FormattingEnabled = true;
            this.listBoxCalisanlar.ItemHeight = 25;
            this.listBoxCalisanlar.Location = new System.Drawing.Point(1018, 36);
            this.listBoxCalisanlar.Name = "listBoxCalisanlar";
            this.listBoxCalisanlar.Size = new System.Drawing.Size(195, 179);
            this.listBoxCalisanlar.TabIndex = 11;
            this.listBoxCalisanlar.SelectedIndexChanged += new System.EventHandler(this.listBoxCalisanlar_SelectedIndexChanged);
            // 
            // labelPozisyon
            // 
            this.labelPozisyon.AutoSize = true;
            this.labelPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPozisyon.ForeColor = System.Drawing.Color.Silver;
            this.labelPozisyon.Location = new System.Drawing.Point(1014, 225);
            this.labelPozisyon.Name = "labelPozisyon";
            this.labelPozisyon.Size = new System.Drawing.Size(0, 24);
            this.labelPozisyon.TabIndex = 12;
            // 
            // listBoxIslemGecmisi
            // 
            this.listBoxIslemGecmisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxIslemGecmisi.FormattingEnabled = true;
            this.listBoxIslemGecmisi.ItemHeight = 16;
            this.listBoxIslemGecmisi.Location = new System.Drawing.Point(1018, 260);
            this.listBoxIslemGecmisi.Name = "listBoxIslemGecmisi";
            this.listBoxIslemGecmisi.Size = new System.Drawing.Size(195, 164);
            this.listBoxIslemGecmisi.TabIndex = 13;
            // 
            // btnGecmisiGoster
            // 
            this.btnGecmisiGoster.BackColor = System.Drawing.Color.White;
            this.btnGecmisiGoster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGecmisiGoster.Location = new System.Drawing.Point(1018, 439);
            this.btnGecmisiGoster.Name = "btnGecmisiGoster";
            this.btnGecmisiGoster.Size = new System.Drawing.Size(195, 25);
            this.btnGecmisiGoster.TabIndex = 14;
            this.btnGecmisiGoster.Text = "İşlem Geçmişini Göster";
            this.btnGecmisiGoster.UseVisualStyleBackColor = false;
            this.btnGecmisiGoster.Click += new System.EventHandler(this.btnGecmisiGoster_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Location = new System.Drawing.Point(1018, 481);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(195, 27);
            this.btnGeriAl.TabIndex = 15;
            this.btnGeriAl.Text = "Geri Al";
            this.btnGeriAl.UseVisualStyleBackColor = true;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSonuc.ForeColor = System.Drawing.Color.White;
            this.labelSonuc.Location = new System.Drawing.Point(968, 519);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(0, 25);
            this.labelSonuc.TabIndex = 16;
            this.labelSonuc.Click += new System.EventHandler(this.labelSonuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1332, 609);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.btnGecmisiGoster);
            this.Controls.Add(this.listBoxIslemGecmisi);
            this.Controls.Add(this.labelPozisyon);
            this.Controls.Add(this.listBoxCalisanlar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDepartmanEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPozisyon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox listBoxCalisanlar;
        private System.Windows.Forms.Label labelPozisyon;
        private System.Windows.Forms.ListBox listBoxIslemGecmisi;
        private System.Windows.Forms.Button btnGecmisiGoster;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.Label labelSonuc;
    }
}


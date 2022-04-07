namespace POSApplication.ForntEnd
{
    partial class FormCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBil1 = new System.Windows.Forms.TextBox();
            this.txtBil2 = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHasilLuasSegitiga = new System.Windows.Forms.TextBox();
            this.txtTinggi = new System.Windows.Forms.TextBox();
            this.txtAlas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHitungLuasSegitigas = new System.Windows.Forms.Button();
            this.btnHitung = new System.Windows.Forms.Button();
            this.rdTambah = new System.Windows.Forms.RadioButton();
            this.rdKurang = new System.Windows.Forms.RadioButton();
            this.rdKali = new System.Windows.Forms.RadioButton();
            this.rdBagi = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilangan 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilangan 2 :";
            // 
            // txtBil1
            // 
            this.txtBil1.Location = new System.Drawing.Point(89, 9);
            this.txtBil1.Name = "txtBil1";
            this.txtBil1.Size = new System.Drawing.Size(117, 23);
            this.txtBil1.TabIndex = 2;
            // 
            // txtBil2
            // 
            this.txtBil2.Location = new System.Drawing.Point(89, 41);
            this.txtBil2.Name = "txtBil2";
            this.txtBil2.Size = new System.Drawing.Size(117, 23);
            this.txtBil2.TabIndex = 3;
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(89, 77);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(117, 23);
            this.txtHasil.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasil :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hasil :";
            // 
            // txtHasilLuasSegitiga
            // 
            this.txtHasilLuasSegitiga.Location = new System.Drawing.Point(537, 77);
            this.txtHasilLuasSegitiga.Name = "txtHasilLuasSegitiga";
            this.txtHasilLuasSegitiga.ReadOnly = true;
            this.txtHasilLuasSegitiga.Size = new System.Drawing.Size(125, 23);
            this.txtHasilLuasSegitiga.TabIndex = 10;
            // 
            // txtTinggi
            // 
            this.txtTinggi.Location = new System.Drawing.Point(537, 43);
            this.txtTinggi.Name = "txtTinggi";
            this.txtTinggi.Size = new System.Drawing.Size(125, 23);
            this.txtTinggi.TabIndex = 9;
            // 
            // txtAlas
            // 
            this.txtAlas.Location = new System.Drawing.Point(537, 9);
            this.txtAlas.Name = "txtAlas";
            this.txtAlas.Size = new System.Drawing.Size(125, 23);
            this.txtAlas.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tinggi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Alas :";
            // 
            // btnHitungLuasSegitigas
            // 
            this.btnHitungLuasSegitigas.Location = new System.Drawing.Point(537, 118);
            this.btnHitungLuasSegitigas.Name = "btnHitungLuasSegitigas";
            this.btnHitungLuasSegitigas.Size = new System.Drawing.Size(75, 23);
            this.btnHitungLuasSegitigas.TabIndex = 16;
            this.btnHitungLuasSegitigas.Text = "Hitung";
            this.btnHitungLuasSegitigas.UseVisualStyleBackColor = true;
            this.btnHitungLuasSegitigas.Click += new System.EventHandler(this.btnHitungLuasSegitigas_Click);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(89, 162);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 17;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // rdTambah
            // 
            this.rdTambah.AutoSize = true;
            this.rdTambah.Location = new System.Drawing.Point(12, 122);
            this.rdTambah.Name = "rdTambah";
            this.rdTambah.Size = new System.Drawing.Size(67, 19);
            this.rdTambah.TabIndex = 18;
            this.rdTambah.TabStop = true;
            this.rdTambah.Text = "Tambah";
            this.rdTambah.UseVisualStyleBackColor = true;
            // 
            // rdKurang
            // 
            this.rdKurang.AutoSize = true;
            this.rdKurang.Location = new System.Drawing.Point(85, 122);
            this.rdKurang.Name = "rdKurang";
            this.rdKurang.Size = new System.Drawing.Size(63, 19);
            this.rdKurang.TabIndex = 19;
            this.rdKurang.TabStop = true;
            this.rdKurang.Text = "Kurang";
            this.rdKurang.UseVisualStyleBackColor = true;
            // 
            // rdKali
            // 
            this.rdKali.AutoSize = true;
            this.rdKali.Location = new System.Drawing.Point(162, 122);
            this.rdKali.Name = "rdKali";
            this.rdKali.Size = new System.Drawing.Size(44, 19);
            this.rdKali.TabIndex = 20;
            this.rdKali.TabStop = true;
            this.rdKali.Text = "Kali";
            this.rdKali.UseVisualStyleBackColor = true;
            // 
            // rdBagi
            // 
            this.rdBagi.AutoSize = true;
            this.rdBagi.Location = new System.Drawing.Point(222, 122);
            this.rdBagi.Name = "rdBagi";
            this.rdBagi.Size = new System.Drawing.Size(48, 19);
            this.rdBagi.TabIndex = 21;
            this.rdBagi.TabStop = true;
            this.rdBagi.Text = "Bagi";
            this.rdBagi.UseVisualStyleBackColor = true;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdBagi);
            this.Controls.Add(this.rdKali);
            this.Controls.Add(this.rdKurang);
            this.Controls.Add(this.rdTambah);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.btnHitungLuasSegitigas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHasilLuasSegitiga);
            this.Controls.Add(this.txtTinggi);
            this.Controls.Add(this.txtAlas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.txtBil2);
            this.Controls.Add(this.txtBil1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCalculator";
            this.Text = "My Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBil1;
        private TextBox txtBil2;
        private TextBox txtHasil;
        private Label label3;
        private Label label4;
        private TextBox txtHasilLuasSegitiga;
        private TextBox txtTinggi;
        private TextBox txtAlas;
        private Label label5;
        private Label label6;
        private Button btnHitungLuasSegitigas;
        private Button btnHitung;
        private RadioButton rdTambah;
        private RadioButton rdKurang;
        private RadioButton rdKali;
        private RadioButton rdBagi;
    }
}
namespace POSApplication.FrontEnd
{
    partial class FormPembelian
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
            this.txtKodeSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlamatSupplier = new System.Windows.Forms.TextBox();
            this.txtTelpSupplier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoNotaBeli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTanggalNotaBeli = new System.Windows.Forms.DateTimePicker();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtHargaBeli = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalHarga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nonotabeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itembeliid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKodeSupplier
            // 
            this.txtKodeSupplier.Location = new System.Drawing.Point(117, 60);
            this.txtKodeSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeSupplier.Name = "txtKodeSupplier";
            this.txtKodeSupplier.ReadOnly = true;
            this.txtKodeSupplier.Size = new System.Drawing.Size(119, 23);
            this.txtKodeSupplier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Supplier :";
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(240, 59);
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(61, 22);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "Cari";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama :";
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.Location = new System.Drawing.Point(117, 92);
            this.txtNamaSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.ReadOnly = true;
            this.txtNamaSupplier.Size = new System.Drawing.Size(185, 23);
            this.txtNamaSupplier.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alamat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telpon :";
            // 
            // txtAlamatSupplier
            // 
            this.txtAlamatSupplier.Location = new System.Drawing.Point(406, 60);
            this.txtAlamatSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlamatSupplier.Name = "txtAlamatSupplier";
            this.txtAlamatSupplier.ReadOnly = true;
            this.txtAlamatSupplier.Size = new System.Drawing.Size(185, 23);
            this.txtAlamatSupplier.TabIndex = 7;
            // 
            // txtTelpSupplier
            // 
            this.txtTelpSupplier.Location = new System.Drawing.Point(405, 92);
            this.txtTelpSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelpSupplier.Name = "txtTelpSupplier";
            this.txtTelpSupplier.ReadOnly = true;
            this.txtTelpSupplier.Size = new System.Drawing.Size(185, 23);
            this.txtTelpSupplier.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "No Nota :";
            // 
            // txtNoNotaBeli
            // 
            this.txtNoNotaBeli.Location = new System.Drawing.Point(80, 4);
            this.txtNoNotaBeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoNotaBeli.Name = "txtNoNotaBeli";
            this.txtNoNotaBeli.ReadOnly = true;
            this.txtNoNotaBeli.Size = new System.Drawing.Size(107, 23);
            this.txtNoNotaBeli.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tanggal :";
            // 
            // dtTanggalNotaBeli
            // 
            this.dtTanggalNotaBeli.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTanggalNotaBeli.Location = new System.Drawing.Point(530, 7);
            this.dtTanggalNotaBeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTanggalNotaBeli.Name = "dtTanggalNotaBeli";
            this.dtTanggalNotaBeli.Size = new System.Drawing.Size(127, 23);
            this.dtTanggalNotaBeli.TabIndex = 12;
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nonotabeli,
            this.itembeliid,
            this.kodeBarang,
            this.Nama,
            this.qty,
            this.hargaBeli,
            this.subtotal});
            this.dgvBarang.Location = new System.Drawing.Point(-2, 193);
            this.dgvBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowHeadersWidth = 51;
            this.dgvBarang.RowTemplate.Height = 29;
            this.dgvBarang.Size = new System.Drawing.Size(753, 178);
            this.dgvBarang.TabIndex = 13;
            this.dgvBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBarang_KeyDown);
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(17, 153);
            this.txtKode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKode.Name = "txtKode";
            this.txtKode.ReadOnly = true;
            this.txtKode.Size = new System.Drawing.Size(78, 23);
            this.txtKode.TabIndex = 14;
            this.txtKode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKode_KeyDown);
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(100, 153);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.ReadOnly = true;
            this.txtNamaBarang.Size = new System.Drawing.Size(223, 23);
            this.txtNamaBarang.TabIndex = 15;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(327, 153);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(87, 23);
            this.txtQty.TabIndex = 16;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // txtHargaBeli
            // 
            this.txtHargaBeli.Location = new System.Drawing.Point(417, 153);
            this.txtHargaBeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHargaBeli.Name = "txtHargaBeli";
            this.txtHargaBeli.ReadOnly = true;
            this.txtHargaBeli.Size = new System.Drawing.Size(117, 23);
            this.txtHargaBeli.TabIndex = 17;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(540, 153);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(117, 23);
            this.txtSubtotal.TabIndex = 18;
            this.txtSubtotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSubtotal_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kode :";
            // 
            // txtTotalHarga
            // 
            this.txtTotalHarga.Location = new System.Drawing.Point(599, 390);
            this.txtTotalHarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.Size = new System.Drawing.Size(117, 23);
            this.txtTotalHarga.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total Harga :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nama :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(327, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Qty :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Harga :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(540, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Subtotal";
            // 
            // nonotabeli
            // 
            this.nonotabeli.DataPropertyName = "NoNotaBeli";
            this.nonotabeli.HeaderText = "NoNotaBeli";
            this.nonotabeli.MinimumWidth = 6;
            this.nonotabeli.Name = "nonotabeli";
            this.nonotabeli.Visible = false;
            this.nonotabeli.Width = 125;
            // 
            // itembeliid
            // 
            this.itembeliid.DataPropertyName = "ItemBeliId";
            this.itembeliid.HeaderText = "ItemBeliId";
            this.itembeliid.MinimumWidth = 6;
            this.itembeliid.Name = "itembeliid";
            this.itembeliid.Visible = false;
            this.itembeliid.Width = 125;
            // 
            // kodeBarang
            // 
            this.kodeBarang.DataPropertyName = "KodeBarang";
            this.kodeBarang.HeaderText = "Kode";
            this.kodeBarang.MinimumWidth = 6;
            this.kodeBarang.Name = "kodeBarang";
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "NamaBarang";
            this.Nama.HeaderText = "Nama Barang";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.Width = 250;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "Jumlah";
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            // 
            // hargaBeli
            // 
            this.hargaBeli.DataPropertyName = "HargaBeli";
            this.hargaBeli.HeaderText = "Harga Beli";
            this.hargaBeli.MinimumWidth = 6;
            this.hargaBeli.Name = "hargaBeli";
            this.hargaBeli.Width = 125;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "Subtotal";
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.Width = 125;
            // 
            // FormPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 433);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalHarga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtHargaBeli);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.dtTanggalNotaBeli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoNotaBeli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelpSupplier);
            this.Controls.Add(this.txtAlamatSupplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamaSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKodeSupplier);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPembelian";
            this.Text = "FormPembelian";
            this.Load += new System.EventHandler(this.FormPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtKodeSupplier;
        private Label label1;
        private Button btnSupplier;
        private Label label2;
        private TextBox txtNamaSupplier;
        private Label label3;
        private Label label4;
        private TextBox txtAlamatSupplier;
        private TextBox txtTelpSupplier;
        private Label label5;
        private TextBox txtNoNotaBeli;
        private Label label6;
        private DateTimePicker dtTanggalNotaBeli;
        private DataGridView dgvBarang;
        private TextBox txtKode;
        private TextBox txtNamaBarang;
        private TextBox txtQty;
        private TextBox txtHargaBeli;
        private TextBox txtSubtotal;
        private Label label7;
        private TextBox txtTotalHarga;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridViewTextBoxColumn nonotabeli;
        private DataGridViewTextBoxColumn itembeliid;
        private DataGridViewTextBoxColumn kodeBarang;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn hargaBeli;
        private DataGridViewTextBoxColumn subtotal;
    }
}
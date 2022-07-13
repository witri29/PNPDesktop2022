namespace POSApplication.FrontEnd
{
    partial class FormSupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Masukan Nama Supplier :";
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.Location = new System.Drawing.Point(160, 18);
            this.txtNamaSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.Size = new System.Drawing.Size(241, 23);
            this.txtNamaSupplier.TabIndex = 10;
            this.txtNamaSupplier.TextChanged += new System.EventHandler(this.txtNamaSupplier_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(432, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSupplier.Location = new System.Drawing.Point(0, 67);
            this.dgvSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersWidth = 51;
            this.dgvSupplier.RowTemplate.Height = 29;
            this.dgvSupplier.Size = new System.Drawing.Size(576, 226);
            this.dgvSupplier.TabIndex = 12;
            this.dgvSupplier.DoubleClick += new System.EventHandler(this.dgvSupplier_DoubleClick);
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 293);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtNamaSupplier);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSupplier";
            this.Text = "FormSupplier";
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNamaSupplier;
        private Button btnSearch;
        private DataGridView dgvSupplier;
    }
}
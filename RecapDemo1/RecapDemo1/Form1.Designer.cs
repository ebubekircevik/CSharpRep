namespace RecapDemo1
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
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblKategori);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(776, 75);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Gore Listele";
            this.gbxCategory.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(113, 28);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(169, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(34, 28);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(65, 17);
            this.lblKategori.TabIndex = 0;
            this.lblKategori.Text = "Kategori:";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(12, 93);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(776, 75);
            this.gbxSearch.TabIndex = 1;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürün İsmine Göre Ara";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(113, 37);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(169, 22);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(34, 37);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(34, 17);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Ara:";
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 183);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(1258, 531);
            this.dgwProduct.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 815);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCategory);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgwProduct;
    }
}


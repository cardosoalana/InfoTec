namespace InfoTec
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.sellProduct = new System.Windows.Forms.Button();
            this.registerProduct = new System.Windows.Forms.Button();
            this.MensalRegister = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Config = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDialog = new System.Windows.Forms.ColorDialog();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos disponíveis:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sellProduct
            // 
            this.sellProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(217)))), ((int)(((byte)(40)))));
            this.sellProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sellProduct.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.sellProduct.ForeColor = System.Drawing.Color.Black;
            this.sellProduct.Location = new System.Drawing.Point(12, 13);
            this.sellProduct.Name = "sellProduct";
            this.sellProduct.Size = new System.Drawing.Size(145, 56);
            this.sellProduct.TabIndex = 1;
            this.sellProduct.Text = "Vender Produto";
            this.sellProduct.UseVisualStyleBackColor = false;
            this.sellProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerProduct
            // 
            this.registerProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(217)))), ((int)(((byte)(40)))));
            this.registerProduct.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.registerProduct.Location = new System.Drawing.Point(277, 12);
            this.registerProduct.Name = "registerProduct";
            this.registerProduct.Size = new System.Drawing.Size(145, 56);
            this.registerProduct.TabIndex = 2;
            this.registerProduct.Text = "Cadastrar Produto";
            this.registerProduct.UseVisualStyleBackColor = false;
            this.registerProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // MensalRegister
            // 
            this.MensalRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(217)))), ((int)(((byte)(40)))));
            this.MensalRegister.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.MensalRegister.Location = new System.Drawing.Point(526, 22);
            this.MensalRegister.Name = "MensalRegister";
            this.MensalRegister.Size = new System.Drawing.Size(145, 56);
            this.MensalRegister.TabIndex = 3;
            this.MensalRegister.Text = "Retatório Mensal";
            this.MensalRegister.UseVisualStyleBackColor = false;
            this.MensalRegister.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Product,
            this.Valor,
            this.Config,
            this.Quantity});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(16, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 303);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Product
            // 
            this.Product.HeaderText = "Produtos";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.Width = 125;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.Width = 125;
            // 
            // Config
            // 
            this.Config.HeaderText = "Configurações";
            this.Config.MinimumWidth = 6;
            this.Config.Name = "Config";
            this.Config.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantidade";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MensalRegister);
            this.Controls.Add(this.registerProduct);
            this.Controls.Add(this.sellProduct);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "InfoTec";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sellProduct;
        private System.Windows.Forms.Button registerProduct;
        private System.Windows.Forms.Button MensalRegister;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColorDialog reportDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Config;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}


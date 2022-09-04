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
            this.reportDialog = new System.Windows.Forms.ColorDialog();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.NovoProduto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos disponíveis:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sellProduct
            // 
            this.sellProduct.BackColor = System.Drawing.Color.DarkOrange;
            this.sellProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sellProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.sellProduct.ForeColor = System.Drawing.Color.White;
            this.sellProduct.Location = new System.Drawing.Point(133, 77);
            this.sellProduct.Name = "sellProduct";
            this.sellProduct.Size = new System.Drawing.Size(180, 45);
            this.sellProduct.TabIndex = 1;
            this.sellProduct.Text = "Vender Produto";
            this.sellProduct.UseVisualStyleBackColor = false;
            this.sellProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerProduct
            // 
            this.registerProduct.BackColor = System.Drawing.Color.DarkOrange;
            this.registerProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.registerProduct.ForeColor = System.Drawing.Color.White;
            this.registerProduct.Location = new System.Drawing.Point(133, 128);
            this.registerProduct.Name = "registerProduct";
            this.registerProduct.Size = new System.Drawing.Size(180, 45);
            this.registerProduct.TabIndex = 2;
            this.registerProduct.Text = "Cadastrar Produto";
            this.registerProduct.UseVisualStyleBackColor = false;
            this.registerProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // MensalRegister
            // 
            this.MensalRegister.BackColor = System.Drawing.Color.DarkOrange;
            this.MensalRegister.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.MensalRegister.ForeColor = System.Drawing.Color.White;
            this.MensalRegister.Location = new System.Drawing.Point(133, 179);
            this.MensalRegister.Name = "MensalRegister";
            this.MensalRegister.Size = new System.Drawing.Size(180, 45);
            this.MensalRegister.TabIndex = 3;
            this.MensalRegister.Text = "Retatório Mensal";
            this.MensalRegister.UseVisualStyleBackColor = false;
            this.MensalRegister.Click += new System.EventHandler(this.button3_Click);
            // 
            // listViewProducts
            // 
            this.listViewProducts.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(16, 301);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(431, 377);
            this.listViewProducts.TabIndex = 4;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
            // 
            // NovoProduto
            // 
            this.NovoProduto.AutoSize = true;
            this.NovoProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.NovoProduto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoProduto.Location = new System.Drawing.Point(155, 9);
            this.NovoProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NovoProduto.Name = "NovoProduto";
            this.NovoProduto.Size = new System.Drawing.Size(147, 40);
            this.NovoProduto.TabIndex = 5;
            this.NovoProduto.Text = "Info Tec";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 690);
            this.Controls.Add(this.NovoProduto);
            this.Controls.Add(this.listViewProducts);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sellProduct;
        private System.Windows.Forms.Button registerProduct;
        private System.Windows.Forms.Button MensalRegister;
        private System.Windows.Forms.ColorDialog reportDialog;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.Label NovoProduto;
    }
}


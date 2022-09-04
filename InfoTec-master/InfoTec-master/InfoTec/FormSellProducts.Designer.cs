namespace InfoTec
{
    partial class FormSellProducts
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
            this.idProductEditText = new System.Windows.Forms.TextBox();
            this.registerProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "lnsira o id do produto que você quer vender:";
            // 
            // idProductEditText
            // 
            this.idProductEditText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idProductEditText.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.idProductEditText.Location = new System.Drawing.Point(14, 76);
            this.idProductEditText.Name = "idProductEditText";
            this.idProductEditText.Size = new System.Drawing.Size(314, 24);
            this.idProductEditText.TabIndex = 1;
            this.idProductEditText.TextChanged += new System.EventHandler(this.idProductEditText_TextChanged);
            // 
            // registerProduct
            // 
            this.registerProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(217)))), ((int)(((byte)(40)))));
            this.registerProduct.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.registerProduct.Location = new System.Drawing.Point(96, 104);
            this.registerProduct.Name = "registerProduct";
            this.registerProduct.Size = new System.Drawing.Size(145, 56);
            this.registerProduct.TabIndex = 3;
            this.registerProduct.Text = "Vender Produto";
            this.registerProduct.UseVisualStyleBackColor = false;
            this.registerProduct.Click += new System.EventHandler(this.registerProduct_Click);
            // 
            // FormSellProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 313);
            this.Controls.Add(this.registerProduct);
            this.Controls.Add(this.idProductEditText);
            this.Controls.Add(this.label1);
            this.Name = "FormSellProducts";
            this.Text = "Vender Produto";
            this.Load += new System.EventHandler(this.FormSellProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idProductEditText;
        private System.Windows.Forms.Button registerProduct;
    }
}
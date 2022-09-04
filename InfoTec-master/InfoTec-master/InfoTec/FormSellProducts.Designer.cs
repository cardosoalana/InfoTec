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
            this.sellButton = new System.Windows.Forms.Button();
            this.NovoProduto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.Location = new System.Drawing.Point(52, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "lnsira o id do produto que você quer vender:";
            // 
            // idProductEditText
            // 
            this.idProductEditText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idProductEditText.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.idProductEditText.Location = new System.Drawing.Point(56, 112);
            this.idProductEditText.Name = "idProductEditText";
            this.idProductEditText.Size = new System.Drawing.Size(314, 24);
            this.idProductEditText.TabIndex = 1;
            this.idProductEditText.TextChanged += new System.EventHandler(this.idProductEditText_TextChanged);
            // 
            // sellButton
            // 
            this.sellButton.BackColor = System.Drawing.Color.DarkOrange;
            this.sellButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.ForeColor = System.Drawing.Color.White;
            this.sellButton.Location = new System.Drawing.Point(90, 168);
            this.sellButton.Margin = new System.Windows.Forms.Padding(4);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(240, 55);
            this.sellButton.TabIndex = 8;
            this.sellButton.Text = "Cadastrar";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Click += new System.EventHandler(this.cadastroBtn_Click);
            // 
            // NovoProduto
            // 
            this.NovoProduto.AutoSize = true;
            this.NovoProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.NovoProduto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoProduto.Location = new System.Drawing.Point(89, 21);
            this.NovoProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NovoProduto.Name = "NovoProduto";
            this.NovoProduto.Size = new System.Drawing.Size(274, 40);
            this.NovoProduto.TabIndex = 9;
            this.NovoProduto.Text = "Vender Produto";
            this.NovoProduto.Click += new System.EventHandler(this.NovoProduto_Click);
            // 
            // FormSellProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 690);
            this.Controls.Add(this.NovoProduto);
            this.Controls.Add(this.sellButton);
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
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label NovoProduto;
    }
}
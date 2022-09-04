using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoTec
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSellProducts sellProductsDialog = new FormSellProducts();
            sellProductsDialog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formRegisterDialog = new Form1();
            formRegisterDialog.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMensalReport reportDialog = new FormMensalReport();
            reportDialog.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

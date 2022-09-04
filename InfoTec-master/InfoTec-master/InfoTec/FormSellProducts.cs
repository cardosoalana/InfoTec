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
    public partial class FormSellProducts : Form
    {
        Boolean isEditTextChanged = new Boolean();


        public FormSellProducts()
        {
            InitializeComponent();
        }

        private void FormSellProducts_Load(object sender, EventArgs e)
        {
            isEditTextChanged = false;
        }

       
        private void registerProduct_Click(object sender, EventArgs e)
        {
            if (isEditTextChanged)
            {
                FormDialogSuccess successDialog = new FormDialogSuccess();
                successDialog.ShowDialog();
            }
        }

        private void idProductEditText_TextChanged(object sender, EventArgs e)
        {
            isEditTextChanged = true;
        }
    }
}

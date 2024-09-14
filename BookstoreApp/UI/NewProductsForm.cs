using BookstoreApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreApp.UI
{
    public partial class NewProductsForm : Form
    {
        private Product product = null!;

        public NewProductsForm()
        {
            InitializeComponent();
        }

        public Product GetNewProduct()

        {
            this.ShowDialog();
            return product;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            product = new()
            {
                SKU = skuTextBox.Text,
                Description = descriptionTextBox.Text,
                Price = Convert.ToDecimal(priceTextBox.Text),
            };

        }
    }
}

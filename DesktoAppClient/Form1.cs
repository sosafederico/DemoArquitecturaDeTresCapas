using Business;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktoAppClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Category> categories = new List<Category>();

            Category categoryA = new Category();
            categoryA.CategoryId = 1;
            categoryA.Name = "Category A";

            Category categoryB = new Category();
            categoryB.CategoryId = 2;
            categoryB.Name = "Category B";

            Category categoryC = new Category();
            categoryC.CategoryId = 3;
            categoryC.Name = "Category C";

            categories.Add(categoryA);
            categories.Add(categoryB);
            categories.Add(categoryC);

            cboCategories.DataSource = categories;
            cboCategories.ValueMember = "CategoryId";
            cboCategories.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Name = txtName.Text;
            product.Description = txtName.Text;
            product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            product.UnitsInStock = int.Parse(txtUnitsInStock.Text);
            product.Discontinued = chkDiscontinued.Checked;
            product.CategoryId = int.Parse(cboCategories.SelectedValue.ToString());

            ProductBusiness productBusiness = new ProductBusiness();
            productBusiness.AddProduct(product);

            MessageBox.Show("El producto fue agregado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

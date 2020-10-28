using Orders_PI.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders_PI
{
    public partial class Form1 : Form
    {
        string search = "";
        NORTHWNDEntities entities = new NORTHWNDEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            entities.Products.Load();
            // productBindingSource.DataSource = entities.Products.Local;
            ShowProducts();
        }
        private void ShowProducts()
        {

            using (var context = new NORTHWNDEntities())
            {
                var query = from p in context.Products.Include("Category").Include("Supplier")
                            select p
                            ;

                dgvProducts.DataSource = query.ToList();
            }
        }

        private void clearFilter_Click(object sender, EventArgs e)
        {
            ShowProducts();
            txtFrom.Text="";
            txtTo.Text = "";
            txtSearchProduct.Text = "";

        }

        public void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            
            search = txtSearchProduct.Text.ToString().ToLower();
            var result = from Product in entities.Products.Local
                         where Product.ProductName.ToString().ToLower().Contains(search)
                         select Product;
            if (result.Count() > 0) dgvProducts.DataSource = result.ToList();
            


        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            
            var result = from Product in entities.Products.Local
                         where Product.UnitPrice.Value <= decimal.Parse(txtTo.Text)
                         && Product.UnitPrice.Value >= decimal.Parse(txtFrom.Text)
                         select Product;
            dgvProducts.DataSource = result.ToList();
        }
    }   
}

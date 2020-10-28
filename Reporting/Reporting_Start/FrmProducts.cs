using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporting
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            using (var db = new NORTHWNDEntities())
            {
                cmbCategory.DataSource = db.Categories.ToList();
                cmbSupplier.DataSource = db.Suppliers.ToList();
            }
            
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            Category category = cmbCategory.SelectedItem as Category;
            Supplier supplier = cmbSupplier.SelectedItem as Supplier;
            CategoryBindingSource.DataSource = category;
            SupplierBindingSource.DataSource = supplier;
            //TODO - Get products for this supplier and category

            using (var db = new NORTHWNDEntities())
            {
                var query = from p in db.Products
                            where p.Category.CategoryID == category.CategoryID && p.Supplier.SupplierID == supplier.SupplierID
                            select p;

                List<Product> allproducts = query.ToList();
                ProductBindingSource.DataSource = allproducts;
                            
            }

            //TODO - Send all data to the report and show the report
            
            this.reportViewer1.RefreshReport();
        }
    }
}

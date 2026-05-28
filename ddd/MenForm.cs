using ddd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddd
{
    public partial class MenForm : Form
    {
        Ispr2522SafiulinaAdObContext context;
        public MenForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new Ispr2522SafiulinaAdObContext();

            context.Products.Include(x => x.Manufactuter).Include(x => x.CategoriaProduct).Include(x => x.ProductName).Include(x => x.Supplier).Load();
            context.Manufacturers.Load();
            context.CategoriaProducts.Load();
            context.NameProducts.Load();
            context.Suppliers.Load();

            context.Database.EnsureCreated();

            productbindingSource1.DataSource = context.Products.OrderBy(x => x.Idproduct).ToList();
            manbindingSource1.DataSource = context.Manufacturers.Local.ToBindingList();
            catprodbindingSource1.DataSource = context.CategoriaProducts.Local.ToBindingList();
            productnamebindingSource1.DataSource = context.NameProducts.Local.ToBindingList();
            supbindingSource1.DataSource = context.Suppliers.Local.ToBindingList();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            new MenForm2().Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MenForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var fiter = textBox1.Text.Trim();

            context.ChangeTracker.Clear();

            context.Products
                .Include(x => x.CategoriaProduct)
                .Include(x => x.Manufactuter)
                .Where(x => x.ProductName.NameProduct1.Contains(fiter) ||
                            x.CategoriaProduct.CategoriaProductName.Contains(fiter) ||
                            x.Manufactuter.ManufacturerName.Contains(fiter) ||
                            x.Unit.Contains(fiter) ||
                            x.Article.Contains(fiter))
                .Load();
            productbindingSource1.DataSource = context.Products.Local.OrderBy(x => x.Idproduct).ToList();
            dataGridView1.Refresh();
        }
    }
}

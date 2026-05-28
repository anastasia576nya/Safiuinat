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
    public partial class ClientForm1 : Form
    {
        Ispr2522SafiulinaAdObContext context;
        public ClientForm1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ClientForm1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ClientForm2().Show();this.Hide();
        }
    }
}

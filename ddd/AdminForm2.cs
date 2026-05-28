using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ddd.Models;
using Microsoft.EntityFrameworkCore;


namespace ddd
{
    public partial class AdminForm2 : Form
    {
        Ispr2522SafiulinaAdObContext context;
        public AdminForm2()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new Ispr2522SafiulinaAdObContext();
            context.Database.EnsureCreated();
            context.Orders.Include(x => x.Addres).Include(x => x.SnpUser).Include(x => x.Status).Load();
            context.Addresses.Load();
            context.Users.Load();
            context.StatusOrders.Load();

            addresbindingSource2.DataSource = context.Addresses.Local.ToBindingList();
            statusbindingSource2.DataSource = context.StatusOrders.Local.ToBindingList();
            snpuserbindingSource2.DataSource = context.Users.Local.ToBindingList();
            bindingSource1.DataSource = context.Orders.OrderBy(x => x.Idorders).ToList();
        }
        private void AdminForm2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bindingSource1 != null)
            {
                context.Orders.Remove(new Order());
                context.SaveChanges();

                bindingSource1.RemoveCurrent();
                MessageBox.Show("Удалено");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null) return;
            var form = new EddAddForm2();
            form.addresbindingSource2.DataSource = form.addresbindingSource2.DataSource;
            form.statusbindingSource2.DataSource = form.statusbindingSource2.DataSource;
            form.snpuserbindingSource2.DataSource = form.snpuserbindingSource2.DataSource;
            form.bindingSource1.DataSource = form.bindingSource1.Current;
            form.button1.Click += new EventHandler(button3_Click);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newOrder = new Order();
            newOrder.DataOrders = DateOnly.FromDateTime(DateTime.Now);
            newOrder.DataDelivery = DateOnly.FromDateTime(DateTime.Now);
            newOrder.Code = 0;
            var form = new EddAddForm2();
            form.addresbindingSource2.DataSource = form.addresbindingSource2.DataSource;
            form.statusbindingSource2.DataSource = form.statusbindingSource2.DataSource;
            form.snpuserbindingSource2.DataSource = form.snpuserbindingSource2.DataSource;
            form.bindingSource1.DataSource = newOrder;
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.bindingSource1.EndEdit();
                context.Orders.Add(newOrder);

                if (context.SaveChanges() > 0)
                    bindingSource1.DataSource = context.Orders.Local.OrderBy(x => x.Idorders).ToList();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var filter = textBox1.Text.Trim();
            context.ChangeTracker.Clear();
            context.Orders
                .Include(x => x.Addres)
                .Include(x => x.SnpUser)
                .Where(x => x.Addres.AddressName.Contains(filter) ||
                x.SnpUser.FullName.Contains(filter) ||
                x.Code.ToString().Contains(filter))
                .Load();
            bindingSource1.DataSource = context.Orders.Local.OrderBy(x => x.Idorders).ToList();
            dataGridView1.Refresh();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class MenForm2 : Form
    {
        Ispr2522SafiulinaAdObContext context;
        public MenForm2()
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
        private void MenForm2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
    }
}

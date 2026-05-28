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


    public partial class AdminForm : Form
    {
        Ispr2522SafiulinaAdObContext context;
        public AdminForm()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            dataGridView1.Refresh();
            MessageBox.Show("Сохранено");

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var product = (Product)productbindingSource1.Current;
            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
                productbindingSource1.RemoveCurrent();
                MessageBox.Show("Удалено");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (productbindingSource1.Current == null) return;
            var form = new EddAddForm();
            form.manbindingSource1.DataSource = manbindingSource1.DataSource;
            form.catprodbindingSource1.DataSource = catprodbindingSource1.DataSource;
            form.productnamebindingSource1.DataSource = productnamebindingSource1.DataSource;
            form.productbindingSource1.DataSource = productbindingSource1.Current;
            form.save_button.Click += new EventHandler(button4_Click);
            form.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var newProduct = new Product();
            newProduct.Article = "";
            newProduct.Count = 0;
            newProduct.Price = 0;
            newProduct.Discount = 0;
            newProduct.Description = "";
            newProduct.Unit = "шт.";
            newProduct.Photo = "photo.jpg";

            var form = new EddAddForm();
            form.manbindingSource1.DataSource = manbindingSource1.DataSource;
            form.catprodbindingSource1.DataSource = catprodbindingSource1.DataSource;
            form.supbindingSource1.DataSource = supbindingSource1.DataSource;
            form.productnamebindingSource1.DataSource = productnamebindingSource1.DataSource;
            form.productbindingSource1.DataSource = newProduct;
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.productbindingSource1.EndEdit();

                context.Products.Add(newProduct);

                if (context.SaveChanges() > 0)

                    productbindingSource1.DataSource = context.Products.Local.OrderBy(x => x.Idproduct).ToList();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new AdminForm2().Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. ЕСЛИ выбор убрали (выбрали "Без сортировки"), возвращаем обычный вид
            if (comboBox1.Text == "Без сортировки")
            {
                dataGridView1.DataSource = context.Products.Local.ToList();
                return; // Выходим, чтобы код ниже не выполнялся
            }

            // 2. ОТ МЕНЬШЕГО К БОЛЬШЕМУ (сначaла то, чего мало)
            if (comboBox1.Text == "По количеству (меньше всего)")
            {
                var result = context.Products.Local.OrderBy(p => p.Count).ToList();
                dataGridView1.DataSource = result;
            }

            // 3. ОТ БОЛЬШЕГО К МЕНЬШЕМУ (сначала то, чего много)
            else if (comboBox1.Text == "По количеству (больше всего)")
            {
                var result = context.Products.Local.OrderByDescending(p => p.Count).ToList();
                dataGridView1.DataSource = result;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // var — самая легкая и запоминающаяся переменная
            var brand = comboBox2.Text;

            // 1. Если выбрали сброс фильтра
            if (brand == "Все производители")
            {
                dataGridView1.DataSource = context.Products.Local.ToList();
                return;
            }

            // 2. Фильтруем кэш по выбранному бренду
            var result = context.Products.Local.Where(p => p.Manufactuter.ManufacturerName == brand).ToList();

            dataGridView1.DataSource = result;
        }
    }
}


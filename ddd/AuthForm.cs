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

namespace ddd
{
    public partial class AuthForm : Form
    {
        public static User user;
        Ispr2522SafiulinaAdObContext db = new();
        public AuthForm() => InitializeComponent();


        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            user = null;
            this.Hide();
            new ClientForm1().ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                user = db.Users.FirstOrDefault(x => x.Login == textBox1.Text.Trim() && x.Password == textBox2.Text.Trim());
                if (user == null)
                {
                    MessageBox.Show("Неверный логин или пароль");
                    return;
                }
                this.Hide();
                Form nextForm = user.UserRoleId switch
                {
                    1 => new AdminForm(),
                    2 => new MenForm(),
                    3 => new ClientForm1(),
                    _ => new ClientForm1()
                };
                nextForm.Show();
                this.Show();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка БД" + ex.Message); }

        }
    }
}

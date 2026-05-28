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
    public partial class EddAddForm : Form
    {
        public EddAddForm()
        {
            InitializeComponent();
        }

        private void EddAddForm_Load(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            productbindingSource1.EndEdit();
            if (textBox1.Text == "" || comboBox1.SelectedIndex == -1) { MessageBox.Show("Заполните поля!"); return; }
            // Устанавливаем результат OK, чтобы главная форма поняла: пора сохранять в БД
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

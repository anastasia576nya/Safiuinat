namespace ddd
{
    partial class EddAddForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            bindingSource1 = new BindingSource(components);
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            addresbindingSource2 = new BindingSource(components);
            comboBox2 = new ComboBox();
            snpuserbindingSource2 = new BindingSource(components);
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox3 = new ComboBox();
            statusbindingSource2 = new BindingSource(components);
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addresbindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)snpuserbindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusbindingSource2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(169, 556);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Value", bindingSource1, "DataOrders", true, DataSourceUpdateMode.OnPropertyChanged));
            dateTimePicker1.Location = new Point(57, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Order);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.DataBindings.Add(new Binding("Value", bindingSource1, "DataDelivery", true, DataSourceUpdateMode.OnPropertyChanged));
            dateTimePicker2.Location = new Point(57, 100);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 57);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Дата доставки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 108);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Дата заказа";
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedValue", bindingSource1, "AddresId", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox1.DataSource = addresbindingSource2;
            comboBox1.DisplayMember = "AddressName";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(57, 150);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 5;
            comboBox1.ValueMember = "Idaddress";
            // 
            // addresbindingSource2
            // 
            addresbindingSource2.DataSource = typeof(Models.Address);
            // 
            // comboBox2
            // 
            comboBox2.DataBindings.Add(new Binding("SelectedValue", bindingSource1, "SnpUserId", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox2.DataSource = snpuserbindingSource2;
            comboBox2.DisplayMember = "FullName";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(57, 196);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 6;
            comboBox2.ValueMember = "Iduser";
            // 
            // snpuserbindingSource2
            // 
            snpuserbindingSource2.DataSource = typeof(Models.User);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 158);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Адрес";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 204);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 8;
            label4.Text = "ФИО заказчика";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 244);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 9;
            label5.Text = "Код";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 291);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 10;
            label6.Text = "Статус";
            // 
            // comboBox3
            // 
            comboBox3.DataBindings.Add(new Binding("Text", bindingSource1, "StatusId", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox3.DataSource = statusbindingSource2;
            comboBox3.DisplayMember = "StatusOrderName";
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(57, 283);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(200, 23);
            comboBox3.TabIndex = 11;
            comboBox3.ValueMember = "IdstatusOrder";
            // 
            // statusbindingSource2
            // 
            statusbindingSource2.DataSource = typeof(Models.StatusOrder);
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Code", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.Location = new Point(57, 244);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 12;
            // 
            // EddAddForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 624);
            Controls.Add(textBox1);
            Controls.Add(comboBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Name = "EddAddForm2";
            Text = "Редактирование и удаление заказов";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)addresbindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)snpuserbindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusbindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox3;
        private TextBox textBox1;
        public BindingSource bindingSource1;
        public BindingSource addresbindingSource2;
        public BindingSource statusbindingSource2;
        public BindingSource snpuserbindingSource2;
        public Button button1;
    }
}
namespace ddd
{
    partial class EddAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EddAddForm));
            save_button = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            productbindingSource1 = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            productnamebindingSource1 = new BindingSource(components);
            comboBox2 = new ComboBox();
            supbindingSource1 = new BindingSource(components);
            comboBox3 = new ComboBox();
            manbindingSource1 = new BindingSource(components);
            comboBox4 = new ComboBox();
            catprodbindingSource1 = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)productbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productnamebindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catprodbindingSource1).BeginInit();
            SuspendLayout();
            // 
            // save_button
            // 
            save_button.Location = new Point(181, 600);
            save_button.Name = "save_button";
            save_button.Size = new Size(129, 38);
            save_button.TabIndex = 0;
            save_button.Text = "button1";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 85);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "артикул";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", productbindingSource1, "Article", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.Location = new Point(182, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 2;
            // 
            // productbindingSource1
            // 
            productbindingSource1.DataSource = typeof(Models.Product);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", productbindingSource1, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox2.Location = new Point(182, 235);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", productbindingSource1, "Unit", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox3.Location = new Point(182, 191);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", productbindingSource1, "Discount", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox4.Location = new Point(181, 398);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(129, 23);
            textBox4.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedValue", productbindingSource1, "ProductNameId", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox1.DataSource = productnamebindingSource1;
            comboBox1.DisplayMember = "NameProduct1";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(182, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(128, 23);
            comboBox1.TabIndex = 6;
            comboBox1.ValueMember = "IdnameProduct";
            // 
            // productnamebindingSource1
            // 
            productnamebindingSource1.DataSource = typeof(Models.NameProduct);
            // 
            // comboBox2
            // 
            comboBox2.DataBindings.Add(new Binding("SelectedValue", productbindingSource1, "SupplierId", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox2.DataSource = supbindingSource1;
            comboBox2.DisplayMember = "SupplierName";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(181, 275);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(129, 23);
            comboBox2.TabIndex = 7;
            comboBox2.ValueMember = "Idsupplier";
            // 
            // supbindingSource1
            // 
            supbindingSource1.DataSource = typeof(Models.Supplier);
            // 
            // comboBox3
            // 
            comboBox3.DataBindings.Add(new Binding("SelectedValue", productbindingSource1, "ManufactuterId", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox3.DataSource = manbindingSource1;
            comboBox3.DisplayMember = "ManufacturerName";
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(181, 316);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(129, 23);
            comboBox3.TabIndex = 8;
            comboBox3.ValueMember = "Idmanufacturer";
            // 
            // manbindingSource1
            // 
            manbindingSource1.DataSource = typeof(Models.Manufacturer);
            // 
            // comboBox4
            // 
            comboBox4.DataBindings.Add(new Binding("SelectedValue", productbindingSource1, "CategoriaProductId", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox4.DataSource = catprodbindingSource1;
            comboBox4.DisplayMember = "CategoriaProductName";
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(182, 354);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(128, 23);
            comboBox4.TabIndex = 9;
            comboBox4.ValueMember = "IdcategoriaProduct";
            // 
            // catprodbindingSource1
            // 
            catprodbindingSource1.DataSource = typeof(Models.CategoriaProduct);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 146);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 10;
            label2.Text = "название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 199);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 11;
            label3.Text = "ед.измерения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 243);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 12;
            label4.Text = "цена";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(341, 283);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 13;
            label5.Text = "поставщик";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(341, 316);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 14;
            label6.Text = "производитель";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(341, 362);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 15;
            label7.Text = "категория";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(341, 401);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 16;
            label8.Text = "скидка";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", productbindingSource1, "Count", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox5.Location = new Point(181, 443);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(129, 23);
            textBox5.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(341, 451);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 18;
            label9.Text = "кол-во";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(341, 498);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 19;
            label10.Text = "описание";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(341, 541);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 20;
            label11.Text = "фото";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", productbindingSource1, "Description", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox6.Location = new Point(182, 495);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(128, 23);
            textBox6.TabIndex = 21;
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", productbindingSource1, "Photo", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox7.Location = new Point(182, 546);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(128, 23);
            textBox7.TabIndex = 22;
            // 
            // EddAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 681);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(save_button);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EddAddForm";
            Text = "Редактирование и удаление товара";
            Load += EddAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)productbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productnamebindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)catprodbindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox6;
        private TextBox textBox7;
        public BindingSource productbindingSource1;
        public BindingSource productnamebindingSource1;
        public BindingSource supbindingSource1;
        public BindingSource manbindingSource1;
        public BindingSource catprodbindingSource1;
        public Button save_button;
    }
}
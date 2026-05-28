namespace ddd
{
    partial class AdminForm
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
            dataGridView1 = new DataGridView();
            idproductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            articleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            productnamebindingSource1 = new BindingSource(components);
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            supbindingSource1 = new BindingSource(components);
            manufactuterIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            manbindingSource1 = new BindingSource(components);
            categoriaProductIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            catprodbindingSource1 = new BindingSource(components);
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            photoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            manufactuterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productbindingSource1 = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            save_button = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productnamebindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catprodbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productbindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idproductDataGridViewTextBoxColumn, articleDataGridViewTextBoxColumn, productNameIdDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, supplierIdDataGridViewTextBoxColumn, manufactuterIdDataGridViewTextBoxColumn, categoriaProductIdDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, photoDataGridViewTextBoxColumn, categoriaProductDataGridViewTextBoxColumn, manufactuterDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, supplierDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productbindingSource1;
            dataGridView1.Location = new Point(38, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(719, 272);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idproductDataGridViewTextBoxColumn
            // 
            idproductDataGridViewTextBoxColumn.DataPropertyName = "Idproduct";
            idproductDataGridViewTextBoxColumn.HeaderText = "Idproduct";
            idproductDataGridViewTextBoxColumn.Name = "idproductDataGridViewTextBoxColumn";
            // 
            // articleDataGridViewTextBoxColumn
            // 
            articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            articleDataGridViewTextBoxColumn.HeaderText = "Article";
            articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            // 
            // productNameIdDataGridViewTextBoxColumn
            // 
            productNameIdDataGridViewTextBoxColumn.DataPropertyName = "ProductNameId";
            productNameIdDataGridViewTextBoxColumn.DataSource = productnamebindingSource1;
            productNameIdDataGridViewTextBoxColumn.DisplayMember = "NameProduct1";
            productNameIdDataGridViewTextBoxColumn.HeaderText = "ProductNameId";
            productNameIdDataGridViewTextBoxColumn.Name = "productNameIdDataGridViewTextBoxColumn";
            productNameIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            productNameIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            productNameIdDataGridViewTextBoxColumn.ValueMember = "IdnameProduct";
            // 
            // productnamebindingSource1
            // 
            productnamebindingSource1.DataSource = typeof(Models.NameProduct);
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            supplierIdDataGridViewTextBoxColumn.DataSource = supbindingSource1;
            supplierIdDataGridViewTextBoxColumn.DisplayMember = "SupplierName";
            supplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId";
            supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            supplierIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            supplierIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            supplierIdDataGridViewTextBoxColumn.ValueMember = "Idsupplier";
            // 
            // supbindingSource1
            // 
            supbindingSource1.DataSource = typeof(Models.Supplier);
            // 
            // manufactuterIdDataGridViewTextBoxColumn
            // 
            manufactuterIdDataGridViewTextBoxColumn.DataPropertyName = "ManufactuterId";
            manufactuterIdDataGridViewTextBoxColumn.DataSource = manbindingSource1;
            manufactuterIdDataGridViewTextBoxColumn.DisplayMember = "ManufacturerName";
            manufactuterIdDataGridViewTextBoxColumn.HeaderText = "ManufactuterId";
            manufactuterIdDataGridViewTextBoxColumn.Name = "manufactuterIdDataGridViewTextBoxColumn";
            manufactuterIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            manufactuterIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            manufactuterIdDataGridViewTextBoxColumn.ValueMember = "Idmanufacturer";
            // 
            // manbindingSource1
            // 
            manbindingSource1.DataSource = typeof(Models.Manufacturer);
            // 
            // categoriaProductIdDataGridViewTextBoxColumn
            // 
            categoriaProductIdDataGridViewTextBoxColumn.DataPropertyName = "CategoriaProductId";
            categoriaProductIdDataGridViewTextBoxColumn.DataSource = catprodbindingSource1;
            categoriaProductIdDataGridViewTextBoxColumn.DisplayMember = "CategoriaProductName";
            categoriaProductIdDataGridViewTextBoxColumn.HeaderText = "CategoriaProductId";
            categoriaProductIdDataGridViewTextBoxColumn.Name = "categoriaProductIdDataGridViewTextBoxColumn";
            categoriaProductIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            categoriaProductIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            categoriaProductIdDataGridViewTextBoxColumn.ValueMember = "IdcategoriaProduct";
            // 
            // catprodbindingSource1
            // 
            catprodbindingSource1.DataSource = typeof(Models.CategoriaProduct);
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Count";
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // categoriaProductDataGridViewTextBoxColumn
            // 
            categoriaProductDataGridViewTextBoxColumn.DataPropertyName = "CategoriaProduct";
            categoriaProductDataGridViewTextBoxColumn.HeaderText = "CategoriaProduct";
            categoriaProductDataGridViewTextBoxColumn.Name = "categoriaProductDataGridViewTextBoxColumn";
            categoriaProductDataGridViewTextBoxColumn.Visible = false;
            // 
            // manufactuterDataGridViewTextBoxColumn
            // 
            manufactuterDataGridViewTextBoxColumn.DataPropertyName = "Manufactuter";
            manufactuterDataGridViewTextBoxColumn.HeaderText = "Manufactuter";
            manufactuterDataGridViewTextBoxColumn.Name = "manufactuterDataGridViewTextBoxColumn";
            manufactuterDataGridViewTextBoxColumn.Visible = false;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            supplierDataGridViewTextBoxColumn.Visible = false;
            // 
            // productbindingSource1
            // 
            productbindingSource1.DataSource = typeof(Models.Product);
            // 
            // button1
            // 
            button1.Location = new Point(35, 89);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "добав";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(116, 89);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "редак";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(197, 89);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "удал";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // save_button
            // 
            save_button.Location = new Point(278, 89);
            save_button.Name = "save_button";
            save_button.Size = new Size(75, 23);
            save_button.TabIndex = 4;
            save_button.Text = "сохран";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(14, 14);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "выйти";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(682, 14);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "заказы";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(391, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(88, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 62);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 9;
            label1.Text = "поиск";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(628, 62);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 10;
            label2.Text = "филтрация";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Без сортировки", "По количеству (меньше всего)", "По количеству (больше всего)" });
            comboBox1.Location = new Point(485, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(94, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Все производители", "Kari", "Marco Tozzi", "Poc", "Rieker", "Alessio Nesca", "CROSBY" });
            comboBox2.Location = new Point(608, 90);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(99, 23);
            comboBox2.TabIndex = 12;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 62);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 13;
            label3.Text = "сортировка";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 466);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(save_button);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "AdminForm";
            Text = "Товары";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productnamebindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)catprodbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productbindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        public BindingSource productbindingSource1;
        public BindingSource productnamebindingSource1;
        public BindingSource supbindingSource1;
        public BindingSource manbindingSource1;
        public BindingSource catprodbindingSource1;
        public Button save_button;
        private DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn productNameIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn supplierIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn manufactuterIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn categoriaProductIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manufactuterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
    }
}
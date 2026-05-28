namespace ddd
{
    partial class MenForm
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
            button2 = new Button();
            dataGridView1 = new DataGridView();
            idproductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            articleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            manufactuterIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaProductIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            photoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            manufactuterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productbindingSource1 = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            productnamebindingSource1 = new BindingSource(components);
            supbindingSource1 = new BindingSource(components);
            manbindingSource1 = new BindingSource(components);
            catprodbindingSource1 = new BindingSource(components);
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productnamebindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catprodbindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(38, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "выйти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(700, 22);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "заказы";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idproductDataGridViewTextBoxColumn, articleDataGridViewTextBoxColumn, productNameIdDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, supplierIdDataGridViewTextBoxColumn, manufactuterIdDataGridViewTextBoxColumn, categoriaProductIdDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, photoDataGridViewTextBoxColumn, categoriaProductDataGridViewTextBoxColumn, manufactuterDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, supplierDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productbindingSource1;
            dataGridView1.Location = new Point(38, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(715, 305);
            dataGridView1.TabIndex = 2;
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
            productNameIdDataGridViewTextBoxColumn.HeaderText = "ProductNameId";
            productNameIdDataGridViewTextBoxColumn.Name = "productNameIdDataGridViewTextBoxColumn";
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
            supplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId";
            supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            // 
            // manufactuterIdDataGridViewTextBoxColumn
            // 
            manufactuterIdDataGridViewTextBoxColumn.DataPropertyName = "ManufactuterId";
            manufactuterIdDataGridViewTextBoxColumn.HeaderText = "ManufactuterId";
            manufactuterIdDataGridViewTextBoxColumn.Name = "manufactuterIdDataGridViewTextBoxColumn";
            // 
            // categoriaProductIdDataGridViewTextBoxColumn
            // 
            categoriaProductIdDataGridViewTextBoxColumn.DataPropertyName = "CategoriaProductId";
            categoriaProductIdDataGridViewTextBoxColumn.HeaderText = "CategoriaProductId";
            categoriaProductIdDataGridViewTextBoxColumn.Name = "categoriaProductIdDataGridViewTextBoxColumn";
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
            // 
            // manufactuterDataGridViewTextBoxColumn
            // 
            manufactuterDataGridViewTextBoxColumn.DataPropertyName = "Manufactuter";
            manufactuterDataGridViewTextBoxColumn.HeaderText = "Manufactuter";
            manufactuterDataGridViewTextBoxColumn.Name = "manufactuterDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // productbindingSource1
            // 
            productbindingSource1.DataSource = typeof(Models.Product);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 47);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "Поиск";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 47);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 6;
            label2.Text = "Фильтрация";
            // 
            // productnamebindingSource1
            // 
            productnamebindingSource1.DataSource = typeof(Models.NameProduct);
            // 
            // supbindingSource1
            // 
            supbindingSource1.DataSource = typeof(Models.Supplier);
            // 
            // manbindingSource1
            // 
            manbindingSource1.DataSource = typeof(Models.Manufacturer);
            // 
            // catprodbindingSource1
            // 
            catprodbindingSource1.DataSource = typeof(Models.CategoriaProduct);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(291, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(437, 77);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 47);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 9;
            label3.Text = "сортировка";
            // 
            // MenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenForm";
            Text = "Товары";
            Load += MenForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productnamebindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)catprodbindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        public BindingSource productnamebindingSource1;
        public BindingSource productbindingSource1;
        public BindingSource supbindingSource1;
        public BindingSource manbindingSource1;
        private DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manufactuterIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaProductIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manufactuterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        public BindingSource catprodbindingSource1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
    }
}
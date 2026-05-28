namespace ddd
{
    partial class ClientForm1
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
            dataGridView1.Location = new Point(25, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(755, 453);
            dataGridView1.TabIndex = 0;
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
            button1.Location = new Point(12, 38);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "выйти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(695, 38);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "заказы";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ClientForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 603);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ClientForm1";
            Text = "Товары";
            Load += ClientForm1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productnamebindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)catprodbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productbindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        public BindingSource productbindingSource1;
        public BindingSource productnamebindingSource1;
        public BindingSource supbindingSource1;
        public BindingSource manbindingSource1;
        private DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn productNameIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn supplierIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn manufactuterIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn categoriaProductIdDataGridViewTextBoxColumn;
        public BindingSource catprodbindingSource1;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manufactuterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
    }
}
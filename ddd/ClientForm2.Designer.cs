namespace ddd
{
    partial class ClientForm2
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
            button1 = new Button();
            button2 = new Button();
            bindingSource1 = new BindingSource(components);
            addresbindingSource2 = new BindingSource(components);
            statusbindingSource2 = new BindingSource(components);
            snpuserbindingSource2 = new BindingSource(components);
            idordersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataOrdersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDeliveryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addresIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            snpUserIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            snpUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addresbindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusbindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)snpuserbindingSource2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idordersDataGridViewTextBoxColumn, dataOrdersDataGridViewTextBoxColumn, dataDeliveryDataGridViewTextBoxColumn, addresIdDataGridViewTextBoxColumn, snpUserIdDataGridViewTextBoxColumn, codeDataGridViewTextBoxColumn, statusIdDataGridViewTextBoxColumn, addresDataGridViewTextBoxColumn, snpUserDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(32, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(756, 413);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 33);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(694, 33);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "выйти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Order);
            // 
            // addresbindingSource2
            // 
            addresbindingSource2.DataSource = typeof(Models.Address);
            // 
            // statusbindingSource2
            // 
            statusbindingSource2.DataSource = typeof(Models.StatusOrder);
            // 
            // snpuserbindingSource2
            // 
            snpuserbindingSource2.DataSource = typeof(Models.User);
            // 
            // idordersDataGridViewTextBoxColumn
            // 
            idordersDataGridViewTextBoxColumn.DataPropertyName = "Idorders";
            idordersDataGridViewTextBoxColumn.HeaderText = "Idorders";
            idordersDataGridViewTextBoxColumn.Name = "idordersDataGridViewTextBoxColumn";
            // 
            // dataOrdersDataGridViewTextBoxColumn
            // 
            dataOrdersDataGridViewTextBoxColumn.DataPropertyName = "DataOrders";
            dataOrdersDataGridViewTextBoxColumn.HeaderText = "DataOrders";
            dataOrdersDataGridViewTextBoxColumn.Name = "dataOrdersDataGridViewTextBoxColumn";
            // 
            // dataDeliveryDataGridViewTextBoxColumn
            // 
            dataDeliveryDataGridViewTextBoxColumn.DataPropertyName = "DataDelivery";
            dataDeliveryDataGridViewTextBoxColumn.HeaderText = "DataDelivery";
            dataDeliveryDataGridViewTextBoxColumn.Name = "dataDeliveryDataGridViewTextBoxColumn";
            // 
            // addresIdDataGridViewTextBoxColumn
            // 
            addresIdDataGridViewTextBoxColumn.DataPropertyName = "AddresId";
            addresIdDataGridViewTextBoxColumn.HeaderText = "AddresId";
            addresIdDataGridViewTextBoxColumn.Name = "addresIdDataGridViewTextBoxColumn";
            // 
            // snpUserIdDataGridViewTextBoxColumn
            // 
            snpUserIdDataGridViewTextBoxColumn.DataPropertyName = "SnpUserId";
            snpUserIdDataGridViewTextBoxColumn.HeaderText = "SnpUserId";
            snpUserIdDataGridViewTextBoxColumn.Name = "snpUserIdDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Code";
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // statusIdDataGridViewTextBoxColumn
            // 
            statusIdDataGridViewTextBoxColumn.DataPropertyName = "StatusId";
            statusIdDataGridViewTextBoxColumn.HeaderText = "StatusId";
            statusIdDataGridViewTextBoxColumn.Name = "statusIdDataGridViewTextBoxColumn";
            // 
            // addresDataGridViewTextBoxColumn
            // 
            addresDataGridViewTextBoxColumn.DataPropertyName = "Addres";
            addresDataGridViewTextBoxColumn.HeaderText = "Addres";
            addresDataGridViewTextBoxColumn.Name = "addresDataGridViewTextBoxColumn";
            // 
            // snpUserDataGridViewTextBoxColumn
            // 
            snpUserDataGridViewTextBoxColumn.DataPropertyName = "SnpUser";
            snpUserDataGridViewTextBoxColumn.HeaderText = "SnpUser";
            snpUserDataGridViewTextBoxColumn.Name = "snpUserDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // ClientForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 527);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ClientForm2";
            Text = "ClientForm2";
            Load += ClientForm2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)addresbindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusbindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)snpuserbindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        public BindingSource bindingSource1;
        public BindingSource addresbindingSource2;
        public BindingSource statusbindingSource2;
        public BindingSource snpuserbindingSource2;
        private DataGridViewTextBoxColumn idordersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataOrdersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeliveryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addresIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn snpUserIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn snpUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
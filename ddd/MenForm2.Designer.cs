namespace ddd
{
    partial class MenForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenForm2));
            dataGridView1 = new DataGridView();
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
            bindingSource1 = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            addresbindingSource2 = new BindingSource(components);
            statusbindingSource2 = new BindingSource(components);
            snpuserbindingSource2 = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
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
            dataGridView1.Location = new Point(29, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(736, 315);
            dataGridView1.TabIndex = 0;
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
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Order);
            // 
            // button1
            // 
            button1.Location = new Point(23, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "назад";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(690, 20);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "выйти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // textBox1
            // 
            textBox1.Location = new Point(136, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Поиск";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(301, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(445, 62);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 28);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 7;
            label2.Text = "Фильтрация";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 28);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 8;
            label3.Text = "Сортировка";
            // 
            // MenForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenForm2";
            Text = "Заказы";
            Load += MenForm2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)addresbindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusbindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)snpuserbindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        public BindingSource bindingSource1;
        public BindingSource addresbindingSource2;
        public BindingSource statusbindingSource2;
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
        public BindingSource snpuserbindingSource2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
    }
}
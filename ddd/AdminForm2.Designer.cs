namespace ddd
{
    partial class AdminForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm2));
            dataGridView1 = new DataGridView();
            idordersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataOrdersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDeliveryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addresIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            addresbindingSource2 = new BindingSource(components);
            snpUserIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            snpuserbindingSource2 = new BindingSource(components);
            codeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            statusbindingSource2 = new BindingSource(components);
            addresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            snpUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addresbindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)snpuserbindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusbindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idordersDataGridViewTextBoxColumn, dataOrdersDataGridViewTextBoxColumn, dataDeliveryDataGridViewTextBoxColumn, addresIdDataGridViewTextBoxColumn, snpUserIdDataGridViewTextBoxColumn, codeDataGridViewTextBoxColumn, statusIdDataGridViewTextBoxColumn, addresDataGridViewTextBoxColumn, snpUserDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(12, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(687, 271);
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
            addresIdDataGridViewTextBoxColumn.DataSource = addresbindingSource2;
            addresIdDataGridViewTextBoxColumn.DisplayMember = "AddressName";
            addresIdDataGridViewTextBoxColumn.HeaderText = "AddresId";
            addresIdDataGridViewTextBoxColumn.Name = "addresIdDataGridViewTextBoxColumn";
            addresIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            addresIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            addresIdDataGridViewTextBoxColumn.ValueMember = "Idaddress";
            // 
            // addresbindingSource2
            // 
            addresbindingSource2.DataSource = typeof(Models.Address);
            // 
            // snpUserIdDataGridViewTextBoxColumn
            // 
            snpUserIdDataGridViewTextBoxColumn.DataPropertyName = "SnpUserId";
            snpUserIdDataGridViewTextBoxColumn.DataSource = snpuserbindingSource2;
            snpUserIdDataGridViewTextBoxColumn.DisplayMember = "FullName";
            snpUserIdDataGridViewTextBoxColumn.HeaderText = "SnpUserId";
            snpUserIdDataGridViewTextBoxColumn.Name = "snpUserIdDataGridViewTextBoxColumn";
            snpUserIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            snpUserIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            snpUserIdDataGridViewTextBoxColumn.ValueMember = "Iduser";
            // 
            // snpuserbindingSource2
            // 
            snpuserbindingSource2.DataSource = typeof(Models.User);
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
            statusIdDataGridViewTextBoxColumn.DataSource = statusbindingSource2;
            statusIdDataGridViewTextBoxColumn.DisplayMember = "StatusOrderName";
            statusIdDataGridViewTextBoxColumn.HeaderText = "StatusId";
            statusIdDataGridViewTextBoxColumn.Name = "statusIdDataGridViewTextBoxColumn";
            statusIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            statusIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            statusIdDataGridViewTextBoxColumn.ValueMember = "IdstatusOrder";
            // 
            // statusbindingSource2
            // 
            statusbindingSource2.DataSource = typeof(Models.StatusOrder);
            // 
            // addresDataGridViewTextBoxColumn
            // 
            addresDataGridViewTextBoxColumn.DataPropertyName = "Addres";
            addresDataGridViewTextBoxColumn.HeaderText = "Addres";
            addresDataGridViewTextBoxColumn.Name = "addresDataGridViewTextBoxColumn";
            addresDataGridViewTextBoxColumn.Visible = false;
            // 
            // snpUserDataGridViewTextBoxColumn
            // 
            snpUserDataGridViewTextBoxColumn.DataPropertyName = "SnpUser";
            snpUserDataGridViewTextBoxColumn.HeaderText = "SnpUser";
            snpUserDataGridViewTextBoxColumn.Name = "snpUserDataGridViewTextBoxColumn";
            snpUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Order);
            // 
            // button1
            // 
            button1.Location = new Point(37, 31);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(624, 31);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "выйти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(52, 94);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "редак";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(133, 94);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "добав";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(214, 94);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "удал";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(295, 94);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "сохран";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(403, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 65);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 9;
            label1.Text = "Поиск";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(515, 65);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 10;
            label2.Text = "Фильтрация";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(633, 65);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 11;
            label3.Text = "Сортировка";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(515, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(89, 23);
            comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(620, 95);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(86, 23);
            comboBox2.TabIndex = 13;
            // 
            // AdminForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 428);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm2";
            Text = "Заказы";
            Load += AdminForm2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)addresbindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)snpuserbindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusbindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        public BindingSource addresbindingSource2;
        public BindingSource statusbindingSource2;
        public BindingSource bindingSource1;
        public BindingSource snpuserbindingSource2;
        private DataGridViewTextBoxColumn idordersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataOrdersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeliveryDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn addresIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn snpUserIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn statusIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn snpUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}
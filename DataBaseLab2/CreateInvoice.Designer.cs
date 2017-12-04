namespace DataBaseLab2
{
    partial class CreateInvoice
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
            this.components = new System.ComponentModel.Container();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IsDelivery = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductNameCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseForLabDataSet = new DataBaseLab2.DatabaseForLabDataSet();
            this.AmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.InvoiceTableAdapter();
            this.productInInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productInInvoiceTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.ProductInInvoiceTableAdapter();
            this.productTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.ProductTableAdapter();
            this.SuppliercomboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockComboBox = new System.Windows.Forms.ComboBox();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.SupplierTableAdapter();
            this.stockTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.StockTableAdapter();
            this.employeeTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.EmployeeTableAdapter();
            this.productInStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productInStockTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.ProductInStockTableAdapter();
            this.totalLabel = new System.Windows.Forms.Label();
            this.invoiceNumLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseForLabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(101, 91);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.DateTimePicker.TabIndex = 3;
            // 
            // IsDelivery
            // 
            this.IsDelivery.AutoSize = true;
            this.IsDelivery.Location = new System.Drawing.Point(101, 117);
            this.IsDelivery.Name = "IsDelivery";
            this.IsDelivery.Size = new System.Drawing.Size(121, 17);
            this.IsDelivery.TabIndex = 4;
            this.IsDelivery.Text = "поставка на склад";
            this.IsDelivery.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNameCol,
            this.AmountCol,
            this.CostCol,
            this.UnitCol,
            this.TypeCol,
            this.SumCol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 195);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // ProductNameCol
            // 
            this.ProductNameCol.DataSource = this.productBindingSource;
            this.ProductNameCol.DisplayMember = "Name";
            this.ProductNameCol.HeaderText = "ProductName";
            this.ProductNameCol.Name = "ProductNameCol";
            this.ProductNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductNameCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductNameCol.ValueMember = "Name";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.databaseForLabDataSet;
            this.bindingSource1.Position = 0;
            // 
            // databaseForLabDataSet
            // 
            this.databaseForLabDataSet.DataSetName = "DatabaseForLabDataSet";
            this.databaseForLabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AmountCol
            // 
            this.AmountCol.HeaderText = "Amount";
            this.AmountCol.Name = "AmountCol";
            // 
            // CostCol
            // 
            this.CostCol.HeaderText = "Cost";
            this.CostCol.Name = "CostCol";
            this.CostCol.ReadOnly = true;
            // 
            // UnitCol
            // 
            this.UnitCol.HeaderText = "Unit";
            this.UnitCol.Name = "UnitCol";
            this.UnitCol.ReadOnly = true;
            // 
            // TypeCol
            // 
            this.TypeCol.HeaderText = "Type";
            this.TypeCol.Name = "TypeCol";
            this.TypeCol.ReadOnly = true;
            // 
            // SumCol
            // 
            this.SumCol.HeaderText = "Sum";
            this.SumCol.Name = "SumCol";
            this.SumCol.ReadOnly = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(137, 344);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.Text = "Применить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.bindingSource1;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // productInInvoiceBindingSource
            // 
            this.productInInvoiceBindingSource.DataMember = "ProductInInvoice";
            this.productInInvoiceBindingSource.DataSource = this.bindingSource1;
            // 
            // productInInvoiceTableAdapter
            // 
            this.productInInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // SuppliercomboBox
            // 
            this.SuppliercomboBox.DataSource = this.supplierBindingSource;
            this.SuppliercomboBox.DisplayMember = "Name";
            this.SuppliercomboBox.FormattingEnabled = true;
            this.SuppliercomboBox.Location = new System.Drawing.Point(101, 13);
            this.SuppliercomboBox.Name = "SuppliercomboBox";
            this.SuppliercomboBox.Size = new System.Drawing.Size(121, 21);
            this.SuppliercomboBox.TabIndex = 7;
            this.SuppliercomboBox.ValueMember = "Name";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.bindingSource1;
            // 
            // StockComboBox
            // 
            this.StockComboBox.DataSource = this.stockBindingSource;
            this.StockComboBox.DisplayMember = "Address";
            this.StockComboBox.FormattingEnabled = true;
            this.StockComboBox.Location = new System.Drawing.Point(101, 37);
            this.StockComboBox.Name = "StockComboBox";
            this.StockComboBox.Size = new System.Drawing.Size(121, 21);
            this.StockComboBox.TabIndex = 8;
            this.StockComboBox.ValueMember = "Num";
            this.StockComboBox.SelectedValueChanged += new System.EventHandler(this.StockComboBox_SelectedValueChanged);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.bindingSource1;
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.DataSource = this.employeeBindingSource;
            this.EmployeeComboBox.DisplayMember = "Name";
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Location = new System.Drawing.Point(101, 64);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(121, 21);
            this.EmployeeComboBox.TabIndex = 9;
            this.EmployeeComboBox.ValueMember = "Id";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bindingSource1;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // productInStockBindingSource
            // 
            this.productInStockBindingSource.DataMember = "ProductInStock";
            this.productInStockBindingSource.DataSource = this.bindingSource1;
            // 
            // productInStockTableAdapter
            // 
            this.productInStockTableAdapter.ClearBeforeFill = true;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(497, 351);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(47, 13);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "ИТОГО:";
            // 
            // invoiceNumLabel
            // 
            this.invoiceNumLabel.AutoSize = true;
            this.invoiceNumLabel.Location = new System.Drawing.Point(323, 10);
            this.invoiceNumLabel.Name = "invoiceNumLabel";
            this.invoiceNumLabel.Size = new System.Drawing.Size(77, 13);
            this.invoiceNumLabel.TabIndex = 11;
            this.invoiceNumLabel.Text = "Накладная №";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Организация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Склад";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Сотрудник";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата ";
            // 
            // CreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 373);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invoiceNumLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.EmployeeComboBox);
            this.Controls.Add(this.StockComboBox);
            this.Controls.Add(this.SuppliercomboBox);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IsDelivery);
            this.Controls.Add(this.DateTimePicker);
            this.Name = "CreateInvoice";
            this.Text = "CreateInvoice";
            this.Load += new System.EventHandler(this.CreateInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseForLabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInStockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.CheckBox IsDelivery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DatabaseForLabDataSet databaseForLabDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private DatabaseForLabDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingSource productInInvoiceBindingSource;
        private DatabaseForLabDataSetTableAdapters.ProductInInvoiceTableAdapter productInInvoiceTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DatabaseForLabDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.ComboBox SuppliercomboBox;
        private System.Windows.Forms.ComboBox StockComboBox;
        private System.Windows.Forms.ComboBox EmployeeComboBox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private DatabaseForLabDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private DatabaseForLabDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DatabaseForLabDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumCol;
        private System.Windows.Forms.BindingSource productInStockBindingSource;
        private DatabaseForLabDataSetTableAdapters.ProductInStockTableAdapter productInStockTableAdapter;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label invoiceNumLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
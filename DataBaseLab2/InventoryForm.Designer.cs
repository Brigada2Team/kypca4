namespace DataBaseLab2
{
    partial class InventoryForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StockBox = new System.Windows.Forms.CheckedListBox();
            this.TypeBox = new System.Windows.Forms.CheckedListBox();
            this.UnitBox = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.amountFromText = new System.Windows.Forms.TextBox();
            this.amountToText = new System.Windows.Forms.TextBox();
            this.costToText = new System.Windows.Forms.TextBox();
            this.costFromText = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseForLabDataSet = new DataBaseLab2.DatabaseForLabDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.ProductTableAdapter();
            this.productInStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productInStockTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.ProductInStockTableAdapter();
            this.view2TableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.View2TableAdapter();
            this.stockTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.StockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseForLabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.costPerUnitDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.numOfStockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.view2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 57);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(472, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // filterBox
            // 
            this.filterBox.Location = new System.Drawing.Point(22, 31);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(100, 20);
            this.filterBox.TabIndex = 1;
            this.filterBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фильтр";
            // 
            // findBox
            // 
            this.findBox.Location = new System.Drawing.Point(154, 31);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(100, 20);
            this.findBox.TabIndex = 3;
            this.findBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Найти";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Склад";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Тип товара";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Единица измерения";
            // 
            // StockBox
            // 
            this.StockBox.FormattingEnabled = true;
            this.StockBox.Location = new System.Drawing.Point(619, 31);
            this.StockBox.Name = "StockBox";
            this.StockBox.Size = new System.Drawing.Size(120, 49);
            this.StockBox.TabIndex = 15;
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(619, 86);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(120, 49);
            this.TypeBox.TabIndex = 16;
            // 
            // UnitBox
            // 
            this.UnitBox.FormattingEnabled = true;
            this.UnitBox.Location = new System.Drawing.Point(619, 141);
            this.UnitBox.Name = "UnitBox";
            this.UnitBox.Size = new System.Drawing.Size(120, 49);
            this.UnitBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Количество от";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Цена от";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "до";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "до";
            // 
            // amountFromText
            // 
            this.amountFromText.Location = new System.Drawing.Point(105, 237);
            this.amountFromText.Name = "amountFromText";
            this.amountFromText.Size = new System.Drawing.Size(35, 20);
            this.amountFromText.TabIndex = 23;
            this.amountFromText.Text = "0";
            // 
            // amountToText
            // 
            this.amountToText.Location = new System.Drawing.Point(171, 237);
            this.amountToText.Name = "amountToText";
            this.amountToText.Size = new System.Drawing.Size(35, 20);
            this.amountToText.TabIndex = 24;
            this.amountToText.Text = "9999";
            // 
            // costToText
            // 
            this.costToText.Location = new System.Drawing.Point(459, 237);
            this.costToText.Name = "costToText";
            this.costToText.Size = new System.Drawing.Size(35, 20);
            this.costToText.TabIndex = 25;
            this.costToText.Text = "9999";
            // 
            // costFromText
            // 
            this.costFromText.Location = new System.Drawing.Point(393, 237);
            this.costFromText.Name = "costFromText";
            this.costFromText.Size = new System.Drawing.Size(35, 20);
            this.costFromText.TabIndex = 26;
            this.costFromText.Text = "0";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(619, 204);
            this.filterButton.Name = "filterButton";
            this.filterButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filterButton.Size = new System.Drawing.Size(120, 53);
            this.filterButton.TabIndex = 27;
            this.filterButton.Text = "Применить фильтр";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // costPerUnitDataGridViewTextBoxColumn
            // 
            this.costPerUnitDataGridViewTextBoxColumn.DataPropertyName = "CostPerUnit";
            this.costPerUnitDataGridViewTextBoxColumn.HeaderText = "CostPerUnit";
            this.costPerUnitDataGridViewTextBoxColumn.Name = "costPerUnitDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // numOfStockDataGridViewTextBoxColumn
            // 
            this.numOfStockDataGridViewTextBoxColumn.DataPropertyName = "NumOfStock";
            this.numOfStockDataGridViewTextBoxColumn.HeaderText = "NumOfStock";
            this.numOfStockDataGridViewTextBoxColumn.Name = "numOfStockDataGridViewTextBoxColumn";
            // 
            // view2BindingSource
            // 
            this.view2BindingSource.DataMember = "View2";
            this.view2BindingSource.DataSource = this.databaseForLabDataSet;
            // 
            // databaseForLabDataSet
            // 
            this.databaseForLabDataSet.DataSetName = "DatabaseForLabDataSet";
            this.databaseForLabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.databaseForLabDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productInStockBindingSource
            // 
            this.productInStockBindingSource.DataMember = "ProductInStock";
            this.productInStockBindingSource.DataSource = this.databaseForLabDataSet;
            // 
            // productInStockTableAdapter
            // 
            this.productInStockTableAdapter.ClearBeforeFill = true;
            // 
            // view2TableAdapter
            // 
            this.view2TableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 262);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.costFromText);
            this.Controls.Add(this.costToText);
            this.Controls.Add(this.amountToText);
            this.Controls.Add(this.amountFromText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UnitBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.StockBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseForLabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInStockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox findBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DatabaseForLabDataSet databaseForLabDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DatabaseForLabDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.CheckedListBox StockBox;
        private System.Windows.Forms.CheckedListBox TypeBox;
        private System.Windows.Forms.CheckedListBox UnitBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox amountFromText;
        private System.Windows.Forms.TextBox amountToText;
        private System.Windows.Forms.TextBox costToText;
        private System.Windows.Forms.TextBox costFromText;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.BindingSource productInStockBindingSource;
        private DatabaseForLabDataSetTableAdapters.ProductInStockTableAdapter productInStockTableAdapter;
        private System.Windows.Forms.BindingSource view2BindingSource;
        private DatabaseForLabDataSetTableAdapters.View2TableAdapter view2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private DatabaseForLabDataSetTableAdapters.StockTableAdapter stockTableAdapter;
    }
}
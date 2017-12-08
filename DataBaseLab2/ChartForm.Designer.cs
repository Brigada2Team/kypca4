namespace DataBaseLab2
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseForLabDataSet = new DataBaseLab2.DatabaseForLabDataSet();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.ProductTableAdapter();
            this.productInStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productInStockTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.ProductInStockTableAdapter();
            this.productInInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productInInvoiceTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.ProductInInvoiceTableAdapter();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.InvoiceTableAdapter();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.StockTableAdapter();
            this.supplierTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.SupplierTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseForLabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
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
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.supplierBindingSource;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.bindingSource1;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.bindingSource1;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
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
            // productInInvoiceBindingSource
            // 
            this.productInInvoiceBindingSource.DataMember = "ProductInInvoice";
            this.productInInvoiceBindingSource.DataSource = this.bindingSource1;
            // 
            // productInInvoiceTableAdapter
            // 
            this.productInInvoiceTableAdapter.ClearBeforeFill = true;
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
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.bindingSource1;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 13);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Сумма поставок за всё время";
            series1.Name = "Suppliers";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(553, 371);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 396);
            this.Controls.Add(this.chart1);
            this.Name = "ChartForm";
            this.Text = "ChartFom";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            this.Shown += new System.EventHandler(this.ChartForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseForLabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private DatabaseForLabDataSet databaseForLabDataSet;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DatabaseForLabDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productInStockBindingSource;
        private DatabaseForLabDataSetTableAdapters.ProductInStockTableAdapter productInStockTableAdapter;
        private System.Windows.Forms.BindingSource productInInvoiceBindingSource;
        private DatabaseForLabDataSetTableAdapters.ProductInInvoiceTableAdapter productInInvoiceTableAdapter;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private DatabaseForLabDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private DatabaseForLabDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private DatabaseForLabDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
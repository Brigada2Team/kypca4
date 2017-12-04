using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.databaseForLabDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.ProductInInvoice". При необходимости она может быть перемещена или удалена.
            this.productInInvoiceTableAdapter.Fill(this.databaseForLabDataSet.ProductInInvoice);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Invoice". При необходимости она может быть перемещена или удалена.
            this.invoiceTableAdapter.Fill(this.databaseForLabDataSet.Invoice);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.ProductInStock". При необходимости она может быть перемещена или удалена.
            this.productInStockTableAdapter.Fill(this.databaseForLabDataSet.ProductInStock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.databaseForLabDataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.databaseForLabDataSet.Stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.databaseForLabDataSet.Product);
            dataGridView1.AutoGenerateColumns = true;
            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            productTableAdapter.Update(databaseForLabDataSet);
            supplierTableAdapter.Update(databaseForLabDataSet);
            stockTableAdapter.Update(databaseForLabDataSet);
            productInStockTableAdapter.Update(databaseForLabDataSet);
            employeeTableAdapter.Update(databaseForLabDataSet);
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bindingNavigator1.BindingSource = productBindingSource;
            dataGridView1.DataSource = productBindingSource;
            label1.Text = "Продукты";
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bindingNavigator1.BindingSource = stockBindingSource;
            dataGridView1.DataSource = stockBindingSource;
            label1.Text = "Склады";
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource =supplierBindingSource;
            dataGridView1.DataSource = supplierBindingSource;
            label1.Text = "Поставщики";
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var StockProductsForm = new StockProductsForm();
            StockProductsForm.ShowDialog();
            stockTableAdapter.Fill(databaseForLabDataSet.Stock);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            productTableAdapter.Update(databaseForLabDataSet);
            supplierTableAdapter.Update(databaseForLabDataSet);
            stockTableAdapter.Update(databaseForLabDataSet);
            productInStockTableAdapter.Update(databaseForLabDataSet);
            employeeTableAdapter.Update(databaseForLabDataSet);

        }


        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InventoryForm = new InventoryForm();
            InventoryForm.ShowDialog();
            productTableAdapter.Fill(databaseForLabDataSet.Product);
            databaseForLabDataSet.AcceptChanges();
        }



        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }





        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CreateInvoice = new CreateInvoice();
            CreateInvoice.ShowDialog();

        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var invoicesForm = new DisplayInvoices();
            invoicesForm.Show();
        }

        private void reportFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.Show();
        }

        private void QueryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new QueryEdit();
            qe.Show();
        }

        private void employersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeeBindingSource;
            bindingNavigator1.BindingSource = employeeBindingSource;
            label1.Text = "Работяги";
        }

        private void AddItemStripButton_Click(object sender, EventArgs e)
        {
            var edt = new ProductEditForm();
            edt.ShowDialog();
            productTableAdapter.Fill(databaseForLabDataSet.Product);
            databaseForLabDataSet.AcceptChanges();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            productTableAdapter.Update(databaseForLabDataSet);
            
            supplierTableAdapter.Update(databaseForLabDataSet);
            stockTableAdapter.Update(databaseForLabDataSet);
            productInStockTableAdapter.Update(databaseForLabDataSet);

            employeeTableAdapter.Update(databaseForLabDataSet);
        }
    }
}

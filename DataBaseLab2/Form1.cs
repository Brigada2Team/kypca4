using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

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
            System.Windows.Forms.Application.Exit();
            
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



        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InventoryForm = new InventoryForm();
            InventoryForm.ShowDialog();
            productTableAdapter.Fill(databaseForLabDataSet.Product);
            
        }



        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CreateInvoice = new CreateInvoice();
            CreateInvoice.ShowDialog();

        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var invoicesForm = new DisplayInvoices();
            invoicesForm.ShowDialog();
        }

        private void reportFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document doc = new Document();
            object readOnly = false;
            object isVisible = true;
            object missing = System.Reflection.Missing.Value;
            OpenFileDialog dial = new OpenFileDialog();
            dial.ShowDialog();
            object filename = dial.FileName;

            doc = app.Documents.Open(ref filename, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible);
            doc.Content.Select();
            doc.Content.Copy();
            richTextBox1.Clear();
            richTextBox1.Paste();
            
            doc.Close();
            app.Quit();
            string[] splitted = richTextBox1.Text.Split(new string[] { "\t" }, StringSplitOptions.None);
            string[] splittedHeader = splitted[0].Split(new string[] { "\n" }, StringSplitOptions.None);
            bool isDelivery = false;

            if (splittedHeader[0].Substring(10, 4) == "отпр") isDelivery = false;
            else if (splittedHeader[0].Substring(10, 4) == "пост") isDelivery = true;
            string organisation = splittedHeader[2].Substring(13);
            int stockNum = Convert.ToInt32(splittedHeader[3].Split(',')[0].Substring(7));
            int employeeId = Convert.ToInt32(splittedHeader[4].Split(',')[1].Substring(4));
            DateTime date = Convert.ToDateTime(splittedHeader[5].Substring(5));
            string[,] products = new string[(splitted.Length - 7) / 6, 5];
            for (int i = 6; i < splitted.Length - 1; i++)
            {
                products[i / 6 - 1, i % 6] = splitted[i++].Substring(1);
                products[i / 6 - 1, i % 6] = splitted[i++];
                products[i / 6 - 1, i % 6] = splitted[i++];
                products[i / 6 - 1, i % 6] = splitted[i++];
                products[i / 6 - 1, i % 6] = splitted[i++];
            }

            if (organisation != databaseForLabDataSet.Supplier.Select("Name='" + organisation + "'")[0].ItemArray[0].ToString())
            {
                supplierTableAdapter.Insert(organisation, null);
            }
            for (int i = 0; i < products.GetLength(0); i++)
            {
                if (products[i, 0] != databaseForLabDataSet.Product.Select("Name='" + products[i, 0] + "'")[0].ItemArray[0].ToString())
                {
                    productTableAdapter.Insert(products[i, 0], products[i, 1], Convert.ToDouble(products[i, 2]), products[i, 3]);
                }
            }
            CreateInvoice form = new CreateInvoice(isDelivery, organisation, stockNum, employeeId, date, products);
            form.ShowDialog();
        }

        private void QueryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new QueryEdit();
            qe.ShowDialog();
        }

        private void employersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeeBindingSource;
            bindingNavigator1.BindingSource = employeeBindingSource;
            label1.Text = "Работяги";
        }

        private void AddItemStripButton_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Продукты")
            {
                var edt = new ProductEditForm();
                edt.ShowDialog();
                productTableAdapter.Fill(databaseForLabDataSet.Product);
            }
            if (label1.Text == "Склады")
            {
                var edt = new StockEditForm();
                edt.ShowDialog();
                stockTableAdapter.Fill(databaseForLabDataSet.Stock);
            }
                databaseForLabDataSet.AcceptChanges();
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var selectedRow = dataGridView1.Rows[e.RowIndex].Cells;
            if (label1.Text == "Продукты")
            {
                var edt = new ProductEditForm(selectedRow[0].Value.ToString(), selectedRow[1].Value.ToString(), Convert.ToDecimal(selectedRow[2].Value), selectedRow[3].Value.ToString());
                edt.ShowDialog();
                productTableAdapter.Fill(databaseForLabDataSet.Product);
            }
            if (label1.Text == "Склады")
            {
                var edt = new StockEditForm(Convert.ToInt32(selectedRow[0].Value), selectedRow[1].Value.ToString());
                edt.ShowDialog();
                stockTableAdapter.Fill(databaseForLabDataSet.Stock);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int selected = dataGridView1.Rows.IndexOf(dataGridView1.SelectedRows[0]);
            try
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                productTableAdapter.Update(databaseForLabDataSet);
                supplierTableAdapter.Update(databaseForLabDataSet);
                stockTableAdapter.Update(databaseForLabDataSet);
                employeeTableAdapter.Update(databaseForLabDataSet);
            }
            catch
            {
                productTableAdapter.Fill(databaseForLabDataSet.Product);
                stockTableAdapter.Fill(databaseForLabDataSet.Stock);
                employeeTableAdapter.Fill(databaseForLabDataSet.Employee);
                supplierTableAdapter.Fill(databaseForLabDataSet.Supplier);
                dataGridView1.Rows[selected].ErrorText = "Существуют связанные дочерние элементы";


            }
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ChartForm();
            form.Show();
        }
    }
}

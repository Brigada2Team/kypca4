using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;

namespace DataBaseLab2
{
    public partial class StockProductsForm : Form
    {
        public StockProductsForm()
        {
            InitializeComponent();
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseForLabDataSet);

        }

        private void productInStockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.databaseForLabDataSet);

        }

        private void StockProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.databaseForLabDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.ProductInStock". При необходимости она может быть перемещена или удалена.
            this.productInStockTableAdapter.Fill(this.databaseForLabDataSet.ProductInStock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.databaseForLabDataSet.Stock);
            

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
 {
                stockTableAdapter.Update(databaseForLabDataSet);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void numTextBox_TextChanged(object sender, EventArgs e)
        {
            var select = "SELECT [Product].[Name],[Product].[Type],[Product].[Unit],[Product].[CostPerUnit],[ProductInStock].[Amount] FROM [Product],[ProductInStock] WHERE [Product].[Name]=[ProductInStock].[Name] AND [ProductInStock].[NumOfStock] = " + numTextBox.Text;
            var c = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=c:\\users\\user\\documents\\visual studio 2015\\Projects\\DataBaseLab2\\DataBaseLab2\\DatabaseForLab.mdf;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);


            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document doc = app.Documents.Add(Visible: true);


            DataRow[] productInStockRows = databaseForLabDataSet.ProductInStock.Select("NumOfStock =" + numTextBox.Text);
            DataRow[] stockRow = databaseForLabDataSet.Stock.Select("Num ="+numTextBox.Text);
            DataRow[] productRow = databaseForLabDataSet.Product.Select();



            var r0 = doc.Paragraphs.Add();
            r0.Range.Bold = 1;
            r0.Range.Font.Size = 20;
            string text = "Инвентарь склада №"+stockRow[0].ItemArray[0];

            r0.Range.Text = text;
            r0.Range.InsertParagraphAfter();

            var r = doc.Paragraphs.Add();
            r.Range.Bold = 0;
            r.Range.Text += "\nАдрес: " + stockRow[0].ItemArray[1] +
                "\nВремя создания отчета: " + DateTime.Now;
            r.Range.InsertParagraphAfter();

            var r2 = doc.Paragraphs.Add();
            Table t = doc.Tables.Add(r2.Range, productInStockRows.Length + 1, 6);
            t.Borders.Enable = 1;
            t.Rows[1].Cells[1].Range.Text = "Название товара";
            t.Rows[1].Cells[2].Range.Text = "Вид товара";
            t.Rows[1].Cells[3].Range.Text = "Единица измерения";
            t.Rows[1].Cells[4].Range.Text = "Количество";
            t.Rows[1].Cells[5].Range.Text = "Цена за единицу";
            t.Rows[1].Cells[6].Range.Text = "Сумма";
            double sum = 0;
            foreach (Row row in t.Rows)
            {
                if (row.Index > 1)
                {
                    DataRow[] productRows = databaseForLabDataSet.Product.Select("Name = '" + productInStockRows[row.Index - 2].ItemArray[0].ToString() + "'");
                    row.Cells[1].Range.Text = productInStockRows[row.Index - 2].ItemArray[0].ToString();
                    row.Cells[2].Range.Text = productRows[0].ItemArray[3].ToString();
                    row.Cells[3].Range.Text = productRows[0].ItemArray[1].ToString();
                    row.Cells[4].Range.Text = productInStockRows[row.Index - 2].ItemArray[1].ToString();
                    row.Cells[5].Range.Text = productRows[0].ItemArray[2].ToString();
                    row.Cells[6].Range.Text = (Convert.ToDouble(productInStockRows[row.Index - 2].ItemArray[1]) * Convert.ToDouble(productRows[0].ItemArray[2])).ToString();
                    sum += (Convert.ToDouble(productInStockRows[row.Index - 2].ItemArray[1]) * Convert.ToDouble(productRows[0].ItemArray[2]));
                }
            }
            r2.Range.InsertParagraphAfter();
            var r3 = doc.Paragraphs.Add();
            r3.Range.Text = "Итого: " + sum;
            r3.Range.Bold = 1;
            doc.Save();
            
            app.Quit();
        }
    }
}

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
    public partial class DisplayInvoices : Form
    {
        public DisplayInvoices()
        {
            InitializeComponent();
        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseForLabDataSet);

        }

        private void DisplayInvoices_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.databaseForLabDataSet.Stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.databaseForLabDataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.databaseForLabDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.databaseForLabDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.ProductInInvoice". При необходимости она может быть перемещена или удалена.
            this.productInInvoiceTableAdapter.Fill(this.databaseForLabDataSet.ProductInInvoice);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Invoice". При необходимости она может быть перемещена или удалена.
            this.invoiceTableAdapter.Fill(this.databaseForLabDataSet.Invoice);

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document doc = app.Documents.Add(Visible: true);
            

            DataRow[] invoiceRow = databaseForLabDataSet.Invoice.Select("Num =" + numTextBox.Text);
            DataRow[] stockRows = databaseForLabDataSet.Stock.Select();
            DataRow[] employeeRows = databaseForLabDataSet.Employee.Select();
            
            DataRow[] productInInvoiceRows = databaseForLabDataSet.ProductInInvoice.Select("NumOfInvoice = "+Convert.ToInt32(numTextBox.Text));
            var r0 = doc.Paragraphs.Add();
            r0.Range.Bold = 1;
            r0.Range.Font.Size = 20;
            string text = "Накладная";
            if (Convert.ToBoolean(invoiceRow[0].ItemArray[5]))
                text += " поставки";
            else text += " отправки";
            text += " №" + invoiceRow[0].ItemArray[0];
            r0.Range.Text = text;

            r0.Range.InsertParagraphAfter();

            var r = doc.Paragraphs.Add();
            r.Range.Bold = 0;
            r.Range.Text +=
                "\nОрганизация: "+ invoiceRow[0].ItemArray[3]+
                "\nCклад №" +invoiceRow[0].ItemArray[1]+", "+stockRows[Convert.ToInt32(invoiceRow[0].ItemArray[1])-1].ItemArray[1]
                +"\nСотрудник склада: "+employeeRows[Convert.ToInt32(invoiceRow[0].ItemArray[2])-1].ItemArray[1]+", Id: "+ employeeRows[Convert.ToInt32(invoiceRow[0].ItemArray[2])-1].ItemArray[0]
                + "\nДата: "+invoiceRow[0].ItemArray[4];
            r.Range.InsertParagraphAfter();

            var r2 = doc.Paragraphs.Add();
            Table t = doc.Tables.Add(r2.Range, productInInvoiceRows.Length+1, 6);
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
                    DataRow[] productRow = databaseForLabDataSet.Product.Select("Name = '"+ productInInvoiceRows[row.Index - 2].ItemArray[0].ToString()+"'");
                    row.Cells[1].Range.Text = productInInvoiceRows[row.Index - 2].ItemArray[0].ToString();
                    row.Cells[2].Range.Text = productRow[0].ItemArray[3].ToString();
                    row.Cells[3].Range.Text = productRow[0].ItemArray[1].ToString();
                    row.Cells[4].Range.Text = productInInvoiceRows[row.Index - 2].ItemArray[2].ToString();
                    row.Cells[5].Range.Text = productRow[0].ItemArray[2].ToString();
                    row.Cells[6].Range.Text = (Convert.ToDouble(productInInvoiceRows[row.Index - 2].ItemArray[2]) * Convert.ToDouble(productRow[0].ItemArray[2])).ToString();
                    sum += (Convert.ToDouble(productInInvoiceRows[row.Index - 2].ItemArray[2]) * Convert.ToDouble(productRow[0].ItemArray[2]));
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

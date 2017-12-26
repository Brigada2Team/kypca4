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
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();


        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.databaseForLabDataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.databaseForLabDataSet.Stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Invoice". При необходимости она может быть перемещена или удалена.
            this.invoiceTableAdapter.Fill(this.databaseForLabDataSet.Invoice);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.ProductInInvoice". При необходимости она может быть перемещена или удалена.
            this.productInInvoiceTableAdapter.Fill(this.databaseForLabDataSet.ProductInInvoice);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.ProductInStock". При необходимости она может быть перемещена или удалена.
            this.productInStockTableAdapter.Fill(this.databaseForLabDataSet.ProductInStock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.databaseForLabDataSet.Product);





        }

        private void ChartForm_Shown(object sender, EventArgs e)
        {
            chart1.Series["Suppliers"].Points.Clear();


            for (int i = 0; i < databaseForLabDataSet.Supplier.Select().Length; i++)
            {
                DateTime min = dateTimePicker1.Value;
                DateTime max = dateTimePicker2.Value;
                DataTable table = productInInvoiceTableAdapter.GetSupplierProductsBy(databaseForLabDataSet.Supplier.Rows[i].ItemArray[0].ToString(),min,max);
                double sum = 0;
                for (int j = 0; j < table.Rows.Count; j++)
                   
                    sum += Convert.ToDouble(table.Rows[j].ItemArray[1]) * Convert.ToDouble(table.Rows[j].ItemArray[2]);
                chart1.Series["Suppliers"].Points.AddXY(databaseForLabDataSet.Supplier.Rows[i].ItemArray[0].ToString(), sum);

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Jpeg;
            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                    format = System.Drawing.Imaging.ImageFormat.Jpeg;
                    break;

                case 2:
                    format = System.Drawing.Imaging.ImageFormat.Bmp;
                    break;

                case 3:
                    format = System.Drawing.Imaging.ImageFormat.Gif;
                    break;
            }
            if (saveFileDialog1.FileName != "") 
            chart1.SaveImage(saveFileDialog1.FileName, format);
        }
    }
}

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

            DataRow[] suppliers = databaseForLabDataSet.Supplier.Select("Name");
            for (int i = 0; i < suppliers.Length; i++)
            {
                DataTable table = productInInvoiceTableAdapter.GetSupplierProductsBy(suppliers[i].ItemArray[0].ToString());
                double sum = 0;
                for (int j = 0; j < table.Rows.Count; j++)
                    sum += Convert.ToDouble(table.Rows[j].ItemArray[1]) * Convert.ToDouble(table.Rows[j].ItemArray[2]);
                chart1.Series[0].Points.AddY(sum);

            }
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
    }
}

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
    public partial class CreateInvoice : Form
    {
        public CreateInvoice()
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.ProductInStock". При необходимости она может быть перемещена или удалена.
            this.productInStockTableAdapter.Fill(this.databaseForLabDataSet.ProductInStock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.databaseForLabDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.databaseForLabDataSet.Stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.databaseForLabDataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.databaseForLabDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.ProductInInvoice". При необходимости она может быть перемещена или удалена.
            this.productInInvoiceTableAdapter.Fill(this.databaseForLabDataSet.ProductInInvoice);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Invoice". При необходимости она может быть перемещена или удалена.
            this.invoiceTableAdapter.Fill(this.databaseForLabDataSet.Invoice);
            invoiceNumLabel.Text += invoiceTableAdapter.MaxId() + 1;
        }
        public CreateInvoice(bool isDeliveryBool,string organisation,int stock,int emp,DateTime date, string[,] products) : this()
        {
            IsDelivery.Checked = isDeliveryBool;
            SuppliercomboBox.SelectedValue = organisation;
            StockComboBox.SelectedValue= stock;
            EmployeeComboBox.SelectedValue = emp;
            DateTimePicker.Value = date;
            for(int i = 0; i < products.GetLength(0); i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = products[i, 0];
                dataGridView1.Rows[i].Cells[1].Value = products[i, 3];
                
            }
        }
		

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int prodStock = Convert.ToInt32(StockComboBox.SelectedValue);
            for (int i = 0; !dataGridView1.Rows[i].IsNewRow; i++)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[i];
                string prodName = selectedRow.Cells[0].Value.ToString();
                double prodAmount;


                try
                {
                    prodAmount = Convert.ToDouble(selectedRow.Cells[1].Value);
                }
                catch
                {
                    selectedRow.Cells[1].ErrorText = "Допускаются только цифры и запятая";
                    return;
                }

                if (!(prodAmount > 0))
                {
                    selectedRow.Cells[1].ErrorText = "Количество должно быть больше нуля";
                    return;
                }
                if (!IsDelivery.Checked && prodAmount > Convert.ToDouble(productInStockTableAdapter.GetAmount(prodName, prodStock)))
                {
                    selectedRow.Cells[1].ErrorText = "На складе имеется только "+ Convert.ToDouble(productInStockTableAdapter.GetAmount(prodName, prodStock))+" единиц товара";
                    return;
                }
                selectedRow.Cells[1].ErrorText = string.Empty;

            }
                invoiceTableAdapter.InsertQuery( prodStock, Convert.ToInt32(EmployeeComboBox.SelectedValue), SuppliercomboBox.SelectedValue.ToString(), DateTimePicker.Value, IsDelivery.Checked);
            for(int i = 0; !dataGridView1.Rows[i].IsNewRow; i++)
            {
                string prodName = dataGridView1.Rows[i].Cells[0].Value.ToString();
                double prodAmount = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);

               productInInvoiceTableAdapter.Insert(
                   prodName, 
                   Convert.ToInt32(invoiceTableAdapter.MaxId().Value),
                   prodAmount);
                if (productInStockTableAdapter.GetAmount(prodName, prodStock) == null)
                {
                    productInStockTableAdapter.Insert(prodName, prodAmount, prodStock);
                    continue;
                }
                if (!IsDelivery.Checked)
                prodAmount = -prodAmount;
                productInStockTableAdapter.IncreaseAmount(prodAmount,
                    prodName,
                   prodStock);
                if (productInStockTableAdapter.GetAmount(prodName,prodStock) == 0)
                    productInStockTableAdapter.DeleteQuery(prodName,prodStock);


            }
            
        }

        private void CreateInvoice_Load(object sender, EventArgs e)
        {

        }

        private void StockComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            employeeTableAdapter.FillBy(this.databaseForLabDataSet.Employee, Convert.ToInt32(StockComboBox.SelectedValue));
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!dataGridView1.Rows[0].IsNewRow)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (e.ColumnIndex == 0)
                {

                    DataTable aaa = databaseForLabDataSet.Product;
                    DataRow[] result = aaa.Select("Name = '" + selectedRow.Cells[0].Value.ToString() + "'");

                    selectedRow.Cells[2].Value = result[0].ItemArray[2];
                    selectedRow.Cells[3].Value = result[0].ItemArray[1];
                    selectedRow.Cells[4].Value = result[0].ItemArray[3];
                    selectedRow.Cells[1].Value = productInStockTableAdapter.GetAmount(selectedRow.Cells[0].Value.ToString(), Convert.ToInt32(StockComboBox.SelectedValue));

                }
                try
                {
                    selectedRow.Cells[5].Value = Convert.ToDouble(selectedRow.Cells[1].Value) * Convert.ToDouble(selectedRow.Cells[2].Value);
                    selectedRow.Cells[1].ErrorText = "";
                }
                catch
                {
                   selectedRow.Cells[1].ErrorText = "Допускаются только цифры и запятая";
                   return;
                }
                double sum = 0;
                for(int i = 0; !dataGridView1.Rows[i].IsNewRow; i++)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                }
                totalLabel.Text = "ИТОГО: " + sum;
            }
        }
    }
}

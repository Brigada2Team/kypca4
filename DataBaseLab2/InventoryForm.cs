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

namespace DataBaseLab2
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            
        }
        public string expression;
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet1.Stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.databaseForLabDataSet.Stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.View2". При необходимости она может быть перемещена или удалена.
            this.view2TableAdapter.Fill(this.databaseForLabDataSet.View2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.ProductInStock". При необходимости она может быть перемещена или удалена.
            this.productInStockTableAdapter.Fill(this.databaseForLabDataSet.ProductInStock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.databaseForLabDataSet.Product);
            (StockBox as ListBox).DataSource = databaseForLabDataSet.Stock;
            (StockBox as ListBox).DisplayMember = "Num";
            (StockBox as ListBox).ValueMember = "Num";
            (TypeBox as ListBox).DataSource = new DataView(databaseForLabDataSet.Product).ToTable(true, "Type");
            (TypeBox as ListBox).DisplayMember = "Type";
            (TypeBox as ListBox).ValueMember = "Type";
            (UnitBox as ListBox).DataSource = new DataView(databaseForLabDataSet.Product).ToTable(true, "Unit");
            (UnitBox as ListBox).DisplayMember = "Unit";
            (UnitBox as ListBox).ValueMember = "Unit";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if (dataGridView1.Rows[i].Cells[0].Value.ToString().ToUpper().Contains(findBox.Text.ToUpper()))
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;
                    break;
                }
            if(dataGridView1.SelectedRows.Count>0)
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;


        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            expression = "";
            if (StockBox.CheckedItems.Count > 0)
            {
                expression += "NumOfStock IN (";
                for (int i = 0; i < StockBox.CheckedItems.Count; i++)
                    expression += (StockBox.CheckedItems[i] as DataRowView).Row.ItemArray[0] + ",";
                expression = expression.Remove(expression.Length - 1);
                expression += ") AND ";

            }
            if (TypeBox.CheckedItems.Count > 0)
            {
                expression += "Type IN (";
                for (int i = 0; i < TypeBox.CheckedItems.Count; i++)
                    expression += "'"+(TypeBox.CheckedItems[i] as DataRowView).Row.ItemArray[0] + "',";
                expression = expression.Remove(expression.Length - 1);
                expression += ") AND ";
            }
            if (UnitBox.CheckedItems.Count > 0)
            {
                expression += "Unit IN (";
                for (int i = 0; i < UnitBox.CheckedItems.Count; i++)
                    expression += "'" + (UnitBox.CheckedItems[i] as DataRowView).Row.ItemArray[0] + "',";
                expression = expression.Remove(expression.Length - 1);
                expression += ") AND ";
            }

            expression += "Amount >= " + amountFromText.Text + " AND Amount <= " + amountToText.Text+" AND ";
            expression += "CostPerUnit >= " + costFromText.Text + " AND CostPerUnit <= " + costToText.Text+" AND ";
            expression += "(Name LIKE '%" + filterBox.Text + "%' OR Type LIKE '%"+filterBox.Text+"%') AND ";

            if (expression != string.Empty)
                expression = expression.Remove(expression.Length - 4);
            DataTable table = databaseForLabDataSet.View2;
            var tableRows = table.Select(expression);
            dataGridView1.DataSource = tableRows;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            var selectedCells = (sender as DataGridView).SelectedCells;
           
            if (selectedCells.Count > 0)
            {
                try
                {
                    if (e.ColumnIndex == 0)
                    {

                        productTableAdapter.UpdateQuery(e.FormattedValue.ToString(), selectedCells[1].Value.ToString(), Convert.ToDecimal(selectedCells[3].Value), selectedCells[4].Value.ToString(), selectedCells[0].Value.ToString());
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        productTableAdapter.UpdateQuery(selectedCells[0].Value.ToString(), e.FormattedValue.ToString(), Convert.ToDecimal(selectedCells[3].Value), selectedCells[4].Value.ToString(), selectedCells[0].Value.ToString());
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        productTableAdapter.UpdateQuery(selectedCells[0].Value.ToString(), selectedCells[1].Value.ToString(), Convert.ToDecimal(e.FormattedValue), selectedCells[4].Value.ToString(), selectedCells[0].Value.ToString());
                    }
                    else if (e.ColumnIndex == 4)
                    {
                        productTableAdapter.UpdateQuery(selectedCells[0].Value.ToString(), selectedCells[1].Value.ToString(), Convert.ToDecimal(selectedCells[3].Value), e.FormattedValue.ToString(), selectedCells[0].Value.ToString());
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        productInStockTableAdapter.UpdateQuery(selectedCells[0].Value.ToString(), Convert.ToDouble(e.FormattedValue), Convert.ToInt32(selectedCells[5].Value), selectedCells[0].Value.ToString(), Convert.ToInt32(selectedCells[5].Value));
                    }
                    else if (e.ColumnIndex == 5)
                    {
                        productInStockTableAdapter.UpdateQuery(selectedCells[0].Value.ToString(), Convert.ToDouble(selectedCells[2].Value), Convert.ToInt32(e.FormattedValue), selectedCells[0].Value.ToString(), Convert.ToInt32(selectedCells[5].Value));
                    }
                }
                catch { }
                productInStockTableAdapter.Fill(databaseForLabDataSet.ProductInStock);
                productTableAdapter.Fill(databaseForLabDataSet.Product);
                dataGridView1.DataSource = databaseForLabDataSet.View2;
                view2TableAdapter.Fill(databaseForLabDataSet.View2);
                dataGridView1.DataSource = databaseForLabDataSet.View2.Select(expression);
            }
        }
    }
}

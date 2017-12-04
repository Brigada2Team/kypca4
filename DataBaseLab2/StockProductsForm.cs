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
    }
}

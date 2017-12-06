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
    public partial class StockEditForm : Form
    {
            private readonly int stockNum;
            readonly bool edit;

        public StockEditForm()
        {
 
            InitializeComponent();
            
        }

        public void ProductEditForm_Load(object sender, EventArgs e)
        {

        }
        public StockEditForm(int stockNum, string address)
             : this()
            {
            textBox_stockNum.ReadOnly = true;
            edit = true;
            this.stockNum = stockNum;
            textBox_stockNum.Text = stockNum.ToString();
            textBox_address.Text = address;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {

            if (edit)
            {
                stockTableAdapter.UpdateQuery(stockNum,textBox_address.Text,stockNum);
            }
            else
            {
                try
                {
                    stockTableAdapter.Insert(Convert.ToInt32(textBox_stockNum.Text), textBox_address.Text);
                }
                catch
                {
                    label1.Text = "Неверный номер склада";
                    label1.ForeColor = Color.Red;
                    return;
                }
            }
            Close();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StockEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.databaseForLabDataSet.Stock);

        }
    }
}

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
    public partial class SupplierEditForm : Form
    {
        private readonly string name;
        readonly bool edit;

        public SupplierEditForm()
        {

            InitializeComponent();

        }

        public void SupplierEditForm_Load(object sender, EventArgs e)
        {

        }
        public SupplierEditForm(string name, string phone)
             : this()
            {
            edit = true;
            this.name = name;
            textBox_Name.Text = name;
            textBox_phone.Text = phone;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {

            if (edit)
            {
                supplierTableAdapter.UpdateQuery(textBox_Name.Text,textBox_phone.Text,name);
            }
            else
            {
                try
                {
                    supplierTableAdapter.Insert(textBox_Name.Text,textBox_phone.Text);
                }
                catch
                {
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
            this.supplierTableAdapter.Fill(this.databaseForLabDataSet.Supplier);

        }

        private void SupplierEditForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.databaseForLabDataSet.Supplier);

        }
    }
}

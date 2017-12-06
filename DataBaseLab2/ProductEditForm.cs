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
    public partial class ProductEditForm : Form
    {
       
        private readonly string name;
        readonly bool edit;

        public ProductEditForm()
        {
            InitializeComponent();
            productTableAdapter.Fill(databaseForLabDataSet.Product);
            comboBox_Unit.DataSource = new DataView(databaseForLabDataSet.Product).ToTable(true,"Unit");
            comboBox_Unit.DisplayMember = "Unit";
            comboBox_Unit.ValueMember = "Unit";
            comboBox_Type.DataSource = new DataView(databaseForLabDataSet.Product).ToTable(true, "Type");
            comboBox_Type.DisplayMember = "Type";
            comboBox_Type.ValueMember = "Type";

        }

        public void ProductEditForm_Load(object sender, EventArgs e)
        {

        }
        public ProductEditForm(string name, string unit, decimal cost, string type)
         : this()
        {
            edit = true;
            this.name = name;
            textBox_Name.Text = name;
            comboBox_Unit.SelectedValue = unit;
            textBox_UnitCost.Text = cost.ToString();
            comboBox_Type.SelectedValue = type;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {

            if (edit)
            {
                productTableAdapter.UpdateQuery(textBox_Name.Text, comboBox_Unit.Text, Convert.ToDecimal(textBox_UnitCost.Text),
                comboBox_Type.Text, name);
            }
            else
            {
                productTableAdapter.Insert(textBox_Name.Text, comboBox_Unit.Text, Convert.ToDouble(textBox_UnitCost.Text),
               comboBox_Type.Text);
            }
            Close();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

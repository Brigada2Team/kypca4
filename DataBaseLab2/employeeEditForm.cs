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
    public partial class EmployeeEditForm : Form
    {
        private readonly int id;
        readonly bool edit;

        public EmployeeEditForm()
        {

            InitializeComponent();

        }
        public void EmployeeEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.databaseForLabDataSet.Employee);

        }


        public EmployeeEditForm(int id, string name, int stockNum, string job, string phone, DateTime birth)
             : this()
        {
            this.stockTableAdapter.Fill(this.databaseForLabDataSet.Stock);
            edit = true;
            this.id = id;
            textBox_Name.Text = name;
            comboBox_stock.SelectedValue = stockNum;
            textBox_Job.Text = job;
            textBox_tel.Text = phone;
            dateTimePicker_birthday.Value = birth;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {

            if (edit)
            {
                employeeTableAdapter.UpdateQuery(textBox_Name.Text, Convert.ToInt32(comboBox_stock.SelectedValue), textBox_Job.Text, textBox_tel.Text, dateTimePicker_birthday.Value.ToString(), id);
            }
            else
            {
                try
                {
                    
                    employeeTableAdapter.InsertQuery(textBox_Name.Text, Convert.ToInt32(comboBox_stock.SelectedValue), textBox_Job.Text, textBox_tel.Text, dateTimePicker_birthday.Value.ToString());
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

        private void EmployeeEditForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Stock". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseForLabDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.databaseForLabDataSet.Employee);

        }
    }
}

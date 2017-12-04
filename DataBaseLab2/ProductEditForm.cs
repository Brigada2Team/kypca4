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
        /// <summary>
        /// Id студента
        /// </summary>
        private readonly string name;
        /// <summary>
        /// true - если запись модифицируется, false - если создаѐтся новая
        /// </summary>
        readonly bool edit;
        /// <summary>
        /// конструктор формы, для создания новой записи
        /// </summary>
        public ProductEditForm()
        {
            InitializeComponent();
            edit = false;
        }

        public void ProductEditForm_Load(object sender, EventArgs e)
        {
            productTableAdapter.Fill(databaseForLabDataSet.Product);
        }
        /// <summary>
        /// конструктор формы, для модификации уже существующей записи
        /// </summary>
        /// <param name="name">ФИО</param>
        /// <param name="colonizeDate">Дата заселения</param>
        /// <param name="gender">Пол</param>
        /// <param name="address">Адрес</param>
        /// <param name="group">Группа</param>
        /// <param name="benefitCode">Тип льготы</param>
        /// <param name="passport">Паспорт</param>
        /// <param name="roomNumber">Номер комнаты</param>
        /// <param name="id">ID студента</param>
        public ProductEditForm(string name, string unit, decimal cost, string type)
         : this()
        {
            edit = true;
            this.name = name;
            textBox_Name.Text = name;
            comboBox_Unit.SelectedItem = unit;
            textBox_UnitCost.Text = cost.ToString();
            textBox_Type.Text = type;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {

            if (edit)
            {
                productTableAdapter.UpdateQuery(textBox_Name.Text, comboBox_Unit.Text, Convert.ToDecimal(textBox_UnitCost.Text),
                textBox_Type.Text,textBox_Name.Text);
            }
            else
            {
                productTableAdapter.Insert(textBox_Name.Text, comboBox_Unit.Text, Convert.ToDouble(textBox_UnitCost.Text),
               textBox_Type.Text);
            }
            Close();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

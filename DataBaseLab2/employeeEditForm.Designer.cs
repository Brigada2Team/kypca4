﻿namespace DataBaseLab2
{
    partial class EmployeeEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox_stock = new System.Windows.Forms.ComboBox();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseForLabDataSet = new DataBaseLab2.DatabaseForLabDataSet();
            this.textBox_Job = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.EmployeeTableAdapter();
            this.stockTableAdapter = new DataBaseLab2.DatabaseForLabDataSetTableAdapters.StockTableAdapter();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseForLabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(12, 142);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(111, 23);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "Сохранить";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(192, 6);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(121, 20);
            this.textBox_Name.TabIndex = 4;
            // 
            // comboBox_stock
            // 
            this.comboBox_stock.DataSource = this.stockBindingSource;
            this.comboBox_stock.DisplayMember = "Num";
            this.comboBox_stock.FormattingEnabled = true;
            this.comboBox_stock.Location = new System.Drawing.Point(192, 32);
            this.comboBox_stock.Name = "comboBox_stock";
            this.comboBox_stock.Size = new System.Drawing.Size(121, 21);
            this.comboBox_stock.TabIndex = 5;
            this.comboBox_stock.ValueMember = "Num";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.databaseForLabDataSet;
            // 
            // databaseForLabDataSet
            // 
            this.databaseForLabDataSet.DataSetName = "DatabaseForLabDataSet";
            this.databaseForLabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_Job
            // 
            this.textBox_Job.Location = new System.Drawing.Point(192, 59);
            this.textBox_Job.Name = "textBox_Job";
            this.textBox_Job.Size = new System.Drawing.Size(121, 20);
            this.textBox_Job.TabIndex = 6;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(192, 85);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(121, 20);
            this.textBox_tel.TabIndex = 7;
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(192, 112);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker_birthday.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Склад";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата рождения";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.databaseForLabDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(192, 142);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(121, 23);
            this.button_Cancel.TabIndex = 13;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Должность";
            // 
            // EmployeeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_birthday);
            this.Controls.Add(this.textBox_tel);
            this.Controls.Add(this.textBox_Job);
            this.Controls.Add(this.comboBox_stock);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_OK);
            this.Name = "EmployeeEditForm";
            this.Text = "employeeEditForm";
            this.Load += new System.EventHandler(this.EmployeeEditForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseForLabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_stock;
        private System.Windows.Forms.TextBox textBox_Job;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DatabaseForLabDataSet databaseForLabDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DatabaseForLabDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private DatabaseForLabDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
    }
}
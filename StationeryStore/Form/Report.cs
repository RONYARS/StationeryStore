using StationeryStore.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStore
{
    public partial class Report : Form
    {
        SQLRequest requestSQL = new SQLRequest();
        ModelData modeldata = new ModelData();
        int accessLevel;
        string ContextTable = "";
        string query;
        string[] NameTables = { "Должность", "Касса", "ЛичныеДанныеСотрудника", "РабочиеДанныеСотрудника", "Поставка", "Поставщик", "Продажа", "Магазин", "Склад", "СоставПоставки", "СоставПродажи", "ТипТовара", "Товар" };
        public Report(int AccessLevel)
        {
            InitializeComponent();
            accessLevel = AccessLevel;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            comboBoxTable.Items.AddRange(NameTables);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTable.Text == "")
            {
                MessageBox.Show("Пустое поле в разделе <Выбор таблицы из БД>, необходимо выбрать таблицу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBoxLeft.Items.Clear();
                listBoxLeft.Items.AddRange(modeldata.AllDictionary[ContextTable]["Fields"]);
            }
        }
        private string makeRequest()
        {
            query = "";
            query += "SELECT ";
            for (int i = 0; i < listBoxLeft.Items.Count; i++)
            {
                query += listBoxLeft.Items[i].ToString() + ",";
            }
            query = query.Remove(query.Length - 1);
            query += $" FROM {ContextTable}";
            //if (checkBoxSorted.Checked)
            //{
            //    switch (comboBoxFilter.Text)
            //    {
            //        case "Алфавитный":
            //            query += " Order by " + comboBoxSortedFilds.Text;
            //            return query;
            //        case "Обратный алфавитный":
            //            query += " Order by " + comboBoxSortedFilds.Text + " DESC";
            //            return query;
            //        case "В порядке возрастания":
            //            query += " Order by " + comboBoxSortedFilds.Text;
            //            return query;
            //        case "В порядке убывания":
            //            query += " Order by " + comboBoxSortedFilds.Text + " DESC";
            //            return query;
            //    }
            //}
            //else
            //{
            //    return query;
            //}
            //return query;
            RadioButton[] ArrayControl = { this.groupBox3.Controls.OfType<RadioButton>() };
        }
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            buttonExcel.Enabled = true;
            buttonWord.Enabled = true;
            SQLRequest requestSQL = new SQLRequest();
            requestSQL.UnikalRequest(ref dataGridView1, makeRequest());
        }
    }
    
}

using StationeryStore.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace StationeryStore
{
    public partial class FormMain : Form
    {
        SQLRequest requestSQL = new SQLRequest();
        ModelData modeldata = new ModelData();
        int accessLevel;
        string ContextTable="";
        private void VisibleControlOff()
        {
            foreach (Control ctrl in this.groupBox1.Controls) 
            ctrl.Visible = false;
            menuStrip1.Visible = true;
            CleartextBox();
        }
        private void CleartextBox()
        {
            foreach (Control ctrl in this.groupBox1.Controls.OfType<TextBox>())
            {
                ctrl.Text = "";
            }

        }

        private void VisibleControl()
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            dataGridView1.Visible = true;
            foreach (Control ctrl in this.Controls.OfType<Button>()) ctrl.Visible = true;
            for (int i = 1; i < modeldata.AllDictionary[ContextTable]["Header"].Length + 1; i++)
            {
                if (groupBox1.Controls[$"label{i}"] is Label)
                {
                    Label label = (Label)groupBox1.Controls[$"label{i}"];
                    label.Text = modeldata.AllDictionary[ContextTable]["Header"][i - 1];
                    label.Visible = true;
                }

                if (groupBox1.Controls[$"textBox{i}"] is TextBox)
                {
                    TextBox textBox = (TextBox)groupBox1.Controls[$"textBox{i}"];
                    textBox.Visible = true;
                }
            }
        }
        private void DataGridUpdate()
        {
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary[ContextTable]["Header"]);
        }

        public FormMain(int AccessLevel)
        {
            InitializeComponent();
            accessLevel = AccessLevel;
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleControlOff();
            ContextTable = modeldata.AllDictionary["Товар"]["TableName"][0];
            VisibleControl();
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary["Товар"]["Header"]);
        }

        private void TypeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleControlOff();
            ContextTable = modeldata.AllDictionary["ТипТовара"]["TableName"][0];
            VisibleControl();
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary["ТипТовара"]["Header"]);
        }

        private void PostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleControlOff();
            ContextTable = modeldata.AllDictionary["Должность"]["TableName"][0];
            VisibleControl();
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary["Должность"]["Header"]);
        }

        private void ProviderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleControlOff();
            ContextTable = modeldata.AllDictionary["Поставщик"]["TableName"][0];
            VisibleControl();
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary["Поставщик"]["Header"]);
        }

        private void EmployeePersonalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleControlOff();
            ContextTable = modeldata.AllDictionary["ЛичныеДанныеСотрудника"]["TableName"][0];
            VisibleControl();
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary["ЛичныеДанныеСотрудника"]["Header"]);
        }

        private void EmployeeWorkDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleControlOff();
            ContextTable = modeldata.AllDictionary["РабочиеДанныеСотрудника"]["TableName"][0];
            VisibleControl();
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary["РабочиеДанныеСотрудника"]["Header"]);
        }

        private void SaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleControlOff();
            ContextTable = modeldata.AllDictionary["Продажа"]["TableName"][0];
            VisibleControl();
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary["Продажа"]["Header"]);
        }

        private void CompositionSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleControlOff();
            ContextTable = modeldata.AllDictionary["СоставПродажи"]["TableName"][0];
            VisibleControl();
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary["СоставПродажи"]["Header"]);
        }

        private void SupplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleControlOff();
            ContextTable = modeldata.AllDictionary["Поставка"]["TableName"][0];
            VisibleControl();
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary["Поставка"]["Header"]);
        }

        private void ScopeSupplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleControlOff();
            ContextTable = modeldata.AllDictionary["СоставПоставки"]["TableName"][0];
            VisibleControl();
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary["СоставПоставки"]["Header"]);
        }

        private void ShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleControlOff();
            ContextTable = modeldata.AllDictionary["Магазин"]["TableName"][0];
            VisibleControl();
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary["Магазин"]["Header"]);
        }
        private void CashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleControlOff();
            ContextTable = modeldata.AllDictionary["Касса"]["TableName"][0];
            VisibleControl();
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary["Касса"]["Header"]);
        }

        private void StockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleControlOff();
            ContextTable = modeldata.AllDictionary["Склад"]["TableName"][0];
            VisibleControl();
            requestSQL.LoadDataGrid(ref dataGridView1, ContextTable, modeldata.AllDictionary["Склад"]["Header"]);
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            string[] values = new string[dataGridView1.ColumnCount-1];
            int i = 0;
            int temp = 0;
            SortControls();
            foreach (Control ctrl in groupBox1.Controls.OfType<TextBox>())
            {
                if (i > 8)
                {
                    break;
                }
                if (temp == 0)
                {
                    temp++;
                }
                else
                {
                    if (i>= dataGridView1.ColumnCount-1 || ctrl.Text=="")
                    {
                        break;
                    }
                    else
                    {
                        values[i] = ctrl.Text;
                        i++;
                    }
                }
            }

            requestSQL.InsertSql(ContextTable, modeldata.AllDictionary[ContextTable]["Fields"], values);
            MessageBox.Show("Данные Успешно добавлены!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void SortControls()
        {
            Control[] controls = groupBox1.Controls.OfType<Control>().ToArray();
            Array.Sort(controls, (a, b) => a.TabIndex.CompareTo(b.TabIndex));
            groupBox1.Controls.Clear();
            groupBox1.Controls.AddRange(controls);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cells = 0;
            int Num = dataGridView1.CurrentCell.RowIndex;
            if (e.RowIndex != -1)
            {
              foreach (TextBox textBox in groupBox1.Controls.OfType<TextBox>())
                {
                    SortControls();
                    if (cells >= dataGridView1.ColumnCount)
                    {
                        break;
                    }
                    textBox.Text = dataGridView1.Rows[Num].Cells[cells].Value.ToString();
                    cells++;
                }
            }
        }

        private void BtChange_Click(object sender, EventArgs e)
        {
            string[] values = new string[dataGridView1.ColumnCount - 1];
            int i = 0;
            int temp = 0;
            SortControls();
            foreach (Control ctrl in groupBox1.Controls.OfType<TextBox>())
            {
                if (i > 8)
                {
                    break;
                }
                if (temp == 0)
                {
                    temp++;
                }
                else
                {
                    if (i >= dataGridView1.ColumnCount - 1 || ctrl.Text == "")
                    {
                        break;
                    }
                    else
                    {
                        values[i] = ctrl.Text;
                        i++;
                    }
                }
            }

            requestSQL.ChangeSQL(ContextTable,textBox1.Text, modeldata.AllDictionary[ContextTable]["FieldsCode"][0], modeldata.AllDictionary[ContextTable]["Fields"], values);
            MessageBox.Show("Данные успешно добавлены!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in groupBox1.Controls.OfType<TextBox>())
            {
                ctrl.Text = "";
            }
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (accessLevel == 3)
            {
                MessageBox.Show("К сожалению, у вас нет прав на удаление данных", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBox1.Text;
                requestSQL.RemoveSQL(ContextTable, code, modeldata.AllDictionary[ContextTable]["FieldsCode"][0]);
                MessageBox.Show("Данные успешно удалены!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
        }

        private void ОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report(accessLevel);
            report.Show();
        }
    }
}

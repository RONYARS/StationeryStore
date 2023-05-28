using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStore
{
    public partial class Authorization : Form
    {
        private OleDbConnection connection = new OleDbConnection(Connect.ConnectionString);
        DataSet dataSet = new DataSet();
        SQLRequest sQLRequest = new SQLRequest();
        public Authorization()
        {
            InitializeComponent();
            TbPassword.PasswordChar = '*';
        }

        private void BtEnter_Click(object sender, EventArgs e)
        {
            string pass = TbPassword.Text;
            string log = CmEmployeeCode.Text;
            string query = $"Select [КодДолжности], [Пароль]  From [Авторизация] WHERE [КодДолжности] = {log} AND [Пароль] = '{pass}'";

            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, Connect.ConnectionString);
            dataAdapter.Fill(dataSet);
            OleDbDataReader reader = command.ExecuteReader();
            int AccessLevel = 1;
            reader.Read();
            if (!reader.HasRows)
            {
                MessageBox.Show("К сожалению, вход не удался. Неверный код работника или пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                switch (reader.GetValue(0))
                {
                    case "16":
                        AccessLevel = 1;//Продавец кассир
                        break;
                    case "13":
                        AccessLevel = 2;//Менеджер
                        break;
                    case "12":
                        AccessLevel = 3;//админ
                        break;
                    default:
                        AccessLevel = 1;
                        break;
                }

                if (dataSet.Tables.Count == 1)
                {
                    this.Hide();
                    FormMain formMain = new FormMain(AccessLevel);
                    formMain.ShowDialog();
                    this.Close();
                }
            }
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            connection.Open();
            sQLRequest.LoadComboBox(ref CmEmployeeCode, "КодДолжности", "Авторизация");
        }
    }
}

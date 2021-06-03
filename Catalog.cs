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
using System.IO;

namespace CarShop
{
    public partial class Catalog : Form
    {
        private readonly Settings Settings = new Settings();
        User ActualAccount;
        string Connection;
        AutorisationWindow Autorisation;
        public Catalog(AutorisationWindow aw, User ThisUser)
        {
            InitializeComponent();
            Settings = new Settings();
            Connection = Settings.ReadSettingSqlConnection();
            Autorisation = aw;
            ActualAccount = ThisUser;
            loadDataInTable();

        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            TableCar.ContextMenuStrip = contextMenuCarTable;
            
        }

        private void loadDataInTable()
        {

            if (ActualAccount.GetPrivilege() == "1" || ActualAccount.GetPrivilege() == "2")
            {
                добавитьToolStripMenuItem.Visible = true;
                delRecord.Visible = true;
                updRecord.Visible = true;
            }
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                string command = "select * from make";
                SqlCommand command1 = new SqlCommand(command, connection);
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    Make.Items.Add(reader.GetValue(1));
                }

            }
            string select = @"select Name_Make as 'Марка', model as 'Модель', Year_car as 'Дата производства', V_Engine as 'Объём двигателя (л)', Power_Engine as 'Мощность двигателя (л. с.)', Price as 'Цена', car.id from car, make
where ID_Make = make.ID";
            ConnectAndLoadFromSql(select);
        }

        private void ConnectAndLoadFromSql(string select)
        {
            TableCar.Refresh();
            
            using (SqlConnection connect = new SqlConnection(Connection))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(select, connect);

                SqlDataAdapter adapter = new SqlDataAdapter(select, connect);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                TableCar.DataSource = ds.Tables[0];
                TableCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                TableCar.Columns[TableCar.ColumnCount - 1].Visible = false;
                //MessageBox.Show(TableCar.Columns.Count.ToString());
            }
        }

        private void добавитьОбъявлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddCar newCar = new AddCar();
            newCar.ShowDialog();
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadDataInTable();
        }

        private void TableCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowCar car = new ShowCar(TableCar.SelectedRows[0].Cells[6].Value.ToString());
            car.ShowDialog();
        }

        private void Catalog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Autorisation.Show();
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void delRecord_Click(object sender, EventArgs e)
        {

            var msgBox = MessageBox.Show(
$@"Вы уверены, что хотите удалить эту запись?
{TableCar.SelectedRows[0].Cells[0].Value} {TableCar.SelectedRows[0].Cells[1].Value}",
                "System",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (msgBox == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(Connection))
                {
                    connection.Open();
                    string delete = $@"delete car  where id = {TableCar.SelectedRows[0].Cells[6].Value.ToString()} ";
                    SqlCommand command = new SqlCommand(delete, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись удалена!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataInTable();
                }
            }

            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void updRecord_Click(object sender, EventArgs e)
        {
            UpdateCar update = new UpdateCar(TableCar.SelectedRows[0].Cells[6].Value.ToString());
            update.ShowDialog();
        }

        private void TableCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedIndexMake = "1";
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                string select1 = $@"select id from make where name_make = '{Make.Text}'";
                SqlCommand command = new SqlCommand(select1, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SelectedIndexMake = reader.GetInt32(0).ToString();
                }
            }

            CheckFieldSearch();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void CheckFieldSearch()
        {
            //заполнена марка
            if (Make.Text != "" && MaxPrice.Text == "" && MinPrice.Text == "")
            {
                string select = $@"select Name_Make as 'Марка', model as 'Модель', Year_car as 'Дата производства', V_Engine as 'Объём двигателя (л)', Power_Engine as 'Мощность двигателя (л. с.)', Price as 'Цена', car.id from car, make
where ID_Make = make.ID and name_make = '{Make.Text}'";
                ConnectAndLoadFromSql(select);
            }
            //Заполнена мин цена
            if (Make.Text == "" && MaxPrice.Text == "" && MinPrice.Text != "")
            {
                string select = $@"select Name_Make as 'Марка', model as 'Модель', Year_car as 'Дата производства', V_Engine as 'Объём двигателя (л)', Power_Engine as 'Мощность двигателя (л. с.)', Price as 'Цена', car.id from car, make
where ID_Make = make.ID and Price>={MinPrice.Text}";
                ConnectAndLoadFromSql(select);
            }
            //Заполнены марка и мин цена
            if (Make.Text != "" && MaxPrice.Text == "" && MinPrice.Text != "")
            {
                string select = $@"select Name_Make as 'Марка', model as 'Модель', Year_car as 'Дата производства', V_Engine as 'Объём двигателя (л)', Power_Engine as 'Мощность двигателя (л. с.)', Price as 'Цена', car.id from car, make
where ID_Make = make.ID and Price>={MinPrice.Text} and name_make = '{Make.Text}'";
                ConnectAndLoadFromSql(select);
            }
            //заполнены марка и макс цена 
            if (Make.Text != "" && MaxPrice.Text != "" && MinPrice.Text == "")
            {
                string select = $@"select Name_Make as 'Марка', model as 'Модель', Year_car as 'Дата производства', V_Engine as 'Объём двигателя (л)', Power_Engine as 'Мощность двигателя (л. с.)', Price as 'Цена', car.id from car, make
where ID_Make = make.ID and Price<={MaxPrice.Text} and name_make = '{Make.Text}'";
                ConnectAndLoadFromSql(select);
            }
            //заполнена макс цена
            if (Make.Text == "" && MaxPrice.Text != "" && MinPrice.Text == "")
            {
                string select = $@"select Name_Make as 'Марка', model as 'Модель', Year_car as 'Дата производства', V_Engine as 'Объём двигателя (л)', Power_Engine as 'Мощность двигателя (л. с.)', Price as 'Цена', car.id from car, make
where ID_Make = make.ID and Price<={MaxPrice.Text}";
                ConnectAndLoadFromSql(select);
            }
            //заполнены мин и макс
            if (Make.Text == "" && MaxPrice.Text != "" && MinPrice.Text != "")
            {
                string select = $@"select Name_Make as 'Марка', model as 'Модель', Year_car as 'Дата производства', V_Engine as 'Объём двигателя (л)', Power_Engine as 'Мощность двигателя (л. с.)', Price as 'Цена', car.id from car, make
where ID_Make = make.ID and Price>={MinPrice.Text} and Price<={MaxPrice.Text}";
                ConnectAndLoadFromSql(select);
            }
            //заполнены все поля
            if (Make.Text != "" && MaxPrice.Text != "" && MinPrice.Text != "")
            {
                string select = $@"select Name_Make as 'Марка', model as 'Модель', Year_car as 'Дата производства', V_Engine as 'Объём двигателя (л)', Power_Engine as 'Мощность двигателя (л. с.)', Price as 'Цена', car.id from car, make
where ID_Make = make.ID and Price>={MinPrice.Text} and name_make = '{Make.Text}' and Price<={MaxPrice.Text}";
                ConnectAndLoadFromSql(select);
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckFieldSearch();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void MaxPrice_TextChanged(object sender, EventArgs e)
        {
            CheckFieldSearch();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создана студентом группы ИВТ-91з\n Малахов С. В.\n Версия программы v0.098a", "О программе");
        }
    }
}

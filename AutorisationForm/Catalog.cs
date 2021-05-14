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

namespace AutorisationForm
{
    public partial class Catalog : Form
    {

        string Connection = "Data Source=sql1C;Initial Catalog=DBforMyProgram;Integrated Security=True";
        AutorisationWindow Autorisation;
        public Catalog(AutorisationWindow aw)
        {
            InitializeComponent();
            loadDataInTable();
            Autorisation = aw;
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            TableCar.ContextMenuStrip = contextMenuCarTable;
            
        }




        private void loadDataInTable()
        {
            TableCar.Refresh();
            string select = @"select Name_Make as 'Марка', model as 'Модель', Year_car as 'Дата производства', V_Engine as 'Мощность двигателя', Price as 'Цена', car.id from car, make
where ID_Make = make.ID";
            using (SqlConnection connect = new SqlConnection(Connection))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(select, connect);
                /*SqlDataReader reader = command.ExecuteReader();
                DataSet data = ;
                while (reader.Read())
                {
                    
                }*/
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
            ShowCar car = new ShowCar(TableCar.SelectedRows[0].Cells[5].Value.ToString());
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
                    string delete = $@"delete car  where id = {TableCar.SelectedRows[0].Cells[5].Value.ToString()} ";
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
            UpdateCar update = new UpdateCar(TableCar.SelectedRows[0].Cells[5].Value.ToString());
            update.ShowDialog();
        }
    }
}

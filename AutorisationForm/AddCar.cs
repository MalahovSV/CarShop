using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutorisationForm
{
    public partial class AddCar : Form
    {
        private readonly Settings Settings = new Settings();
        string ConnectionString;
        int SelectedIndexMake = 0;
        public AddCar()
        {
            InitializeComponent();
            ConnectionString = Settings.ReadSettingSqlConnection();
        }


        private async Task SaveFileToDatabaseAsync()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO car VALUES (@Model, @Price, @ID_Make, @Year_car, @V_engine, @About, @Image_car)";
                command.Parameters.Add("@Model", SqlDbType.NVarChar);
                command.Parameters.Add("@Price", SqlDbType.NVarChar);
                command.Parameters.Add("@ID_Make", SqlDbType.Int);
                command.Parameters.Add("@Year_car", SqlDbType.Date);
                command.Parameters.Add("@V_engine", SqlDbType.Decimal);
                command.Parameters.Add("@About", SqlDbType.Text);            


                // массив для хранения бинарных данных файла
                byte[] imageData;
                using (FileStream fs = new FileStream(SelectImage.Text, FileMode.Open))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, imageData.Length);
                    command.Parameters.Add("@Image_car", SqlDbType.Image, Convert.ToInt32(imageData.Length));
                }
                // передаем данные в команду через параметры
                command.Parameters["@Model"].Value = Model.Text;
                command.Parameters["@Price"].Value = Price.Text;
                command.Parameters["@ID_Make"].Value = SelectedIndexMake;
                command.Parameters["@Year_car"].Value = dateTimePicker1.Value;
                command.Parameters["@V_engine"].Value = VEngine.Text;
                command.Parameters["@About"].Value = richTextBox1.Text;
                command.Parameters["@Image_car"].Value = imageData;

                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Файл сохранен");
            }
        }

        

        private void AddCar_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string command = "select * from make";
                SqlCommand command1 = new SqlCommand(command, connection);
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    Make.Items.Add(reader.GetValue(1));
                }
                Make.SelectedIndex = 0;
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (CheckToCorrectDecimal(Price, "Цена")) 
            {
                if (CheckToCorrectDecimal(VEngine, "Объём двигателя"))
                {
                    await SaveFileToDatabaseAsync();
                }
            }
        }


        /// <summary>
        /// Проверка поля на корректность типа данных
        /// </summary>
        /// <param name="box">Текстовое поле</param>
        /// <param name="nameBox">Имя текстового поля</param>
        /// <returns></returns>
        private bool CheckToCorrectDecimal(TextBox box, string nameBox)
        {
            try
            {
                box.Text = box.Text.Replace(".", ",");
                Convert.ToDecimal(box.Text);
                return true;
            }
            catch 
            {
                MessageBox.Show($@"Поле '{nameBox}' имеет неверный формат.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OpenImageDialog.ShowDialog() == DialogResult.Cancel)
                return;
            SelectImage.Text = OpenImageDialog.FileName;
            FileStream file = File.Open(SelectImage.Text, FileMode.Open);
            pictureBox1.Image = Image.FromStream(file);
            file.Close();
        }

        private void Make_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string select = $@"select id from make where name_make = '{Make.Text}'";
                SqlCommand command = new SqlCommand(select, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SelectedIndexMake = reader.GetInt32(0);
                }
            }
        }
    }
}

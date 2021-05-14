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

namespace CarShop
{
    public partial class ShowCar : Form
    {
        private readonly Settings settings = new Settings();
        private string ConnectionString;
        public string IDCar;
        public ShowCar(string id)
        {
            InitializeComponent();
            IDCar = id;
            ConnectionString = settings.ReadSettingSqlConnection();
            LoadData();
        }
        byte[] ImageCar;
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string select = $@"select Name_Make, Model, Car.Year_car, Car.Price, Car.V_Engine, Car.About, Car.Image_car from Make, Car
where Car.ID_Make = Make.ID and Car.ID = {IDCar}";
                SqlCommand command = new SqlCommand(select, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MakeCar.Text = reader.GetString(0);
                    NameCar.Text = reader.GetString(1);
                    DateTime TEMP = reader.GetDateTime(2);
                    DateCar.Text = $@"{TEMP.Day}.{TEMP.Month}.{TEMP.Year}";
                    PriceCar.Text = reader.GetDecimal(3).ToString();
                    VEngineCar.Text = reader.GetDecimal(4).ToString();
                    comments.Text = reader.GetString(5);
                    
                    ImageCar = (byte[])reader.GetValue(6);
                    Stream stream = new MemoryStream(ImageCar);
                    var bitmap = new Bitmap(stream);
                    pictureBox1.Image = bitmap; 
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PriceCar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ShowCar_Load(object sender, EventArgs e)
        {

        }
    }
}

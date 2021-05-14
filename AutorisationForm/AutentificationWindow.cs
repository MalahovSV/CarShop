using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace CarShop
{
    public partial class AutorisationWindow : Form
    {
        private readonly Settings Settings = new Settings();

        string Connection;

        protected List<User> Users { get; } = new List<User>();

        public AutorisationWindow()
        {
            InitializeComponent();
            Settings = new Settings();
            Connection = Settings.ReadSettingSqlConnection();
        }
        private void AutorisationButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (CheckPassword())
                {
                    Catalog catalogForm = new Catalog(this);
                    catalogForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Логин или пароль не верны.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                var msg = MessageBox.Show($"{ex.Message} \nОткрыть окно соединения с SQL-сервер?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (msg == DialogResult.Yes)
                {
                    ConnectToSql connect = new ConnectToSql();
                    connect.ShowDialog();
                }
            }
        }

    private bool CheckPassword()
        {
            string select = "select * from actor";
            using (SqlConnection connect = new SqlConnection(Connection))
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand(select, connect);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader[2].ToString() == LoginBox.Text)
                        {
                            if (reader[3].ToString() == PasswordBox.Text)
                            {
                                Users.Add(new User(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));
                                return true;
                            }
                        }
                    }
                    return false;
                }    
            
        }     
        private void AutorisationWindow_Load(object sender, EventArgs e)
        {
           
        }

        private void ShowPasswordCheck_Click(object sender, EventArgs e)
        {
            if (ShowPasswordCheck.Checked is true)
            {
                PasswordBox.PasswordChar = (char)0;
            }
            else
            {
                PasswordBox.PasswordChar = '*';
            }
        }

        private void AutorisationButton_MouseEnter(object sender, EventArgs e)
        {
            AutorisationButton.ForeColor = Settings.MouseEnter();
        }

        private void AutorisationButton_MouseLeave(object sender, EventArgs e)
        {
            AutorisationButton.ForeColor = Settings.MouseLeave();
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseWindow_MouseEnter(object sender, EventArgs e)
        {
            CloseWindow.ForeColor = Settings.MouseEnterClosed();
        }

        private void CloseWindow_MouseLeave(object sender, EventArgs e)
        {
            CloseWindow.ForeColor = Settings.MouseLeave();
        }

        private void ShowPasswordCheck_MouseEnter(object sender, EventArgs e)
        {
            ShowPasswordCheck.ForeColor = Settings.MouseEnter();
        }

        private void ShowPasswordCheck_MouseLeave(object sender, EventArgs e)
        {
            ShowPasswordCheck.ForeColor = Settings.MouseLeave();
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            ConnectionLink.LinkColor = Settings.MouseEnter();
        }



        private void ConnectionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConnectToSql connect = new ConnectToSql();
            connect.ShowDialog();

        }

        private void ConnectionLink_MouseLeave(object sender, EventArgs e)
        {
            ConnectionLink.LinkColor = Settings.MouseLeave();
        }
    }

    public class User
    {
        private string Id { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }
        private string Name { get; set; }

        /// <summary>
        /// Конструктор присваивания значений полям класса User
        /// </summary>
        /// <param name="Id">Идентификатор</param>
        /// <param name="Login">Логин</param>
        /// <param name="Password">Пароль</param>
        /// <param name="Name">Имя пользователя</param>
        public User(string Id, string Login, string Password, string Name)
        {
            this.Id = Id;
            this.Login = Login;
            this.Password = Password;
            this.Name = Name;
        }
        /// <summary>
        /// Возвращение списка данных о пользователе (id, логин, пароль, имя)
        /// </summary>
        /// <returns>Список</returns>
        public List<string> GetUserData()
        {
            List<string> user = new List<string>
            {
                this.Id,
                this.Login,
                this.Password,
                this.Name
            };
            return user;
        }
        /// <summary>
        /// Возвращение Id
        /// </summary>
        /// <returns>ID</returns>
        public string GetId()
        {
            return this.Id;
        }
        /// <summary>
        /// Возвращение логина
        /// </summary>
        /// <returns>Логин</returns>
        public string GetLogin()
        {
            return this.Login;
        }
        /// <summary>
        /// Возвращение пароля
        /// </summary>
        /// <returns>Пароль</returns>
        public string GetPassword()
        {
            return this.Password;
        }
        /// <summary>
        /// Возвращение имени пользователя
        /// </summary>
        /// <returns>Имя</returns>
        public string GetName()
        {
            return this.Name;
        }
    }
}

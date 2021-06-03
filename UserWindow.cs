using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop
{
    public partial class UserWindow : UserControl
    {
        private readonly Settings Settings = new Settings();
        protected List<User> Users { get; } = new List<User>();
        string Connection;
        AutorisationWindow AW;
        public UserWindow(AutorisationWindow WindowOfAutorisation)
        {
            InitializeComponent();
            Settings = new Settings();
            Connection = Settings.ReadSettingSqlConnection();
            AW = WindowOfAutorisation;
        }

        private void AutorisationButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (CheckPassword())
                {
                    Catalog catalogForm = new Catalog(AW, Users[0]);
                    catalogForm.Show();
                    AW.Hide();
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
                        if (Encryption.Decoding(reader[3].ToString(), "Пиу-Пиу") == PasswordBox.Text)
                        {
                            Users.Add(new User(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[6].ToString()));
                            return true;
                        }
                    }
                }
                return false;
            }

        }

        private void ShowPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheck.Checked is true)
            {
                PasswordBox.PasswordChar = (char)0;
            }
            else
            {
                PasswordBox.PasswordChar = '•';
            }
        }

        private void ConnectionLink_MouseLeave(object sender, EventArgs e)
        {
            ConnectionLink.LinkColor = Settings.MouseLeave();
        }

        private void ConnectionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConnectToSql connect = new ConnectToSql();
            connect.ShowDialog();
        }

        private void ConnectionLink_MouseEnter(object sender, EventArgs e)
        {
            ConnectionLink.LinkColor = Settings.MouseEnter();
        }

        private void ShowPasswordCheck_MouseLeave(object sender, EventArgs e)
        {
            ShowPasswordCheck.ForeColor = Settings.MouseLeave();
        }

        private void ShowPasswordCheck_MouseEnter(object sender, EventArgs e)
        {
            ShowPasswordCheck.ForeColor = Settings.MouseEnter();
        }

        private void AutorisationButton_MouseLeave(object sender, EventArgs e)
        {
            AutorisationButton.ForeColor = Settings.MouseLeave();
        }

        private void AutorisationButton_MouseEnter(object sender, EventArgs e)
        {
            AutorisationButton.ForeColor = Settings.MouseEnter();
        }
    }
}

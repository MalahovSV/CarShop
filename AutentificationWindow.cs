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
            FirstLoad();
            
        }

        private void FirstLoad()
        {
            FramePanel.Controls.Add(new UserWindow(this));
            VariableUser.Text = "Я клиент";
        }
        private void AutorisationButton_Click(object sender, EventArgs e)
        {
         
        }

  
        private void AutorisationWindow_Load(object sender, EventArgs e)
        {
           
        }

        private void ShowPasswordCheck_Click(object sender, EventArgs e)
        {
           
        }

        private void AutorisationButton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void AutorisationButton_MouseLeave(object sender, EventArgs e)
        {

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

        }

        private void ShowPasswordCheck_MouseLeave(object sender, EventArgs e)
        {

        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {

        }



        private void ConnectionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void ConnectionLink_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void VariableUser_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void VariableUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(VariableUser.Text == "Я пользователь")
            {
                FramePanel.Controls.Clear();
                FramePanel.Controls.Add(new UserWindow(this));
                VariableUser.Text = "Я клиент";
            }
            else if (VariableUser.Text == "Я клиент")
            {
                FramePanel.Controls.Clear();
                FramePanel.Controls.Add(new ClientControl(this));
                VariableUser.Text = "Я пользователь";
            }
        }

        private void VariableUser_MouseLeave(object sender, EventArgs e)
        {
            VariableUser.LinkColor = Settings.MouseLeave();
        }

        private void VariableUser_MouseEnter(object sender, EventArgs e)
        {
            VariableUser.LinkColor = Settings.MouseEnter();
        }
    }
}

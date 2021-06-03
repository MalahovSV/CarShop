using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop
{
    public partial class ClientControl : UserControl
    {
        private readonly Settings Settings = new Settings();
       
        AutorisationWindow AW;
        public ClientControl(AutorisationWindow autorisationWindow)
        {
            InitializeComponent();
            AW = autorisationWindow;
        }

        private void ClientFormButton_Click(object sender, EventArgs e)
        {
            User defaultUser = new User("0", "0", "0", "0", "0");
            Catalog catalogForm = new Catalog(AW, defaultUser);
            catalogForm.Show();
            AW.Hide();
        }

        private void ClientFormButton_MouseLeave(object sender, EventArgs e) => ClientFormButton.ForeColor = Settings.MouseLeave();
        private void ClientFormButton_MouseEnter(object sender, EventArgs e) => ClientFormButton.ForeColor = Settings.MouseEnter();
    }
}

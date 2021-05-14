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
using System.Configuration;


namespace AutorisationForm
{
    public partial class ConnectToSql : Form
    {
        Settings settings = new Settings();
        public ConnectToSql()
        {
            InitializeComponent();
        }

        private void ConnectToSql_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                loginSQL.Enabled = true;
                passwordSQL.Enabled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataBases_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringBuilder.InitialCatalog = dataBases.Text;
        }
        SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stringBuilder.ConnectionString, "System", MessageBoxButtons.OK);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            loginSQL.Enabled = false;
            passwordSQL.Enabled = false;
        }


        private void dataBases_DropDown(object sender, EventArgs e)
        {
            dataBases.Items.Clear();
            stringBuilder.DataSource = nameServer.Text;
            if (radioButton1.Checked)
            {
                stringBuilder.IntegratedSecurity = true;
            }
            else
            {
                stringBuilder.UserID = loginSQL.Text;
                stringBuilder.Password = passwordSQL.Text;
            }

            using (SqlConnection sqlConn = new SqlConnection(stringBuilder.ConnectionString))
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "sp_helpdb";

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataBases.Items.Add(row["name"].ToString());
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordSQL.PasswordChar = '•';
            } else
            {
                passwordSQL.PasswordChar = (char)0;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            settings.AddUpdateAppSettings("SqlConnection", stringBuilder.ConnectionString);
        }



        
    }
}

using MetroFramework;
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
using System.Data.Sql;

namespace AutoStorage
{
    public partial class StartLogin : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public StartLogin()
        {
            InitializeComponent();
        }

        private void StartLogin_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            authorizationManagers managerlogin = new authorizationManagers();
            this.Hide();
            managerlogin.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            authorizationFinansers finanserslogin = new authorizationFinansers();
            this.Hide();
            finanserslogin.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            managerRegistr mreg = new managerRegistr();
            this.Hide();
            mreg.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            finanserRegistr freg = new finanserRegistr();
            this.Hide();
            freg.Show();
        }

        private void StartLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();

        }
    }
}

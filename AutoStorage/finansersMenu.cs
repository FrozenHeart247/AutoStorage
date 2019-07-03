using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.IO;
using System.Runtime.InteropServices;

namespace AutoStorage
{
    public partial class finansersMenu : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public finansersMenu()
        {
            InitializeComponent();
            userLoginBox.Text = authorizationFinansers.Login;
        }

        private void finansersMenu_Load(object sender, EventArgs e)
        {
            if (contentFinansersMenu.Width == 500 && contentFinansersMenu.Height == 383) // 500; 383
            {
                contentFinansersMenu.Visible = false;
                contentFinansersMenu.Width = 501;
                contentFinansersMenu.Height = 384;


                panelAnimator.Show(contentFinansersMenu);
            }
          
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Home2 h2 = new Home2();
            this.Hide();
            h2.Show();
        }

       

        private void metroTile2_Click(object sender, EventArgs e)
        {
            financerBillsLookUp fBLU = new financerBillsLookUp();
            this.Hide();
            fBLU.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            StartLogin start = new StartLogin();
            this.Hide();
            start.Show();
        }

        private void finansersMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

      
    }
}

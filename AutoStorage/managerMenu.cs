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

namespace AutoStorage
{
    public partial class managerMenu : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public managerMenu()
        {
            InitializeComponent();
            userLoginBox.Text = authorizationManagers.Login;
           
        }

        private void managerMenu_Load(object sender, EventArgs e)
        {
            if (contentManagersMenu.Width == 646 && contentManagersMenu.Height == 362) // 646; 362
            {
                contentManagersMenu.Visible = false;
                contentManagersMenu.Width = 647;
                contentManagersMenu.Height = 363;


                contentAnimator.Show(contentManagersMenu);
            }
            else
            {
                contentManagersMenu.Visible = true;
                contentManagersMenu.Width = 317;
                contentManagersMenu.Height = 228;
            }
            
        }

        private void managerMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

       

       

        private void metroTile4_Click_1(object sender, EventArgs e)
        {
            billsLookup lp = new billsLookup();
            this.Hide();
            lp.Show();
        }

        private void metroTile5_Click_1(object sender, EventArgs e)
        {

            workWithBills wbs = new workWithBills();
            this.Hide();
            wbs.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            StartLogin st = new StartLogin();
            this.Hide();
            st.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Home home= new Home();
            this.Hide();
            home.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            transpOperationPurchaseBills tOPB = new transpOperationPurchaseBills();
            this.Hide();
            tOPB.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            lookUpStorages lUS = new lookUpStorages();
            lUS.ShowDialog();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            getHelp gH = new getHelp();
            gH.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }
    }
}

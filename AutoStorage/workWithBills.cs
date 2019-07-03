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
    public partial class workWithBills : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public workWithBills()
        {
            InitializeComponent();
            userLoginBox.Text = authorizationManagers.Login;
        }

        private void workWithBills_Load(object sender, EventArgs e)
       {
           string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AutoStorage\AutoStorage\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
           sqlConnection = new SqlConnection(connectionString);
            if (contentMenu.Width == 661 && contentMenu.Height == 357) // 661; 357
            {
                contentMenu.Visible = false;
                contentMenu.Width = 662;
                contentMenu.Height = 358;


                panelAnimator.Show(contentMenu);
            }
           
        }

      
        private void backToManagersMenu_Click(object sender, EventArgs e)
        {
            managerMenu mg = new managerMenu();
            this.Hide();
            mg.Show();
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            addWayBill awb = new addWayBill();
            this.Hide();
            awb.Show();
        }

        private void metroTile3_Click_1(object sender, EventArgs e)
        {
            redactWayBills rb = new redactWayBills();
            this.Hide();
            rb.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            billsLookup bl = new billsLookup();
            this.Hide();
            bl.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            addPurchaseBill aPI = new addPurchaseBill();
            this.Hide();
            aPI.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            redactPurchaseBills rPI = new redactPurchaseBills();
            this.Hide();
            rPI.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            deleteWayBills dwb = new deleteWayBills();
            this.Hide();
            dwb.Show();
        }

        private void workWithBills_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            deletePurchaseBills dPB = new deletePurchaseBills();
            this.Hide();
            dPB.Show();
        }

       
    }
}

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
    public partial class lookUpStorages : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public lookUpStorages()
        {
            InitializeComponent();
        }

        private void lookUpStorages_Load(object sender, EventArgs e)
        {
            if (slidePanel.Width == 256 && slidePanel.Height == 381) // 256; 381
            {
                slidePanel.Visible = false;
                slidePanel.Width = 267;
                slidePanel.Height = 382;


                panelAnimator.Show(slidePanel);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Storage1 s1 = new Storage1();
            s1.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Storage2 s1 = new Storage2();
            s1.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Storage3 s3 = new Storage3();
            s3.ShowDialog();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Storage4 s4 = new Storage4();
            s4.ShowDialog();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Storage5 s5 = new Storage5();
            s5.ShowDialog();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Storage6 s6 = new Storage6();
            s6.Show();
        }

        private void lookUpStorages_MouseEnter(object sender, EventArgs e)
        {
            slidePanel.Select();
        }

       
    }
}

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
    public partial class changeFinansersPass : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public changeFinansersPass()
        {
            InitializeComponent();
        }

        private void changeFinansersPass_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AutoStorage\AutoStorage\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.OpenAsync();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Finansers where Login='" + loginBox.Text + "'and Pass='" + passBox.Text + "'", sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                changePass();
            }
            else
            {
                MetroMessageBox.Show(this, "Ошибка", "Укажите верный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void changePass() //Метод изменения пароля текщего пользователя
        {
            SqlCommand command = new SqlCommand("UPDATE [Finansers] SET Pass=@pass WHERE Login=@login", sqlConnection);
            command.Parameters.AddWithValue("pass", newPassBox.Text);
            command.Parameters.AddWithValue("login", loginBox.Text);
            command.ExecuteNonQuery();
            MetroMessageBox.Show(this, "Информация", "Пароль успешно изменен", MessageBoxButtons.OK, MessageBoxIcon.Question);

            Home2 home2 = new Home2();
            this.Hide();
            home2.Show();
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            Home2 h2 = new Home2();
            this.Hide();
            h2.Show();
        }

        private void changeFinansersPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

    }
}

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
    public partial class changeManagerPass : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public changeManagerPass()
        {
            InitializeComponent();
        }

        private async void changeManagerPass_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AutoStorage\AutoStorage\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
          
        }

        private void logInBtn_Click(object sender, EventArgs e) //проверка на корректность данных, в случае успеха изменяем пароль, вызывая метод changePass
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Managers where Login='" + loginBox.Text + "'and Pass='" + passBox.Text + "'", sqlConnection);
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
           SqlCommand command = new SqlCommand("UPDATE [Managers] SET Pass=@pass WHERE Login=@login", sqlConnection);
                command.Parameters.AddWithValue("pass", newPassBox.Text);
                command.Parameters.AddWithValue("login", loginBox.Text);
                command.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Информация", "Пароль успешно изменен", MessageBoxButtons.OK, MessageBoxIcon.Question);
             
           Home home = new Home();
                this.Hide();
                home.Show();
        }

       private void backToHomeBtn_Click(object sender, EventArgs e) //кнопка возвращающая в ЛК
       {
           Home home = new Home();
           this.Hide();
           home.Show();
       }

       private void changeManagerPass_FormClosing(object sender, FormClosingEventArgs e)
       {
           
       }

    }
}

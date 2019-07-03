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
    public partial class authorizationManagers : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public authorizationManagers()
        {

            InitializeComponent();
        }
        public static string Login;
        public static string FirstName;
        public static string SecondName;
        public static int Phone;
        public static string Email;

        //     public static string SecondName;
        private async void Authorization_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AutoStorage\AutoStorage\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
                sqlConnection = new SqlConnection(connectionString);
                await sqlConnection.OpenAsync();
            }
            catch
            {
                MetroMessageBox.Show(this, "Идет подключение, пожалуйста подождите", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Managers where Login='" + loginBox.Text + "'and Pass='" + passBox.Text + "'", sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                DialogResult result = MetroMessageBox.Show(this, "Вы успешно зашли в систему", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    SqlCommand tryGetValues = new SqlCommand("SELECT Name,SecondName,Phone,Email FROM Managers WHERE Login='" + loginBox.Text + "' ", sqlConnection);
                    SqlDataReader reader = tryGetValues.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        FirstName = reader.GetString(0);
                        SecondName = reader.GetString(1);
                        Phone = reader.GetInt32(2);
                        Email = reader.GetString(3);
                    }

                    Login = loginBox.Text;
                    //  FirstName = nameHomeBox.Text;
                    this.Hide();
                    managerMenu menuForManagers = new managerMenu();
                    menuForManagers.Show();
                    return;
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Проверьте Логин и пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registrBtn_Click(object sender, EventArgs e)
        {
            managerMenu menu = new managerMenu();
            menu.Show();
        }

        private void backtoRegistration_Click(object sender, EventArgs e)
        {
            StartLogin toAuth = new StartLogin();
            this.Hide();
            toAuth.Show();
        }

        private void authorizationManagers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void loginBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Managers where Login='" + loginBox.Text + "'and Pass='" + passBox.Text + "'", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    DialogResult result = MetroMessageBox.Show(this, "Вы успешно зашли в систему", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        SqlCommand tryGetValues = new SqlCommand("SELECT Name,SecondName,Phone,Email FROM Managers WHERE Login='" + loginBox.Text + "' ", sqlConnection);
                        SqlDataReader reader = tryGetValues.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            FirstName = reader.GetString(0);
                            SecondName = reader.GetString(1);
                            Phone = reader.GetInt32(2);
                            Email = reader.GetString(3);
                        }

                        Login = loginBox.Text;
                        //  FirstName = nameHomeBox.Text;
                        this.Hide();
                        managerMenu menuForManagers = new managerMenu();
                        menuForManagers.Show();
                        return;
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Проверьте Логин и пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void passBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Managers where Login='" + loginBox.Text + "'and Pass='" + passBox.Text + "'", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    DialogResult result = MetroMessageBox.Show(this, "Вы успешно зашли в систему", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        SqlCommand tryGetValues = new SqlCommand("SELECT Name,SecondName,Phone,Email FROM Managers WHERE Login='" + loginBox.Text + "' ", sqlConnection);
                        SqlDataReader reader = tryGetValues.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            FirstName = reader.GetString(0);
                            SecondName = reader.GetString(1);
                            Phone = reader.GetInt32(2);
                            Email = reader.GetString(3);
                        }

                        Login = loginBox.Text;
                        //  FirstName = nameHomeBox.Text;
                        this.Hide();
                        managerMenu menuForManagers = new managerMenu();
                        menuForManagers.Show();
                        return;
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Проверьте Логин и пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
 
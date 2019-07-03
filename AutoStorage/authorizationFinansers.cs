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
using MetroFramework;

namespace AutoStorage
{
    public partial class authorizationFinansers : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public authorizationFinansers()
        {
            InitializeComponent();
        }
        public static string Login;
        public static string FirstName;
        public static string SecondName;
        public static int Phone;
        public static string Email;
        private async void authorizationFinansers_Load(object sender, EventArgs e)
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
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Finansers where Login='" + loginBox.Text + "'and Pass='" + passBox.Text + "'", sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                DialogResult result = MetroMessageBox.Show(this, "Вы успешно зашли в систему", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    SqlCommand tryGetValues = new SqlCommand("SELECT Name,SecondName,Phone,Email FROM Finansers WHERE Login='" + loginBox.Text + "' ", sqlConnection);
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
                    finansersMenu menuForFinansers = new finansersMenu();
                    menuForFinansers.Show();
                    return;
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Проверьте Логин и пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backtoRegistration_Click(object sender, EventArgs e)
        {
            StartLogin toAuth = new StartLogin();
            this.Hide();
            toAuth.Show();
        }

        private void authorizationFinansers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void loginBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Finansers where Login='" + loginBox.Text + "'and Pass='" + passBox.Text + "'", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    DialogResult result = MetroMessageBox.Show(this, "Вы успешно зашли в систему", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        SqlCommand tryGetValues = new SqlCommand("SELECT Name,SecondName,Phone,Email FROM Finansers WHERE Login='" + loginBox.Text + "' ", sqlConnection);
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
                        finansersMenu menuForFinansers = new finansersMenu();
                        menuForFinansers.Show();
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
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Finansers where Login='" + loginBox.Text + "'and Pass='" + passBox.Text + "'", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    DialogResult result = MetroMessageBox.Show(this, "Вы успешно зашли в систему", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        SqlCommand tryGetValues = new SqlCommand("SELECT Name,SecondName,Phone,Email FROM Finansers WHERE Login='" + loginBox.Text + "' ", sqlConnection);
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
                        finansersMenu menuForFinansers = new finansersMenu();
                        menuForFinansers.Show();
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
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
using System.IO;


namespace AutoStorage
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        string imgLocation = "";
        SqlConnection sqlConnection;
        public Home()
        {
            InitializeComponent();
            namebox.Text = authorizationManagers.FirstName;   //Добавление значений из переменной FirstName, в namebox
            secondNameBox.Text = authorizationManagers.SecondName;
            phoneBox.Text = authorizationManagers.Phone.ToString();
            emailBox.Text = authorizationManagers.Email;
            loginBox.Text = authorizationManagers.Login;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                imgListHome.SizeMode = PictureBoxSizeMode.StretchImage;
                string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AutoStorage\AutoStorage\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                SqlCommand tryGetValues = new SqlCommand("SELECT Name,SecondName,Phone,Email FROM Managers WHERE Login='" + loginBox.Text + "' ", sqlConnection); //Запрос для "обновления полей", чтобы изменненные данные отображались
                SqlDataReader reader1 = tryGetValues.ExecuteReader();

                if (reader1.HasRows)
                {
                    int phone;
                    reader1.Read();
                    namebox.Text = reader1.GetString(0);
                    secondNameBox.Text = reader1.GetString(1);
                    phone = reader1.GetInt32(2);
                    phoneBox.Text = phone.ToString();
                    emailBox.Text = reader1.GetString(3);
                    reader1.Close();
                }
                SqlCommand getPiccommand = new SqlCommand("SELECT FacePhoto FROM Managers WHERE login='" + loginBox.Text + "'", sqlConnection); //Получение фотографии пользователя по логину.
                SqlDataReader picReader1 = getPiccommand.ExecuteReader();
                if (picReader1.Read())
                {
                    byte[] imgData1 = (byte[])picReader1[0];
                    using (MemoryStream ms = new MemoryStream(imgData1))
                    {
                        imgListHome.Image = Image.FromStream(ms);
                        picReader1.Close();
                    }


                    //       SqlCommand command = new SqlCommand("SELECT FacePhoto FROM Managers WHERE login='"+loginBox.Text+"'",sqlConnection);
                    //SqlCommand command = new SqlCommand("SELECT FacePhoto FROM Managers WHERE login='"+loginBox.Text+"'", sqlConnection);

                    ///    SqlDataReader reader = command.ExecuteReader();
                    //if (reader.Read())
                    //   {
                    //     byte[] images = (byte[])reader["FacePhoto"];
                    //        imgListHome.Image = images;

                    // Response.BinaryWrite(imgListHome);
                    
                }
            }
            catch { }
        }


        private void backToManagersMenu_Click(object sender, EventArgs e)
        {
            managerMenu mg = new managerMenu();
            this.Hide();
            mg.Show();
        }
        private void changeStatsBtn_Click(object sender, EventArgs e) //скрытие элементов, необъодимо для отображения других ф-ций.
        {
            namebox.Enabled = true;
            secondNameBox.Enabled = true;
            phoneBox.Enabled = true;
            emailBox.Enabled = true;
            changeStatsBtn.Visible = false;
            updateStatsBtn.Visible = true;
            changePassBtn.Visible = false;
            cancelUpdStatsBtn.Visible = true;

        }


        private void updateStatsBtn_Click(object sender, EventArgs e) //кнопка, вызывающая метод checkFieds
        {
            checkFields();
        }
        public void checkFields() //Проверка на заполненость поля
        {
            if (string.IsNullOrEmpty(namebox.Text) || string.IsNullOrEmpty(secondNameBox.Text) ||
                string.IsNullOrEmpty(phoneBox.Text) || string.IsNullOrEmpty(emailBox.Text))
            {
                MetroMessageBox.Show(this, "Ошибка", "Заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                updateStats();
            }
        }
        public void updateStats() //Обновление данных пользователя по логину
        {
            SqlCommand command2 = new SqlCommand("UPDATE [Managers] SET Name=@Name,SecondName=@SecondName,Phone=@Phone,Email=@Email Where Login=@login", sqlConnection);
            command2.Parameters.AddWithValue("Name", namebox.Text);
            command2.Parameters.AddWithValue("SecondName", secondNameBox.Text);
            command2.Parameters.AddWithValue("Phone", phoneBox.Text);
            command2.Parameters.AddWithValue("Email", emailBox.Text);
            command2.Parameters.AddWithValue("login", loginBox.Text);
            command2.ExecuteNonQuery();
            MetroMessageBox.Show(this, "Информация", "Данные пользователя успешно измененны", MessageBoxButtons.OK, MessageBoxIcon.Information);

            namebox.Enabled = false; //возвращение первоначальных кнопок
            secondNameBox.Enabled = false;
            phoneBox.Enabled = false;
            emailBox.Enabled = false;
            changeStatsBtn.Visible = true;
            updateStatsBtn.Visible = false;
            changePassBtn.Visible = true;
            cancelUpdStatsBtn.Visible = false;

        }
        private void cancelUpdStatsBtn_Click(object sender, EventArgs e)
        {
            namebox.Enabled = false;//возвращение первоначальных кнопок
            secondNameBox.Enabled = false;
            phoneBox.Enabled = false;
            emailBox.Enabled = false;
            changeStatsBtn.Visible = true;
            updateStatsBtn.Visible = false;
            changePassBtn.Visible = true;
            cancelUpdStatsBtn.Visible = false;

        }
        private void changePassBtn_Click(object sender, EventArgs e)
        {
            changeManagerPass cmP = new changeManagerPass();
            this.Hide();
            cmP.ShowDialog();
        }
        private void changePicBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "png files(*.png)|*.png | jpg files(*.jpg) | *.jpg| ALL files(*.*)| *.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = dialog.FileName.ToString();
                    imgListHome.ImageLocation = imgLocation;
                    imgListHome.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                byte[] images = null;
                FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Stream);
                images = brs.ReadBytes((int)Stream.Length);
                SqlCommand command3 = new SqlCommand(@"UPDATE [Managers] SET FacePhoto=@FacePhoto WHERE Login =@login", sqlConnection);
                command3.Parameters.AddWithValue("FacePhoto", images);
                command3.Parameters.AddWithValue("login", loginBox.Text);
                command3.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Информаций", "Изображение успешно измененно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }
    }
}



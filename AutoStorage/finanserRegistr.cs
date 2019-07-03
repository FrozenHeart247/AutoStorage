
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
using System.IO;

namespace AutoStorage
{
    public partial class finanserRegistr : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        string imgLocation = "";
        public finanserRegistr()
        {
            InitializeComponent();
        }

        private async void finanserRegistr_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AutoStorage\AutoStorage\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            facePicBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void backtoStartLogin_Click(object sender, EventArgs e)
        {
            StartLogin regmenu = new StartLogin();
            this.Hide();
            regmenu.Show();

        }

        private void finanserRegistr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void setFacePicBtn_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png | jpg files(*.jpg) | *.jpg| ALL files(*.*)| *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                facePicBox.ImageLocation = imgLocation;
            }
        }
        private void regFinBtn_Click(object sender, System.EventArgs e) //кнопка для добавления пользователя в бд
        {
            checkFields();
        }
        public void checkFields() //проверка на заполненность полей
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrWhiteSpace(secondNameBox.Text) || string.IsNullOrWhiteSpace(phoneBox.Text) ||
                string.IsNullOrWhiteSpace(loginBox.Text) || string.IsNullOrEmpty(mailBox.Text) || string.IsNullOrWhiteSpace(loginBox.Text) ||
                string.IsNullOrWhiteSpace(passBox.Text))
            {
                MetroMessageBox.Show(this, "Заполните все поля");
                return;
            }
            if (facePicBox.Image == null)
            {
                MetroMessageBox.Show(this, "Error", "Графический файл не загружен!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                addFinansers();
            }
        }
        
        //Доделать по человечески
        public void addFinansers() //добавление пользователя в бд
        {
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);
            SqlCommand command = new SqlCommand("INSERT INTO [Finansers] (Name,SecondName,Phone,Email,Login,Pass,FacePhoto) VALUES(@Name,@SecondName,@Phone,@Email,@Login,@pass,@FacePhoto)", sqlConnection);
            command.Parameters.AddWithValue("Name", nameBox.Text);
            command.Parameters.AddWithValue("SecondName", secondNameBox.Text);
            command.Parameters.AddWithValue("Phone", phoneBox.Text);
            command.Parameters.AddWithValue("Email", mailBox.Text);
            command.Parameters.AddWithValue("Login", loginBox.Text);
            command.Parameters.AddWithValue("Pass", passBox.Text);
            command.Parameters.AddWithValue("@FacePhoto", images);
            //подумать над именем
            DialogResult dialog = MetroMessageBox.Show(this, "Подтверждение", "Вы дейтсвительно хотите создать аккаунт?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Уведомление", "Пользователь успешно добавлен");
            }
        }

        private void exitBtn_Click(object sender, System.EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,,,\b]");
        }
     }

}





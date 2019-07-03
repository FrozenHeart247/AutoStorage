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
    public partial class Storage5 : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public Storage5()
        {
            InitializeComponent();
        }

        private void Storage5_Load(object sender, EventArgs e)
        {
            imgList.SizeMode = PictureBoxSizeMode.StretchImage;
            bunifuGradientPanel3.Select();
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AutoStorage\AutoStorage\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Storage5", sqlConnection); //Указываем номер склада
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            ///////////////////////////////
            metroGrid2.Visible = false;////
            ///////////////////////////////
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = new SqlCommand("SELECT * FROM StoragesCongestion", sqlConnection);
            da2.Fill(ds2);
            metroGrid2.DataSource = ds2.Tables[0];
            store5CongPickerBox.Text = metroGrid2.CurrentRow.Cells[5].Value.ToString(); //указываем номер склада
            metroGrid1.Columns[0].Visible = false;
            metroGrid1.Columns[17].Visible = false;
            /////////////////////////////////////////
            metroGrid1.Columns[1].HeaderText = "Отправляющая компания";
            metroGrid1.Columns[2].HeaderText = "Адрес компании";
            metroGrid1.Columns[3].HeaderText = "Город отправки";
            metroGrid1.Columns[4].HeaderText = "Телефон отправляющей компании";
            metroGrid1.Columns[5].HeaderText = "Email отправляющей компании";
            metroGrid1.Columns[6].HeaderText = "Получающая компания";
            metroGrid1.Columns[7].HeaderText = "Адрес компании";
            metroGrid1.Columns[8].HeaderText = "Город получения";
            metroGrid1.Columns[9].HeaderText = "Телефон получающей компании";
            metroGrid1.Columns[10].HeaderText = "Email получающей компании";
            metroGrid1.Columns[11].HeaderText = "Имя группы товаров";
            metroGrid1.Columns[12].HeaderText = "Вес, т";
            metroGrid1.Columns[13].HeaderText = "Кубатура";
            metroGrid1.Columns[14].HeaderText = "Тип товаров";
            metroGrid1.Columns[15].HeaderText = "Дата прибытия на склад";
            metroGrid1.Columns[16].HeaderText = "Дата отправки со склада";
            //img 17
            metroGrid1.Columns[18].HeaderText = "Цена хранения за неделю";
            metroGrid1.Columns[19].HeaderText = "Кол-во дней";
            metroGrid1.Columns[20].HeaderText = "Стоимость хранения";
            //////////////////////////////////////////
            int a = Convert.ToInt32(store5CongPickerBox.Text);
            int b = 800; //Указываем размер склада
            int c;
            c = b - a;
            congestionPG.Value = c;
            if (c >= 800) //Указываем размер склада
            {
                MetroMessageBox.Show(this, "Предупреждение", "Склад заполнен на 100%", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bunifuGradientPanel3_MouseEnter(object sender, EventArgs e)
        {
            bunifuGradientPanel3.Select();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idBox.Text = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                companyFromBox.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                fromAdresBox.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                fromCityBox.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
                fromPhoneBox.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
                fromEmailBox.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
                companyToBox.Text = metroGrid1.Rows[e.RowIndex].Cells[6].Value.ToString();
                toAdresBox.Text = metroGrid1.Rows[e.RowIndex].Cells[7].Value.ToString();
                toCityBox.Text = metroGrid1.Rows[e.RowIndex].Cells[8].Value.ToString();
                toPhoneBox.Text = metroGrid1.Rows[e.RowIndex].Cells[9].Value.ToString();
                toEmailBox.Text = metroGrid1.Rows[e.RowIndex].Cells[10].Value.ToString();
                goodsNameBox.Text = metroGrid1.Rows[e.RowIndex].Cells[11].Value.ToString();
                weightBox.Text = metroGrid1.Rows[e.RowIndex].Cells[12].Value.ToString();
                cubageBox.Text = metroGrid1.Rows[e.RowIndex].Cells[13].Value.ToString();
                goodsTypeBox.Text = metroGrid1.Rows[e.RowIndex].Cells[14].Value.ToString();
                metroDateTime1.Text = metroGrid1.Rows[e.RowIndex].Cells[15].Value.ToString();
                metroDateTime2.Text = metroGrid1.Rows[e.RowIndex].Cells[16].Value.ToString();

                imgList.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])metroGrid1.Rows[e.RowIndex].Cells[17].Value));
                keepingForWeekPriceBox.Text = metroGrid1.Rows[e.RowIndex].Cells[18].Value.ToString();
                totalDaysBox.Text = metroGrid1.Rows[e.RowIndex].Cells[19].Value.ToString();
                keepingSumBox.Text = metroGrid1.Rows[e.RowIndex].Cells[20].Value.ToString();
            }
            catch { }
        }

        private void fromStorage5Btn_Click(object sender, EventArgs e)
        {
            goFromStorage();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Storage5", sqlConnection); //Указываем номер склада
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
        }
        public void goFromStorage()
        {
            SqlCommand goFromStrg1 = new SqlCommand("UPDATE StoragesCongestion SET Storage5 = Storage5 + @cubage where id=1", sqlConnection); //Указываем номер склада
            goFromStrg1.Parameters.AddWithValue("cubage", cubageBox.Text);
            goFromStrg1.ExecuteNonQuery();

            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = new SqlCommand("SELECT * FROM StoragesCongestion", sqlConnection);
            da2.Fill(ds2);
            metroGrid2.DataSource = ds2.Tables[0];


            SqlCommand goFromStrg2 = new SqlCommand("DELETE FROM Storage5 WHERE id=@id", sqlConnection); //Указываем номер склада
            goFromStrg2.Parameters.AddWithValue("id", idBox.Text);
            goFromStrg2.ExecuteNonQuery();
            store5CongPickerBox.Text = metroGrid2.CurrentRow.Cells[5].Value.ToString(); // Указываем номер склада
            MetroMessageBox.Show(this, "Оповещение", "Накладная успешно удалена", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Storage5", sqlConnection); //Указываем номер склада
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = new SqlCommand("SELECT * FROM StoragesCongestion", sqlConnection);
            da2.Fill(ds2);
            metroGrid2.DataSource = ds2.Tables[0];
            store5CongPickerBox.Text = metroGrid2.CurrentRow.Cells[5].Value.ToString();
        }

        private void dateSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM [Storage5] WHERE (date1 LIKE '%" + dateSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void typeSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM [Storage5] WHERE (companyFrom LIKE N'%" + typeSearchBox.Text.ToString() + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void priceSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM [Storage5] WHERE (keepingSumBox LIKE '%" + priceSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

       

    }
}

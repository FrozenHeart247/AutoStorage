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
    public partial class deletePurchaseBills : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public deletePurchaseBills()
        {
            InitializeComponent();
        }

        private void deletePurchaseBills_Load(object sender, EventArgs e)
        {
           
            imgList.SizeMode = PictureBoxSizeMode.StretchImage;
            bunifuGradientPanel3.Select();
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AutoStorage\AutoStorage\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM PurchaseBills", sqlConnection);
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            metroGrid1.Columns[0].Visible = false;
            metroGrid1.Columns[17].Visible = false;

            ////////////////////////////////////////////////////
            metroGrid1.Columns[1].HeaderText = "Отправляющая компания";
            metroGrid1.Columns[2].HeaderText = "Адрес компании";
            metroGrid1.Columns[3].HeaderText = "Город отправки";
            metroGrid1.Columns[4].HeaderText = "Телфон отправляющей компании";
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
            metroGrid1.Columns[21].HeaderText = "Тип перевозчика";
            metroGrid1.Columns[22].HeaderText = "Вместимость перевозчика";
            metroGrid1.Columns[23].HeaderText = "Грузоподъемность";
            metroGrid1.Columns[24].HeaderText = "Длина, м";
            metroGrid1.Columns[25].HeaderText = "Ширина, м";
            metroGrid1.Columns[26].HeaderText = "Высота, м";
            metroGrid1.Columns[27].HeaderText = "Объем, м3";
            metroGrid1.Columns[28].HeaderText = "Материал кузова";
            metroGrid1.Columns[29].HeaderText = "Способы загрузки";
            metroGrid1.Columns[30].HeaderText = "Цена перевозки за 1 тонну";
            metroGrid1.Columns[31].HeaderText = "Тип погрузчика";
            metroGrid1.Columns[32].HeaderText = "Вместимость погрузчика";
            metroGrid1.Columns[33].HeaderText = "Грузоподъемность погрузчика";
          //////////////////////////////////////////////////////////////////

        }

        private void deletePurchaseBills_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (slidemenu.Width == 228)
            {
                slidemenu.Visible = false;
                slidemenu.Width = 50;

                panelAnimator.ShowSync(slidemenu);
            }
            else
            {
                slidemenu.Visible = false;
                slidemenu.Width = 228;

                panelAnimator.ShowSync(slidemenu);
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            billsLookup bL = new billsLookup();
            this.Hide();
            bL.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            workWithBills wbs = new workWithBills();
            this.Hide();
            wbs.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            transpOperationPurchaseBills tOP = new transpOperationPurchaseBills();
            this.Hide();
            tOP.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            lookUpStorages lUS = new lookUpStorages();

            lUS.ShowDialog();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            StartLogin st = new StartLogin();
            this.Hide();
            st.Show();
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
   //             transportSumBox.Text = metroGrid1.Rows[e.RowIndex].Cells[16].Value.ToString();
                imgList.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])metroGrid1.Rows[e.RowIndex].Cells[17].Value));
                keepingForWeekPriceBox.Text = metroGrid1.Rows[e.RowIndex].Cells[18].Value.ToString();
                totalDaysBox.Text = metroGrid1.Rows[e.RowIndex].Cells[19].Value.ToString();
                keepingSumBox.Text = metroGrid1.Rows[e.RowIndex].Cells[20].Value.ToString();
                carcasTypeBox.Text = metroGrid1.Rows[e.RowIndex].Cells[21].Value.ToString();
                capacityBox.Text = metroGrid1.Rows[e.RowIndex].Cells[22].Value.ToString();
                carryingBox.Text = metroGrid1.Rows[e.RowIndex].Cells[23].Value.ToString();
                lengthBox.Text = metroGrid1.Rows[e.RowIndex].Cells[24].Value.ToString();
                widthBox.Text = metroGrid1.Rows[e.RowIndex].Cells[25].Value.ToString();
                heighBox.Text = metroGrid1.Rows[e.RowIndex].Cells[26].Value.ToString();
                amountBox.Text = metroGrid1.Rows[e.RowIndex].Cells[27].Value.ToString();
                carcasMaterialBox.Text = metroGrid1.Rows[e.RowIndex].Cells[28].Value.ToString();
                loadTypeBox.Text = metroGrid1.Rows[e.RowIndex].Cells[29].Value.ToString();
                transportPriceBox.Text = metroGrid1.Rows[e.RowIndex].Cells[30].Value.ToString();
                loaderTypeBox.Text = metroGrid1.Rows[e.RowIndex].Cells[31].Value.ToString();
                loaderCapacityBox.Text = metroGrid1.Rows[e.RowIndex].Cells[32].Value.ToString();
                loaderTonnageBox.Text = metroGrid1.Rows[e.RowIndex].Cells[33].Value.ToString();
            }
            catch { }
        }
 
         private void deletePurchaseBill_Click(object sender, EventArgs e)
                {
                    checkFields();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = new SqlCommand("SELECT * FROM PurchaseBills", sqlConnection);
                    da.Fill(ds);
                    metroGrid1.DataSource = ds.Tables[0];
                }

        public void checkFields()
        {
            if (string.IsNullOrEmpty(companyFromBox.Text) || string.IsNullOrWhiteSpace(fromAdresBox.Text) || string.IsNullOrWhiteSpace(fromCityBox.Text) ||
               string.IsNullOrWhiteSpace(fromPhoneBox.Text) || string.IsNullOrEmpty(fromEmailBox.Text) || string.IsNullOrWhiteSpace(companyToBox.Text) ||
                string.IsNullOrWhiteSpace(toAdresBox.Text) || string.IsNullOrEmpty(toCityBox.Text) || string.IsNullOrWhiteSpace(toPhoneBox.Text) ||
                 string.IsNullOrWhiteSpace(toEmailBox.Text) || string.IsNullOrEmpty(goodsNameBox.Text) ||
                  string.IsNullOrWhiteSpace(weightBox.Text) || string.IsNullOrWhiteSpace(goodsTypeBox.Text) || string.IsNullOrWhiteSpace(cubageBox.Text) ||
                   string.IsNullOrWhiteSpace(carcasTypeBox.Text) || string.IsNullOrEmpty(capacityBox.Text) || string.IsNullOrWhiteSpace(carryingBox.Text) ||
                    string.IsNullOrWhiteSpace(lengthBox.Text) || string.IsNullOrEmpty(widthBox.Text) || string.IsNullOrWhiteSpace(heighBox.Text) ||
                     string.IsNullOrWhiteSpace(amountBox.Text) || string.IsNullOrEmpty(carcasMaterialBox.Text) || string.IsNullOrWhiteSpace(loadTypeBox.Text) ||
                      string.IsNullOrEmpty(transportPriceBox.Text))
            {
                MetroMessageBox.Show(this, "Заполните все поля");
                return;
            }

            else
            {
                delete();
            }
        }
        public void delete()
        {

            DialogResult result = MetroMessageBox.Show(this, "Предупреждение", "Выбранная накладная будет удалена", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                SqlCommand deleteBill = new SqlCommand("DELETE FROM [PurchaseBills] WHERE (id = '" + idBox.Text + "')", sqlConnection);
                deleteBill.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Информация", "Расходная накладная успешно удалена", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void bunifuGradientPanel3_MouseEnter(object sender, EventArgs e)
        {
            bunifuGradientPanel3.Select();
        }

        private void dateSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM [PurchaseBills] WHERE (date1 LIKE '%" + dateSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void typeSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM [PurchaseBills] WHERE (goodsType LIKE N'%" + typeSearchBox.Text.ToString() + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void priceSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM [PurchaseBills] WHERE (keepingSumBox LIKE '%" + priceSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM PurchaseBills", sqlConnection);
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
        }

        private void metroGrid1_MouseLeave(object sender, EventArgs e)
        {
            bunifuGradientPanel3.Select();
        }

        private void backToWorkWithBills_Click(object sender, EventArgs e)
        {
            workWithBills wbs = new workWithBills();
            this.Hide();
            wbs.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

       
       




    }
   }

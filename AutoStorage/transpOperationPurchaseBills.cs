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
    public partial class transpOperationPurchaseBills : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public transpOperationPurchaseBills()
        {
            InitializeComponent();
        }

        private void transpOperationWaybills_Load(object sender, EventArgs e)
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

            ////////////////////////////////////////////Purchase
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

            }
            catch { }

        }

        private void bunifuGradientPanel3_MouseEnter(object sender, EventArgs e)
        {
            bunifuGradientPanel3.Select();
        }

        private void transpOperationWaybills_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void dateSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM [PurchaseBills] WHERE (date1 LIKE '%" + dateSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
            dr.Close();
        }

        private void typeSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM PurchaseBills WHERE (goodsType LIKE N'%" + typeSearchBox.Text.ToString() + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
            dr.Close();
        }

        private void priceSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM PurchaseBills WHERE (keepingSumBox LIKE '%" + priceSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
            dr.Close();
        }

        private void toSelectedStorageBtn_Click(object sender, EventArgs e)
        {
            checkTypeStorage();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM PurchaseBills", sqlConnection);
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
        }
        public void picReader()
        {
            /*
             SqlCommand getPiccommand = new SqlCommand("SELECT FacePhoto FROM Managers WHERE id='" + idBox.Text + "'", sqlConnection); //Получение фотографии пользователя по id.
            SqlDataReader picReader1 = getPiccommand.ExecuteReader();
            if (picReader1.Read())
            {
                byte[] imgData1 = (byte[])picReader1[0];
                using (MemoryStream ms = new MemoryStream(imgData1))
                {
                    imgList.Image = Image.FromStream(ms);
                    picReader1.Close();
                }
            }
             */
        }

        public void checkTypeStorage()
        {
            if (strgNmbrBox.Text != "1" && goodsTypeBox.Text == "Продовольственные товары") //Если нет
            {
                MetroMessageBox.Show(this, "Ошибка", "Данный тип товара невозможно переместить на этот склад'", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (strgNmbrBox.Text == "1" && goodsTypeBox.Text == "Продовольственные товары") //Если да
                {
                    DialogResult result = MetroMessageBox.Show(this, "Вы точно хотите переместить этот груз на 'Склад1'?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        SqlCommand getPiccommand = new SqlCommand("SELECT image FROM PurchaseBills WHERE id='" + idBox.Text + "'", sqlConnection); //Получение фотографии пользователя по id.
                        SqlDataReader picReader1 = getPiccommand.ExecuteReader();
                        if (picReader1.Read())
                        {
                            byte[] imgData1 = (byte[])picReader1[0];
                            using (MemoryStream ms = new MemoryStream(imgData1))
                            {
                                imgList.Image = Image.FromStream(ms);
                                picReader1.Close();
                            }
                            //Указывааем номер склада
                            SqlCommand goods = new SqlCommand(@"INSERT INTO [Storage1] (companyFrom,fromAdres,fromCity,fromPhone,fromEmail,companyTo,toAdres,toCity,toPhone,toEmail, 
                       goodsName,weight,cubage,goodsType,date1,date2,keepingForWeekPrice,totalDays,keepingSumBox,image) 
       VALUES (@companyFrom,@fromAdres,@fromCity,@fromPhone,@fromEmail,@companyTo,@toAdres,@toCity,@toPhone,@toEmail,@goodsName,@weight,@cubage,@goodsType,
                       @date1,@date2,@keepingForWeekPrice,@totalDays,@keepingSumBox,@image)", sqlConnection);
                            goods.Parameters.AddWithValue("companyFrom", companyFromBox.Text);
                            goods.Parameters.AddWithValue("fromAdres", fromAdresBox.Text);
                            goods.Parameters.AddWithValue("fromCity", fromCityBox.Text);
                            goods.Parameters.AddWithValue("fromPhone", fromPhoneBox.Text);
                            goods.Parameters.AddWithValue("fromEmail", fromEmailBox.Text);
                            /**/
                            goods.Parameters.AddWithValue("companyTo", companyToBox.Text);
                            goods.Parameters.AddWithValue("toAdres", toAdresBox.Text);
                            goods.Parameters.AddWithValue("toCity", toCityBox.Text);
                            goods.Parameters.AddWithValue("toPhone", toPhoneBox.Text);
                            goods.Parameters.AddWithValue("toEmail", toEmailBox.Text);
                            goods.Parameters.AddWithValue("goodsName", goodsNameBox.Text);
                            /**/

                            goods.Parameters.AddWithValue("weight", weightBox.Text);
                            goods.Parameters.AddWithValue("cubage", cubageBox.Text);

                            goods.Parameters.AddWithValue("goodsType", goodsTypeBox.Text);
                            goods.Parameters.AddWithValue("date1", metroDateTime1.Value.ToString("MM/dd/yyyy"));
                            goods.Parameters.AddWithValue("date2", metroDateTime2.Value.ToString("MM/dd/yyyy"));
                            goods.Parameters.AddWithValue("keepingForWeekPrice", keepingForWeekPriceBox.Text);
                            goods.Parameters.AddWithValue("totalDays", totalDaysBox.Text);
                            goods.Parameters.AddWithValue("keepingSumBox", keepingSumBox.Text);

                            goods.Parameters.AddWithValue("image", imgData1);
                            goods.ExecuteNonQuery();
                        }

                        //Указываем номер склада
                        DialogResult dialog1 = MetroMessageBox.Show(this, "Груз перемещен на склад 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog1 == DialogResult.OK)
                        {
                            //Указываем номер склада
                            SqlCommand goods2 = new SqlCommand("UPDATE StoragesCongestion SET Storage1 = Storage1 - @cubage WHERE id=1", sqlConnection);
                            goods2.Parameters.AddWithValue("cubage", cubageBox.Text);
                            //   command.Parameters.AddWithValue("znach", znachBox.Text);
                            //  command.Parameters.AddWithValue("Id", idBox.Text);
                            goods2.ExecuteNonQuery();
                            SqlCommand goods3 = new SqlCommand("DELETE FROM [PurchaseBills] WHERE id=@id", sqlConnection);
                            goods3.Parameters.AddWithValue("id", idBox.Text);
                            goods3.ExecuteNonQuery();


                        }

                    }
                }
            }
            //////////////////////////////////////////2 склад
            if (strgNmbrBox.Text != "2" && goodsTypeBox.Text == "Электронные товары") //Если нет
            {
                MetroMessageBox.Show(this, "Ошибка", "Данный тип товара невозможно переместить на этот склад'", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (strgNmbrBox.Text == "2" && goodsTypeBox.Text == "Электронные товары") //Если да
                {
                    // Указываем номер склада
                    DialogResult result = MetroMessageBox.Show(this, "Вы точно хотите переместить этот груз на 'Склад2'?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        SqlCommand getPiccommand = new SqlCommand("SELECT image FROM PurchaseBills WHERE id='" + idBox.Text + "'", sqlConnection); //Получение фотографии пользователя по id.
                        SqlDataReader picReader1 = getPiccommand.ExecuteReader();
                        if (picReader1.Read())
                        {
                            byte[] imgData1 = (byte[])picReader1[0];
                            using (MemoryStream ms = new MemoryStream(imgData1))
                            {
                                imgList.Image = Image.FromStream(ms);
                                picReader1.Close();
                            }
                            //Указывааем номер склада
                            SqlCommand goods = new SqlCommand(@"INSERT INTO [Storage2] (companyFrom,fromAdres,fromCity,fromPhone,fromEmail,companyTo,toAdres,toCity,toPhone,toEmail, 
                       goodsName,weight,cubage,goodsType,date1,date2,keepingForWeekPrice,totalDays,keepingSumBox,image) 
       VALUES (@companyFrom,@fromAdres,@fromCity,@fromPhone,@fromEmail,@companyTo,@toAdres,@toCity,@toPhone,@toEmail,@goodsName,@weight,@cubage,@goodsType,
                       @date1,@date2,@keepingForWeekPrice,@totalDays,@keepingSumBox,@image)", sqlConnection);
                            goods.Parameters.AddWithValue("companyFrom", companyFromBox.Text);
                            goods.Parameters.AddWithValue("fromAdres", fromAdresBox.Text);
                            goods.Parameters.AddWithValue("fromCity", fromCityBox.Text);
                            goods.Parameters.AddWithValue("fromPhone", fromPhoneBox.Text);
                            goods.Parameters.AddWithValue("fromEmail", fromEmailBox.Text);
                            /**/
                            goods.Parameters.AddWithValue("companyTo", companyToBox.Text);
                            goods.Parameters.AddWithValue("toAdres", toAdresBox.Text);
                            goods.Parameters.AddWithValue("toCity", toCityBox.Text);
                            goods.Parameters.AddWithValue("toPhone", toPhoneBox.Text);
                            goods.Parameters.AddWithValue("toEmail", toEmailBox.Text);
                            goods.Parameters.AddWithValue("goodsName", goodsNameBox.Text);
                            /**/

                            goods.Parameters.AddWithValue("weight", weightBox.Text);
                            goods.Parameters.AddWithValue("cubage", cubageBox.Text);

                            goods.Parameters.AddWithValue("goodsType", goodsTypeBox.Text);
                            goods.Parameters.AddWithValue("date1", metroDateTime1.Value.ToString("MM/dd/yyyy"));
                            goods.Parameters.AddWithValue("date2", metroDateTime2.Value.ToString("MM/dd/yyyy"));
                            goods.Parameters.AddWithValue("keepingForWeekPrice", keepingForWeekPriceBox.Text);
                            goods.Parameters.AddWithValue("totalDays", totalDaysBox.Text);
                            goods.Parameters.AddWithValue("keepingSumBox", keepingSumBox.Text);

                            goods.Parameters.AddWithValue("image", imgData1);
                            goods.ExecuteNonQuery();
                        }

                        //Указываем номер склада
                        DialogResult dialog1 = MetroMessageBox.Show(this, "Груз перемещен на склад 2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog1 == DialogResult.OK)
                        {
                            //Указываем номер склада
                            SqlCommand goods2 = new SqlCommand("UPDATE StoragesCongestion SET Storage2 = Storage2 - @cubage WHERE id=1", sqlConnection);
                            goods2.Parameters.AddWithValue("cubage", cubageBox.Text);
                            goods2.ExecuteNonQuery();
                            SqlCommand goods3 = new SqlCommand("DELETE FROM [PurchaseBills] WHERE id=@id", sqlConnection);
                            goods3.Parameters.AddWithValue("id", idBox.Text);
                            goods3.ExecuteNonQuery();


                        }

                    }
                }
            }
            //////////////////////////////////////////склад3
            if (strgNmbrBox.Text != "3" && goodsTypeBox.Text == "Товары с температурным режимом") //Если нет
            {
                MetroMessageBox.Show(this, "Ошибка", "Данный тип товара невозможно переместить на этот склад'", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (strgNmbrBox.Text == "3" && goodsTypeBox.Text == "Товары с температурным режимом") //Если да
                {
                    // Указываем номер склада
                    DialogResult result = MetroMessageBox.Show(this, "Вы точно хотите переместить этот груз на 'Склад3'?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        SqlCommand getPiccommand = new SqlCommand("SELECT image FROM PurchaseBills WHERE id='" + idBox.Text + "'", sqlConnection); //Получение фотографии пользователя по id.
                        SqlDataReader picReader1 = getPiccommand.ExecuteReader();
                        if (picReader1.Read())
                        {
                            byte[] imgData1 = (byte[])picReader1[0];
                            using (MemoryStream ms = new MemoryStream(imgData1))
                            {
                                imgList.Image = Image.FromStream(ms);
                                picReader1.Close();
                            }
                            //Указывааем номер склада
                            SqlCommand goods = new SqlCommand(@"INSERT INTO [Storage3] (companyFrom,fromAdres,fromCity,fromPhone,fromEmail,companyTo,toAdres,toCity,toPhone,toEmail, 
                       goodsName,weight,cubage,goodsType,date1,date2,keepingForWeekPrice,totalDays,keepingSumBox,image) 
       VALUES (@companyFrom,@fromAdres,@fromCity,@fromPhone,@fromEmail,@companyTo,@toAdres,@toCity,@toPhone,@toEmail,@goodsName,@weight,@cubage,@goodsType,
                       @date1,@date2,@keepingForWeekPrice,@totalDays,@keepingSumBox,@image)", sqlConnection);
                            goods.Parameters.AddWithValue("companyFrom", companyFromBox.Text);
                            goods.Parameters.AddWithValue("fromAdres", fromAdresBox.Text);
                            goods.Parameters.AddWithValue("fromCity", fromCityBox.Text);
                            goods.Parameters.AddWithValue("fromPhone", fromPhoneBox.Text);
                            goods.Parameters.AddWithValue("fromEmail", fromEmailBox.Text);
                            /**/
                            goods.Parameters.AddWithValue("companyTo", companyToBox.Text);
                            goods.Parameters.AddWithValue("toAdres", toAdresBox.Text);
                            goods.Parameters.AddWithValue("toCity", toCityBox.Text);
                            goods.Parameters.AddWithValue("toPhone", toPhoneBox.Text);
                            goods.Parameters.AddWithValue("toEmail", toEmailBox.Text);
                            goods.Parameters.AddWithValue("goodsName", goodsNameBox.Text);
                            /**/

                            goods.Parameters.AddWithValue("weight", weightBox.Text);
                            goods.Parameters.AddWithValue("cubage", cubageBox.Text);

                            goods.Parameters.AddWithValue("goodsType", goodsTypeBox.Text);
                            goods.Parameters.AddWithValue("date1", metroDateTime1.Value.ToString("MM/dd/yyyy"));
                            goods.Parameters.AddWithValue("date2", metroDateTime2.Value.ToString("MM/dd/yyyy"));
                            goods.Parameters.AddWithValue("keepingForWeekPrice", keepingForWeekPriceBox.Text);
                            goods.Parameters.AddWithValue("totalDays", totalDaysBox.Text);
                            goods.Parameters.AddWithValue("keepingSumBox", keepingSumBox.Text);

                            goods.Parameters.AddWithValue("image", imgData1);
                            goods.ExecuteNonQuery();
                        }

                        //Указываем номер склада
                        DialogResult dialog1 = MetroMessageBox.Show(this, "Груз перемещен на склад 3", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog1 == DialogResult.OK)
                        {
                            //Указываем номер склада
                            SqlCommand goods2 = new SqlCommand("UPDATE StoragesCongestion SET Storage3 = Storage3 - @cubage WHERE id=1", sqlConnection);
                            goods2.Parameters.AddWithValue("cubage", cubageBox.Text);
                            goods2.ExecuteNonQuery();
                            SqlCommand goods3 = new SqlCommand("DELETE FROM [PurchaseBills] WHERE id=@id", sqlConnection);
                            goods3.Parameters.AddWithValue("id", idBox.Text);
                            goods3.ExecuteNonQuery();
                        }
                    }
                }
            }
            ////////////////////////////склад4
            if (strgNmbrBox.Text != "4" && goodsTypeBox.Text == "Строительные материалы") //Если нет
            {
                MetroMessageBox.Show(this, "Ошибка", "Данный тип товара невозможно переместить на этот склад'", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (strgNmbrBox.Text == "4" && goodsTypeBox.Text == "Строительные материалы") //Если да
                {
                    // Указываем номер склада
                    DialogResult result = MetroMessageBox.Show(this, "Вы точно хотите переместить этот груз на 'Склад4'?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        SqlCommand getPiccommand = new SqlCommand("SELECT image FROM PurchaseBills WHERE id='" + idBox.Text + "'", sqlConnection); //Получение фотографии пользователя по id.
                        SqlDataReader picReader1 = getPiccommand.ExecuteReader();
                        if (picReader1.Read())
                        {
                            byte[] imgData1 = (byte[])picReader1[0];
                            using (MemoryStream ms = new MemoryStream(imgData1))
                            {
                                imgList.Image = Image.FromStream(ms);
                                picReader1.Close();
                            }
                            //Указывааем номер склада
                            SqlCommand goods = new SqlCommand(@"INSERT INTO [Storage4] (companyFrom,fromAdres,fromCity,fromPhone,fromEmail,companyTo,toAdres,toCity,toPhone,toEmail, 
                       goodsName,weight,cubage,goodsType,date1,date2,keepingForWeekPrice,totalDays,keepingSumBox,image) 
       VALUES (@companyFrom,@fromAdres,@fromCity,@fromPhone,@fromEmail,@companyTo,@toAdres,@toCity,@toPhone,@toEmail,@goodsName,@weight,@cubage,@goodsType,
                       @date1,@date2,@keepingForWeekPrice,@totalDays,@keepingSumBox,@image)", sqlConnection);
                            goods.Parameters.AddWithValue("companyFrom", companyFromBox.Text);
                            goods.Parameters.AddWithValue("fromAdres", fromAdresBox.Text);
                            goods.Parameters.AddWithValue("fromCity", fromCityBox.Text);
                            goods.Parameters.AddWithValue("fromPhone", fromPhoneBox.Text);
                            goods.Parameters.AddWithValue("fromEmail", fromEmailBox.Text);
                            /**/
                            goods.Parameters.AddWithValue("companyTo", companyToBox.Text);
                            goods.Parameters.AddWithValue("toAdres", toAdresBox.Text);
                            goods.Parameters.AddWithValue("toCity", toCityBox.Text);
                            goods.Parameters.AddWithValue("toPhone", toPhoneBox.Text);
                            goods.Parameters.AddWithValue("toEmail", toEmailBox.Text);
                            goods.Parameters.AddWithValue("goodsName", goodsNameBox.Text);
                            /**/

                            goods.Parameters.AddWithValue("weight", weightBox.Text);
                            goods.Parameters.AddWithValue("cubage", cubageBox.Text);

                            goods.Parameters.AddWithValue("goodsType", goodsTypeBox.Text);
                            goods.Parameters.AddWithValue("date1", metroDateTime1.Value.ToString("MM/dd/yyyy"));
                            goods.Parameters.AddWithValue("date2", metroDateTime2.Value.ToString("MM/dd/yyyy"));
                            goods.Parameters.AddWithValue("keepingForWeekPrice", keepingForWeekPriceBox.Text);
                            goods.Parameters.AddWithValue("totalDays", totalDaysBox.Text);
                            goods.Parameters.AddWithValue("keepingSumBox", keepingSumBox.Text);

                            goods.Parameters.AddWithValue("image", imgData1);
                            goods.ExecuteNonQuery();
                        }

                        //Указываем номер склада
                        DialogResult dialog1 = MetroMessageBox.Show(this, "Груз перемещен на склад 4", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog1 == DialogResult.OK)
                        {
                            //Указываем номер склада
                            SqlCommand goods2 = new SqlCommand("UPDATE StoragesCongestion SET Storage4 = Storage4 - @cubage WHERE id=1", sqlConnection);
                            goods2.Parameters.AddWithValue("cubage", cubageBox.Text);
                            goods2.ExecuteNonQuery();
                            SqlCommand goods3 = new SqlCommand("DELETE FROM [PurchaseBills] WHERE id=@id", sqlConnection);
                            goods3.Parameters.AddWithValue("id", idBox.Text);
                            goods3.ExecuteNonQuery();
                        }
                    }
                }
            }
            //////////////////////////////////////////склад5
            if (strgNmbrBox.Text != "5" && goodsTypeBox.Text == "Сыпучие") //Если нет
            {
                MetroMessageBox.Show(this, "Ошибка", "Данный тип товара невозможно переместить на этот склад'", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (strgNmbrBox.Text == "5" && goodsTypeBox.Text == "Сыпучие") //Если да
                {
                    // Указываем номер склада
                    DialogResult result = MetroMessageBox.Show(this, "Вы точно хотите переместить этот груз на 'Склад5'?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        SqlCommand getPiccommand = new SqlCommand("SELECT image FROM PurchaseBills WHERE id='" + idBox.Text + "'", sqlConnection); //Получение фотографии пользователя по id.
                        SqlDataReader picReader1 = getPiccommand.ExecuteReader();
                        if (picReader1.Read())
                        {
                            byte[] imgData1 = (byte[])picReader1[0];
                            using (MemoryStream ms = new MemoryStream(imgData1))
                            {
                                imgList.Image = Image.FromStream(ms);
                                picReader1.Close();
                            }
                            //Указывааем номер склада
                            SqlCommand goods = new SqlCommand(@"INSERT INTO [Storage5] (companyFrom,fromAdres,fromCity,fromPhone,fromEmail,companyTo,toAdres,toCity,toPhone,toEmail, 
                       goodsName,weight,cubage,goodsType,date1,date2,keepingForWeekPrice,totalDays,keepingSumBox,image) 
       VALUES (@companyFrom,@fromAdres,@fromCity,@fromPhone,@fromEmail,@companyTo,@toAdres,@toCity,@toPhone,@toEmail,@goodsName,@weight,@cubage,@goodsType,
                       @date1,@date2,@keepingForWeekPrice,@totalDays,@keepingSumBox,@image)", sqlConnection);
                            goods.Parameters.AddWithValue("companyFrom", companyFromBox.Text);
                            goods.Parameters.AddWithValue("fromAdres", fromAdresBox.Text);
                            goods.Parameters.AddWithValue("fromCity", fromCityBox.Text);
                            goods.Parameters.AddWithValue("fromPhone", fromPhoneBox.Text);
                            goods.Parameters.AddWithValue("fromEmail", fromEmailBox.Text);
                            /**/
                            goods.Parameters.AddWithValue("companyTo", companyToBox.Text);
                            goods.Parameters.AddWithValue("toAdres", toAdresBox.Text);
                            goods.Parameters.AddWithValue("toCity", toCityBox.Text);
                            goods.Parameters.AddWithValue("toPhone", toPhoneBox.Text);
                            goods.Parameters.AddWithValue("toEmail", toEmailBox.Text);
                            goods.Parameters.AddWithValue("goodsName", goodsNameBox.Text);
                            /**/

                            goods.Parameters.AddWithValue("weight", weightBox.Text);
                            goods.Parameters.AddWithValue("cubage", cubageBox.Text);

                            goods.Parameters.AddWithValue("goodsType", goodsTypeBox.Text);
                            goods.Parameters.AddWithValue("date1", metroDateTime1.Value.ToString("MM/dd/yyyy"));
                            goods.Parameters.AddWithValue("date2", metroDateTime2.Value.ToString("MM/dd/yyyy"));
                            goods.Parameters.AddWithValue("keepingForWeekPrice", keepingForWeekPriceBox.Text);
                            goods.Parameters.AddWithValue("totalDays", totalDaysBox.Text);
                            goods.Parameters.AddWithValue("keepingSumBox", keepingSumBox.Text);

                            goods.Parameters.AddWithValue("image", imgData1);
                            goods.ExecuteNonQuery();
                        }

                        //Указываем номер склада
                        DialogResult dialog1 = MetroMessageBox.Show(this, "Груз перемещен на склад 5", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog1 == DialogResult.OK)
                        {
                            //Указываем номер склада
                            SqlCommand goods2 = new SqlCommand("UPDATE StoragesCongestion SET Storage5 = Storage5 - @cubage WHERE id=1", sqlConnection);
                            goods2.Parameters.AddWithValue("cubage", cubageBox.Text);
                            goods2.ExecuteNonQuery();
                            SqlCommand goods3 = new SqlCommand("DELETE FROM [PurchaseBills] WHERE id=@id", sqlConnection);
                            goods3.Parameters.AddWithValue("id", idBox.Text);
                            goods3.ExecuteNonQuery();
                        }
                    }
                }
            }
        }



        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            lookUpStorages lUS = new lookUpStorages();
            lUS.Show();
        }

      

       

        private void goToStrgsLookUpBtn_Click(object sender, EventArgs e)
        {
            lookUpStorages lUS = new lookUpStorages();
            lUS.Show();
        }

        private void goToTimeStrgBtn_Click(object sender, EventArgs e)
        {

            // Указываем номер склада
            DialogResult result = MetroMessageBox.Show(this, "Вы точно хотите переместить этот груз на 'Временный склад'?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                SqlCommand getPiccommand = new SqlCommand("SELECT image FROM PurchaseBills WHERE id='" + idBox.Text + "'", sqlConnection); //Получение фотографии пользователя по id.
                SqlDataReader picReader1 = getPiccommand.ExecuteReader();
                if (picReader1.Read())
                {
                    byte[] imgData1 = (byte[])picReader1[0];
                    using (MemoryStream ms = new MemoryStream(imgData1))
                    {
                        imgList.Image = Image.FromStream(ms);
                        picReader1.Close();
                    }
                    //Указывааем номер склада
                    SqlCommand goods = new SqlCommand(@"INSERT INTO [Storage6] (companyFrom,fromAdres,fromCity,fromPhone,fromEmail,companyTo,toAdres,toCity,toPhone,toEmail, 
                       goodsName,weight,cubage,goodsType,date1,date2,keepingForWeekPrice,totalDays,keepingSumBox,image) 
       VALUES (@companyFrom,@fromAdres,@fromCity,@fromPhone,@fromEmail,@companyTo,@toAdres,@toCity,@toPhone,@toEmail,@goodsName,@weight,@cubage,@goodsType,
                       @date1,@date2,@keepingForWeekPrice,@totalDays,@keepingSumBox,@image)", sqlConnection);
                    goods.Parameters.AddWithValue("companyFrom", companyFromBox.Text);
                    goods.Parameters.AddWithValue("fromAdres", fromAdresBox.Text);
                    goods.Parameters.AddWithValue("fromCity", fromCityBox.Text);
                    goods.Parameters.AddWithValue("fromPhone", fromPhoneBox.Text);
                    goods.Parameters.AddWithValue("fromEmail", fromEmailBox.Text);
                    /**/
                    goods.Parameters.AddWithValue("companyTo", companyToBox.Text);
                    goods.Parameters.AddWithValue("toAdres", toAdresBox.Text);
                    goods.Parameters.AddWithValue("toCity", toCityBox.Text);
                    goods.Parameters.AddWithValue("toPhone", toPhoneBox.Text);
                    goods.Parameters.AddWithValue("toEmail", toEmailBox.Text);
                    goods.Parameters.AddWithValue("goodsName", goodsNameBox.Text);
                    /**/

                    goods.Parameters.AddWithValue("weight", weightBox.Text);
                    goods.Parameters.AddWithValue("cubage", cubageBox.Text);

                    goods.Parameters.AddWithValue("goodsType", goodsTypeBox.Text);
                    goods.Parameters.AddWithValue("date1", metroDateTime1.Value.ToString("MM/dd/yyyy"));
                    goods.Parameters.AddWithValue("date2", metroDateTime2.Value.ToString("MM/dd/yyyy"));
                    goods.Parameters.AddWithValue("keepingForWeekPrice", keepingForWeekPriceBox.Text);
                    goods.Parameters.AddWithValue("totalDays", totalDaysBox.Text);
                    goods.Parameters.AddWithValue("keepingSumBox", keepingSumBox.Text);

                    goods.Parameters.AddWithValue("image", imgData1);
                    goods.ExecuteNonQuery();
                }

                //Указываем номер склада
                DialogResult dialog1 = MetroMessageBox.Show(this, "Груз перемещен на Временный склад ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    //Указываем номер склада
                    SqlCommand goods2 = new SqlCommand("UPDATE StoragesCongestion SET Storage6 = Storage6 - @cubage WHERE id=1", sqlConnection);
                    goods2.Parameters.AddWithValue("cubage", cubageBox.Text);
                    goods2.ExecuteNonQuery();
                    SqlCommand goods3 = new SqlCommand("DELETE FROM [PurchaseBills] WHERE id=@id", sqlConnection);
                    goods3.Parameters.AddWithValue("id", idBox.Text);
                    goods3.ExecuteNonQuery();

                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = new SqlCommand("SELECT * FROM PurchaseBills", sqlConnection);
                    da.Fill(ds);
                    metroGrid1.DataSource = ds.Tables[0];
                }
            }
        }

        private void backToWorkWithBills_Click(object sender, EventArgs e)
        {
            managerMenu mM = new managerMenu();
            this.Hide();
            mM.Show();
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

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
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

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM PurchaseBills", sqlConnection);
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            aboutStorages aS = new aboutStorages();
            aS.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutOpeartionPurchaseBills aOPB = new aboutOpeartionPurchaseBills();
            aOPB.ShowDialog();

        }

        
    }
}
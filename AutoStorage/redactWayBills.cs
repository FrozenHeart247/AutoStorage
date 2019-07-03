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
    public partial class redactWayBills : MetroFramework.Forms.MetroForm
    {  
        string imgLocation="";
        SqlConnection sqlConnection;
        public redactWayBills()
        {
            
            InitializeComponent();
        }

        private void redactBills_Load(object sender, EventArgs e)
        {
            imgList.SizeMode = PictureBoxSizeMode.StretchImage;
            bunifuGradientPanel3.Select();
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AutoStorage\AutoStorage\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM WayBills", sqlConnection);
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            metroGrid1.Columns[0].Visible = false;
            metroGrid1.Columns[17].Visible = false;

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
            metroGrid1.Columns[15].HeaderText = "Дата отправки";
            metroGrid1.Columns[16].HeaderText = "Затраты на отправку";
            //img
            metroGrid1.Columns[18].HeaderText = "Тип перевозчика";
            metroGrid1.Columns[19].HeaderText = "Вместимость перевозчика";
            metroGrid1.Columns[20].HeaderText = "Грузоподъемность";
            metroGrid1.Columns[21].HeaderText = "Длина, м";
            metroGrid1.Columns[22].HeaderText = "Ширина, м";
            metroGrid1.Columns[23].HeaderText = "Высота, м";
            metroGrid1.Columns[24].HeaderText = "Объем, м3";
            metroGrid1.Columns[25].HeaderText = "Материал кузова";
            metroGrid1.Columns[26].HeaderText = "Способы загрузки";
            metroGrid1.Columns[27].HeaderText = "Цена перевозки за 1 тонну";

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

       

        private void backToWorkWithBills_Click(object sender, EventArgs e)
        {
            workWithBills wbb = new workWithBills();
            this.Hide();
            wbb.Show();
        }

        private void metroGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
                transportSumBox.Text = metroGrid1.Rows[e.RowIndex].Cells[16].Value.ToString();
                imgList.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])metroGrid1.Rows[e.RowIndex].Cells[17].Value));
                carcasTypeBox.Text = metroGrid1.Rows[e.RowIndex].Cells[18].Value.ToString();
                capacityBox.Text = metroGrid1.Rows[e.RowIndex].Cells[19].Value.ToString();
                carryingBox.Text = metroGrid1.Rows[e.RowIndex].Cells[20].Value.ToString();
                lengthBox.Text = metroGrid1.Rows[e.RowIndex].Cells[21].Value.ToString();
                widthBox.Text = metroGrid1.Rows[e.RowIndex].Cells[22].Value.ToString();
                heighBox.Text = metroGrid1.Rows[e.RowIndex].Cells[23].Value.ToString();
                amountBox.Text = metroGrid1.Rows[e.RowIndex].Cells[24].Value.ToString();
                carcasMaterialBox.Text = metroGrid1.Rows[e.RowIndex].Cells[25].Value.ToString();
                loadTypeBox.Text = metroGrid1.Rows[e.RowIndex].Cells[26].Value.ToString();
                transportPriceBox.Text = metroGrid1.Rows[e.RowIndex].Cells[27].Value.ToString();
            }
            catch { }
            
        }

        private void imgBtn1_Click(object sender, EventArgs e)
        {
            carcasTypeBox.Text = "Рефрижератор-Евро ";
            capacityBox.Text = "33 евпропаллеты";
            carryingBox.Text = "20-25 тонн";
            lengthBox.Text = "12-13,6";
            widthBox.Text = "2,3-2,45";
            heighBox.Text = "2,25-2,5";
            amountBox.Text = "82-86";
            carcasMaterialBox.Text = "Металл, утеплитель, пластик";
            loadTypeBox.Text = "Задние ворота";
            transportPriceBox.Text = "3000";
            try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                transportSumBox.Text = result.ToString();

            }
            catch (Exception ex)
            { }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (contentSlideMenu.Width == 26 && contentSlideMenu.Height == 19)   //26;19
            {
                metroGrid1.Visible = false;
                contentSlideMenu.Visible = true;
                contentSlideMenu.Width = 1273;
                contentSlideMenu.Height = 740;     //   990; 440      954; 530
                contentSlideMenu.Left = -10;
                groupBox4.Visible = false;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            contentSlideMenu.Visible = false;
            contentSlideMenu.Width = 26;
            contentSlideMenu.Height = 19;
            metroGrid1.Visible = true;
            bunifuGradientPanel3.Select();
            groupBox4.Visible = true;

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            checkFields();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM WayBills", sqlConnection);
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
                     update();
                 }
             }
     
        public void update()
        {

            SqlCommand command = new SqlCommand(@"UPDATE [WayBills] SET companyFrom=@companyFrom,fromAdres=@fromAdres,fromCity=@fromCity,fromPhone=@fromPhone,
                fromEmail=@fromEmail,companyTo=@companyTo,toAdres=@toAdres,toCity=@toCity,toPhone=@toPhone,toEmail=@toEmail,goodsName=@goodsName,weight=@weight,cubage=@cubage,goodsType=@goodsType,date=@date,consumption=@consumption,carcasType=@carcasType,capacity=@capacity,carrying=@carrying,length=@length,width=@width,
                height=@height,amount=@amount,carcasMaterial=@carcasMaterial,loadType=@loadType,transportPrice=@transportPrice WHERE id =@id", sqlConnection);

                    command.Parameters.AddWithValue("id", idBox.Text);
                    command.Parameters.AddWithValue("companyFrom", companyFromBox.Text);
                    command.Parameters.AddWithValue("fromAdres", fromAdresBox.Text);
                    command.Parameters.AddWithValue("fromCity", fromCityBox.Text);
                    command.Parameters.AddWithValue("fromPhone", fromPhoneBox.Text);
                    command.Parameters.AddWithValue("fromEmail", fromEmailBox.Text);
                    /**/
                    command.Parameters.AddWithValue("companyTo", companyToBox.Text);
                    command.Parameters.AddWithValue("toAdres", toAdresBox.Text);
                    command.Parameters.AddWithValue("toCity", toCityBox.Text);
                    command.Parameters.AddWithValue("toPhone", toPhoneBox.Text);
                    command.Parameters.AddWithValue("toEmail", toEmailBox.Text);
                    command.Parameters.AddWithValue("goodsName", goodsNameBox.Text);
                    /**/
                   
                    command.Parameters.AddWithValue("weight", weightBox.Text);
                    command.Parameters.AddWithValue("cubage", cubageBox.Text);
//                    command.Parameters.AddWithValue("tonnage", tonnageBox.Text);
                    command.Parameters.AddWithValue("goodsType", goodsTypeBox.Text);
                    command.Parameters.AddWithValue("date", metroDateTime1.Value.ToString("MM/dd/yyyy"));
                    command.Parameters.AddWithValue("consumption", transportSumBox.Text);
                    command.Parameters.AddWithValue("carcasType", carcasTypeBox.Text);
                    command.Parameters.AddWithValue("capacity", capacityBox.Text);
                    command.Parameters.AddWithValue("carrying", carryingBox.Text);
                    command.Parameters.AddWithValue("length", lengthBox.Text);
                    command.Parameters.AddWithValue("width", widthBox.Text);
                    command.Parameters.AddWithValue("height", heighBox.Text);
                    command.Parameters.AddWithValue("amount", amountBox.Text);
                    command.Parameters.AddWithValue("carcasMaterial", carcasMaterialBox.Text);
                    command.Parameters.AddWithValue("loadType", loadTypeBox.Text);
                    command.Parameters.AddWithValue("transportPrice", transportPriceBox.Text);
                
                    command.ExecuteNonQuery();
                    MetroMessageBox.Show(this, "Оповещение", "Расходная накладная успешно обновлена", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
        }

        private void addGoodsBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png | jpg files(*.jpg) | *.jpg| ALL files(*.*)| *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                imgList.ImageLocation = imgLocation;
                imgList.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);
            SqlCommand command2 = new SqlCommand(@"UPDATE [WayBills] SET image=@image WHERE id =@id",sqlConnection);
            command2.Parameters.AddWithValue("image", images);
             command2.Parameters.AddWithValue("id", idBox.Text);
             command2.ExecuteNonQuery();
             MetroMessageBox.Show(this,"Оповещение","Список товаров успешно изменен",MessageBoxButtons.OK,MessageBoxIcon.Question);

        }

        private void redactBills_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void weightBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                transportSumBox.Text = result.ToString();
            }
            catch { }
        }

        private void weightBox_OnValueChanged(object sender, EventArgs e)
        {
           try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                transportSumBox.Text = result.ToString();
            }
            catch { }
        }

        private void goodsTypeBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            goodsTypeBox.Enabled = false;
            goodsTypeBox.Enabled = true;
        }

        private void dateSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM [WayBills] WHERE (date LIKE '%" + dateSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void typeSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM [WayBills] WHERE (goodsType LIKE N'%" + typeSearchBox.Text.ToString() + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;

        }

        private void priceSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM [WayBills] WHERE (transportPrice LIKE '%" + priceSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void bunifuGradientPanel3_MouseEnter(object sender, EventArgs e)
        {
            bunifuGradientPanel3.Select();
        }

        private void metroGrid1_MouseEnter(object sender, EventArgs e)
        {
            metroGrid1.Select();
        }

        private void fromPhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,,,\b]");

        }

        private void toPhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,,,\b]");

        }

        private void weightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,,,\b]");

        }

        private void cubageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,,,\b]");

        }

        private void transportPriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,,,\b]");

        }

        private void imgBtn2_Click(object sender, EventArgs e)
        {
            carcasTypeBox.Text = "Рефрижератор-Одиночка";
            capacityBox.Text = "10-16 евпропаллеты";
            carryingBox.Text = "7-10 тонн";
            lengthBox.Text = "5,8-5,9";
            widthBox.Text = "2,35-2,45";
            heighBox.Text = "2,2-2,35";
            amountBox.Text = "32-50";
            carcasMaterialBox.Text = "Металл, утеплитель, пластик";
            loadTypeBox.Text = "Задние ворота";
            transportPriceBox.Text = "2000";
        }

        private void imgBtn3_Click(object sender, EventArgs e)
        {
            carcasTypeBox.Text = "Рефрижератор (ЗИЛ-Бычок)";
            capacityBox.Text = "6-7 евпропаллет";
            carryingBox.Text = "3 тонны";
            lengthBox.Text = "3,5-5,5";
            widthBox.Text = "2,0-2,35";
            heighBox.Text = "1,8-2,35";
            amountBox.Text = "15-25";
            carcasMaterialBox.Text = "Металл, утеплитель, пластик";
            loadTypeBox.Text = "Задние ворота";
            transportPriceBox.Text = "1500";
        }

        private void imgBtn4_Click(object sender, EventArgs e)
        {
            carcasTypeBox.Text = "Рефрижератор 1,5 тонны ";
            capacityBox.Text = "8 евпропаллеты";
            carryingBox.Text = "1,5 тонны";
            lengthBox.Text = "2,8-4";
            widthBox.Text = "1,7-2,0";
            heighBox.Text = "1,6-1,9";
            amountBox.Text = "7-14";
            carcasMaterialBox.Text = "Металл, утеплитель, пластик";
            loadTypeBox.Text = "Задние ворота";
            transportPriceBox.Text = "1000";
        }

        private void imgBtn21_Click(object sender, EventArgs e)
        {
            carcasTypeBox.Text = "Изотермический евро ";
            capacityBox.Text = "30-33 евпропаллеты";
            carryingBox.Text = "20-25 тонн";
            lengthBox.Text = "12-13,6";
            widthBox.Text = "2,3-2,45";
            heighBox.Text = "2,25-2,5";
            amountBox.Text = "82-86";
            carcasMaterialBox.Text = "Металл, утеплитель, пластик";
            loadTypeBox.Text = "Задние ворота";
            transportPriceBox.Text = "3000";
        }

        private void imgBtn22_Click(object sender, EventArgs e)
        {
            carcasTypeBox.Text = "Изотермический одиночка ";
            capacityBox.Text = "10-16 евпропаллеты";
            carryingBox.Text = "7-10 тонн";
            lengthBox.Text = "5,8-5,9";
            widthBox.Text = "2,35-2,45";
            heighBox.Text = "2,2-2,35";
            amountBox.Text = "32-50";
            carcasMaterialBox.Text = "Металл, пластик";
            loadTypeBox.Text = "Задние ворота";
            transportPriceBox.Text = "2100";
        }

        private void imgBtn31_Click(object sender, EventArgs e)
        {
            carcasTypeBox.Text = "Тент-автопоезд ";
            capacityBox.Text = "38 евпропаллеты";
            carryingBox.Text = "15-20 тонн";
            lengthBox.Text = "14-16";
            widthBox.Text = "2,4-2,45";
            heighBox.Text = "2,35-2,5";
            amountBox.Text = "100-120";
            carcasMaterialBox.Text = "Тентовая ткань, натянутая на стойки";
            loadTypeBox.Text = "Задни борт, боковой борт, верх";
            transportPriceBox.Text = "3000";
        }

        private void imgBtn32_Click(object sender, EventArgs e)
        {
            carcasTypeBox.Text = "Тент-евро ";
            capacityBox.Text = "33-34 евпропаллеты";
            carryingBox.Text = "20-25 тонн";
            lengthBox.Text = "12-13,6";
            widthBox.Text = "2,3-2,45";
            heighBox.Text = "2,25-2,5";
            amountBox.Text = "82-90";
            carcasMaterialBox.Text = "Тентовая ткань, натянутая на стойки";
            loadTypeBox.Text = "Задни борт, боковой борт, верх";
            transportPriceBox.Text = "2500";
        }

        private void imgBtn33_Click(object sender, EventArgs e)
        {
            carcasTypeBox.Text = "Тент-Jumbo ";
            capacityBox.Text = "33-34 евпропаллеты";
            carryingBox.Text = "20-24 тонны";
            lengthBox.Text = "13,8";
            widthBox.Text = "2,45";
            heighBox.Text = "2,45";
            amountBox.Text = "96";
            carcasMaterialBox.Text = "Тентовая ткань, натянутая на стойки";
            loadTypeBox.Text = "Задни борт, боковой борт, верх";
            transportPriceBox.Text = "2500";
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM WayBills", sqlConnection);
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutRedactWayBills aRWB = new aboutRedactWayBills();
            aRWB.ShowDialog();
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

        private void transportPriceBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                transportSumBox.Text = result.ToString();
            }
            catch { }
        }

       
        }
     }

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
    public partial class redactPurchaseBills : MetroFramework.Forms.MetroForm
    {
        string imgLocation = "";
        SqlConnection sqlConnection;
        public redactPurchaseBills()
        {
            InitializeComponent();
        }

        private void redactPurchaseInvoice_Load(object sender, EventArgs e)
        {
            imgList.SizeMode = PictureBoxSizeMode.StretchImage;
            bunifuGradientPanel3.Select();
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AutoStorage\AutoStorage\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM [PurchaseBills]", sqlConnection);
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            metroGrid1.Columns[0].Visible = false;
            metroGrid1.Columns[17].Visible = false;

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

        private void redactPurchaseInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void backToWorkWithBills_Click(object sender, EventArgs e)
        {
            workWithBills wbs = new workWithBills();
            this.Hide();
            wbs.Show();
        }

       

        private void backToWorkWithBills_Click_1(object sender, EventArgs e)
        {
            workWithBills wbs = new workWithBills();
            this.Hide();
            wbs.Show();
        }

        private void metroGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

           /* int f = 0;
            f = metroGrid1.CurrentRow.Index;
            metroGrid1.ClearSelection();
            metroGrid1.Rows[f].Selected = true;
            metroGrid1.FirstDisplayedScrollingRowIndex = f;
*/
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
                loaderCapacityBox.Text = metroGrid1.Rows[e.RowIndex].Cells[32].Value.ToString();
                loaderTonnageBox.Text = metroGrid1.Rows[e.RowIndex].Cells[33].Value.ToString(); 
               
                //21
            }
            catch { }
        }

        private void metroDateTime1_CloseUp(object sender, EventArgs e)
        {
            try
            {
                DateTime dt1 = metroDateTime1.Value;
                DateTime dt2 = metroDateTime2.Value;
                TimeSpan x = dt2 - dt1;
                totalDaysBox.Text = ((int)x.TotalDays).ToString();  //запись  кол-ва дней из timespan в totalDaysTextbox 
                double totalDays = Convert.ToDouble(totalDaysBox.Text); //Конверт на случай, если будут цифры с точкой
                double priceForWeek = Convert.ToDouble(keepingForWeekPriceBox.Text);
                double result = (totalDays / 7) * priceForWeek;  //формула расчета
                result = Math.Round(result, 2);
                keepingSumBox.Text = result.ToString();
                //4000 for week (7 days)


                //    = ((int)x.TotalHours).ToString(); //часы
            }
            catch (Exception ex)
            { }
        }


        private void metroDateTime2_CloseUp(object sender, EventArgs e)
        {
            try
            {
                DateTime dt1 = metroDateTime1.Value;
                DateTime dt2 = metroDateTime2.Value;
                TimeSpan x = dt2 - dt1;
                totalDaysBox.Text = ((int)x.TotalDays).ToString();  //запись  кол-ва дней из timespan в totalDaysTextbox 
                double totalDays = Convert.ToDouble(totalDaysBox.Text); //Конверт на случай, если будут цифры с точкой
                double priceForWeek = Convert.ToDouble(keepingForWeekPriceBox.Text);
                double result = (totalDays / 7) * priceForWeek;  //формула расчета
                result = Math.Round(result, 2);
                keepingSumBox.Text = result.ToString();
                //4000 for week (7 days)


                //    = ((int)x.TotalHours).ToString(); //часы
            }
            catch (Exception ex)
            { }
        }
        public void checkDate()  // Проверка на корректность введенных данных (отрицательное число недопустимо)
        {
            int check = Convert.ToInt32(totalDaysBox.Text);
            if (check < 0)
            {
                MetroMessageBox.Show(this, "Ошибка", "Количество дней не может быть отрицательным");
                totalDaysBox.Text = "";
            }
        }

        private void totalDaysBox_OnValueChanged(object sender, EventArgs e)
        {
            checkDate();

        }

        private void goodsTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (goodsTypeBox.Text == "Сыпучие")
            {
                keepingForWeekPriceBox.Text = "3000";
            }
            else
                if (goodsTypeBox.Text == "Строительные материалы")
                {
                    keepingForWeekPriceBox.Text = "4000";
                }
                else
                    if (goodsTypeBox.Text == "Продовольственные товары")
                    {
                        keepingForWeekPriceBox.Text = "5000";
                    }
            try
            {
                DateTime dt1 = metroDateTime1.Value;
                DateTime dt2 = metroDateTime2.Value;
                TimeSpan x = dt2 - dt1;
                totalDaysBox.Text = ((int)x.TotalDays).ToString();  //запись  кол-ва дней из timespan в totalDaysTextbox 
                double totalDays = Convert.ToDouble(totalDaysBox.Text); //Конверт на случай, если будут цифры с точкой
                double priceForWeek = Convert.ToDouble(keepingForWeekPriceBox.Text);
                double result = (totalDays / 7) * priceForWeek;  //формула расчета
                result = Math.Round(result, 2);
                keepingSumBox.Text = result.ToString();
                //4000 for week (7 days)


                //    = ((int)x.TotalHours).ToString(); //часы
            }
            catch (Exception ex)
            { }
        }
        
    
        private void goodsTypeBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            goodsTypeBox.Enabled = false;
            goodsTypeBox.Enabled = true;
        }

        private void addPurshaseBtn_Click(object sender, EventArgs e)
        {
            checkFields();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM [PurchaseBills]", sqlConnection);
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];

        }
        public void checkFields()
        {
            if (string.IsNullOrEmpty(companyFromBox.Text) || string.IsNullOrWhiteSpace(fromAdresBox.Text) || string.IsNullOrWhiteSpace(fromCityBox.Text) ||
                string.IsNullOrWhiteSpace(fromPhoneBox.Text) || string.IsNullOrEmpty(fromEmailBox.Text) || string.IsNullOrWhiteSpace(companyToBox.Text) ||
                 string.IsNullOrWhiteSpace(toAdresBox.Text) || string.IsNullOrEmpty(toCityBox.Text) || string.IsNullOrWhiteSpace(toPhoneBox.Text) ||
                  string.IsNullOrWhiteSpace(toEmailBox.Text) || string.IsNullOrEmpty(goodsNameBox.Text) || string.IsNullOrWhiteSpace(weightBox.Text) ||
                  string.IsNullOrWhiteSpace(goodsTypeBox.Text) || string.IsNullOrEmpty(cubageBox.Text) || string.IsNullOrEmpty(metroDateTime1.Text) ||
                  string.IsNullOrEmpty(metroDateTime2.Text) || string.IsNullOrEmpty(keepingForWeekPriceBox.Text) || string.IsNullOrEmpty(totalDaysBox.Text) || string.IsNullOrEmpty(keepingSumBox.Text) ||
                     string.IsNullOrEmpty(loaderCapacityBox.Text) || string.IsNullOrEmpty(loaderTonnageBox.Text))
            {
                MetroMessageBox.Show(this, "Заполните все поля");
                return;
            }
            if (imgList.Image == null)
            {
                MetroMessageBox.Show(this, "Ошибка", "Графический файл не загружен!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                updatePI();
            }
        }

        public void updatePI()
        {
            SqlCommand command = new SqlCommand(@"UPDATE [PurchaseBills] SET companyFrom=@companyFrom,fromAdres=@fromAdres,fromCity=@fromCity,fromPhone=@fromPhone,fromEmail=@fromEmail,
                      companyTo=@companyTo,toAdres=@toAdres,toCity=@toCity,toPhone=@toPhone,toEmail=@toEmail,goodsName=@goodsName,weight=@weight,cubage=@cubage,
                      goodsType=@goodsType,date1=@date1,date2=@date2,keepingForWeekPrice=@keepingForWeekPrice,totalDays=@totalDays,keepingSumBox=@keepingSumBox,carcasType=@carcasType,
                      capacity=@capacity,carrying=@carrying,length=@length,width=@width,height=@height,amount=@amount,carcasMaterial=@carcasMaterial,loadType=@loadType,transportPrice=@transportPrice,
                      loaderType=@loaderType,loaderCapacity=@loaderCapacity,
                      loaderTonnage=@LoaderTonnage WHERE id=@id", sqlConnection);
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

            command.Parameters.AddWithValue("goodsType", goodsTypeBox.Text);
            command.Parameters.AddWithValue("date1", metroDateTime1.Value.ToString("MM/dd/yyyy"));
            command.Parameters.AddWithValue("date2", metroDateTime2.Value.ToString("MM/dd/yyyy"));
            command.Parameters.AddWithValue("keepingForWeekPrice", keepingForWeekPriceBox.Text);
            command.Parameters.AddWithValue("totalDays", totalDaysBox.Text);
            command.Parameters.AddWithValue("keepingSumBox", keepingSumBox.Text);
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
            command.Parameters.AddWithValue("loaderType", loaderTypeBox.Text);
            command.Parameters.AddWithValue("loaderCapacity", loaderCapacityBox.Text);
            command.Parameters.AddWithValue("LoaderTonnage", loaderTonnageBox.Text);
            command.ExecuteNonQuery();
            MetroMessageBox.Show(this, "Информация", "Приходная накладная успешно обновлена, стоимость хранения составляет " + keepingSumBox.Text.ToString() + " грн", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void updateGoodsBtn_Click(object sender, EventArgs e)
        {
            try
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
                SqlCommand command2 = new SqlCommand(@"UPDATE [PurchaseBills] SET image=@image WHERE id =@id", sqlConnection);
                command2.Parameters.AddWithValue("image", images);
                command2.Parameters.AddWithValue("id", idBox.Text);
                command2.ExecuteNonQuery();
            }
            catch { }
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

        private void dateSearchBox_KeyUp(object sender, KeyEventArgs e) //поиск по дате
        {
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM [PurchaseBills] WHERE (date1 LIKE '%" + dateSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void typeSearchBox_KeyUp(object sender, KeyEventArgs e) //поиск по типу товаров
        {
           
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM PurchaseBills WHERE (goodsType LIKE N'%" + typeSearchBox.Text.ToString() + "%')", sqlConnection);
            SqlDataReader dr = dateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;

        }

        private void priceSearchBox_KeyUp(object sender, KeyEventArgs e)//поиск по цене хранения
        {
          
            SqlCommand dateSearch = new SqlCommand("SELECT * FROM PurchaseBills WHERE (keepingSumBox LIKE '%" + priceSearchBox.Text + "%')", sqlConnection);
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
            bunifuGradientPanel3.Select();

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
        }

        private void vilBtn_Click(object sender, EventArgs e)
        {
            loaderTonnageBox.Text = "3000";
            loaderCapacityBox.Text = "5";
            loaderTypeBox.Text = "Вилочный";

        }

        private void kovshBtn_Click(object sender, EventArgs e)
        {
            loaderTonnageBox.Text = "5000";
            loaderCapacityBox.Text = "3";
            loaderTypeBox.Text = "Ковшовый";
        }

        private void updTransrtBtn_Click(object sender, EventArgs e)
        {
            if (contentSlideMenu.Width == 26 && contentSlideMenu.Height == 19)   //26;19
            {

                contentSlideMenu.Visible = true;
                contentSlideMenu.Width = 1271;
                contentSlideMenu.Height = 1100;     //   990; 440      954; 530
                contentSlideMenu.Left = -10;


                //   contentSlideMenu.ShowSync(contentSlideMenu);
            }

            // panelAnimator.ShowSync(slidemenu2);
        
        
        }

        private void updLoaderBtn_Click(object sender, EventArgs e)
        {
            if (loaderSliderMenu.Width == 26 && loaderSliderMenu.Height == 19)   //26;19
            {
                loaderSliderMenu.Left = -10;
                loaderSliderMenu.Visible = true;
                loaderSliderMenu.Width = 1271;
                loaderSliderMenu.Height = 1100;     //   990; 440      954; 530



                //   contentSlideMenu.ShowSync(contentSlideMenu);
            }
            // panelAnimator.S
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaderSliderMenu.Visible = false;
            loaderSliderMenu.Width = 26;
            loaderSliderMenu.Height = 19;
            bunifuGradientPanel3.Select();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            contentSlideMenu.Visible = false;



            contentSlideMenu.Width = 26;
            contentSlideMenu.Height = 19;
            bunifuGradientPanel3.Select();
        }

        private void fromPhoneBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void keepingForWeekPriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,,,\b]");
        }

        private void transportPriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,,,\b]");
        }

        private void keepingForWeekPriceBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DateTime dt1 = metroDateTime1.Value;
                DateTime dt2 = metroDateTime2.Value;
                TimeSpan x = dt2 - dt1;
                totalDaysBox.Text = ((int)x.TotalDays).ToString();  //запись  кол-ва дней из timespan в totalDaysTextbox 
                double totalDays = Convert.ToDouble(totalDaysBox.Text); //Конверт на случай, если будут цифры с точкой
                double priceForWeek = Convert.ToDouble(keepingForWeekPriceBox.Text);
                double result = (totalDays / 7) * priceForWeek;  //формула расчета
                result = Math.Round(result, 2);
                keepingSumBox.Text = result.ToString();
                //4000 for week (7 days)


                //    = ((int)x.TotalHours).ToString(); //часы
            }
            catch (Exception ex)
            { }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM [PurchaseBills]", sqlConnection);
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutRedactPurchaseBills aRPB = new aboutRedactPurchaseBills();
            aRPB.ShowDialog();
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

       

      

    
    }
}

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
    public partial class addPurchaseBill : MetroFramework.Forms.MetroForm
    {
       
        string imgLocation = "";
        //Image target_image;
        //  int Widht;
        //  int Hight;
        SqlConnection sqlConnection;
        public addPurchaseBill()
        {
            InitializeComponent();
        }

        private void addPurchaseInvoice_Load(object sender, EventArgs e)
        {
            addPanel.Select();
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AutoStorage\AutoStorage\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
          //  target_image = imgList.Image;
            addPanel.Select();
         

        }

        private void addPurchaseInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
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
                    else
                        if (goodsTypeBox.Text == "Электронные товары")
                        {
                            keepingForWeekPriceBox.Text = "3500";
                        }
                        else
                            if (goodsTypeBox.Text == "Товары с температурным режимом")
                            {
                                keepingForWeekPriceBox.Text = "2400";
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
            catch  { }
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
            catch { }

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
        private void backToWorkWithBills_Click(object sender, EventArgs e)
        {
            workWithBills wbs = new workWithBills();
            this.Hide();
            wbs.Show();
        }

        private void totalDaysBox_OnValueChanged(object sender, EventArgs e) //вызов ф-ции checkDate 
        {
            checkDate();
        }

        public static Cursor CreateCursor(Bitmap bm, Size size) //Создание метода
        {
            bm = new Bitmap(bm, size);
            bm.MakeTransparent();
            return new Cursor(bm.GetHicon());
        }


        private void imgList_MouseMove(object sender, MouseEventArgs e) //событие входа в picBox
        {
            this.Cursor = CreateCursor((Bitmap)imageList1.Images[0], new Size(26, 26));

        }

        private void imgList_MouseLeave(object sender, EventArgs e) //событие выхода за  пределы
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;

        }

        private void imgList_Click(object sender, EventArgs e)
        {


            //   this.imgList.Size = new System.Drawing.Size(140, 140);


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
            
        }

        private void addPurshaseBtn_Click(object sender, EventArgs e)
        {
            checkFields();
        }


        public void checkFields()
        {
            if (string.IsNullOrEmpty(companyFromBox.Text) || string.IsNullOrWhiteSpace(fromAdresBox.Text) || string.IsNullOrWhiteSpace(fromCityBox.Text) ||
                string.IsNullOrWhiteSpace(fromPhoneBox.Text) || string.IsNullOrEmpty(fromEmailBox.Text) || string.IsNullOrWhiteSpace(companyToBox.Text) ||
                 string.IsNullOrWhiteSpace(toAdresBox.Text) || string.IsNullOrEmpty(toCityBox.Text) || string.IsNullOrWhiteSpace(toPhoneBox.Text) ||
                  string.IsNullOrWhiteSpace(toEmailBox.Text) || string.IsNullOrEmpty(goodsNameBox.Text) || string.IsNullOrWhiteSpace(weightBox.Text) || 
                  string.IsNullOrWhiteSpace(goodsTypeBox.Text) || string.IsNullOrEmpty(cubageBox.Text) ||string.IsNullOrEmpty(metroDateTime1.Text) || 
                  string.IsNullOrEmpty(metroDateTime2.Text) || string.IsNullOrEmpty(keepingForWeekPriceBox.Text) ||
                     string.IsNullOrEmpty(totalDaysBox.Text) || string.IsNullOrEmpty(keepingSumBox.Text) ||
                     string.IsNullOrEmpty(loaderCapacityBox.Text) ||string.IsNullOrEmpty(loaderTonnageBox.Text))
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
                addPI();
            }
        }

        public void addPI()
        {
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);
            SqlCommand command = new SqlCommand(@"INSERT INTO [PurchaseBills] (companyFrom,fromAdres,fromCity,fromPhone,fromEmail,companyTo,toAdres,toCity,toPhone,toEmail,
                       goodsName,weight,cubage,goodsType,date1,date2,keepingForWeekPrice,totalDays,keepingSumBox,carcasType,capacity,carrying,length,width,height,amount,
                        carcasMaterial,loadType,transportPrice,loaderType,loaderCapacity,loaderTonnage,image) 
       VALUES (@companyFrom,@fromAdres,@fromCity,@fromPhone,@fromEmail,@companyTo,@toAdres,@toCity,@toPhone,@toEmail,@goodsName,@weight,@cubage,@goodsType,
                       @date1,@date2,@keepingForWeekPrice,@totalDays,@keepingSumBox,@carcasType,@capacity,@carrying,@length,@width,@height,@amount,
                        @carcasMaterial,@loadType,@transportPrice,@loaderType,@loaderCapacity,@loaderTonnage,@image)", sqlConnection);


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
            command.Parameters.AddWithValue("loaderTonnage", loaderTonnageBox.Text);
            command.Parameters.AddWithValue("image", images);
            command.ExecuteNonQuery();
            MetroMessageBox.Show(this, "Информация", "Приходная накладная успешно добавлена, стоимость хранения составляет " + keepingSumBox.Text.ToString() + " грн", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void setTransprtBtn_Click(object sender, EventArgs e)
        {
            if (contentSlideMenu.Width == 26 && contentSlideMenu.Height == 19)   //26;19
            {
               
                contentSlideMenu.Visible = true;
                contentSlideMenu.Width = 1080;
                contentSlideMenu.Height = 740;     //   990; 440      954; 530
               contentSlideMenu.Left = -10;
                
               
                //   contentSlideMenu.ShowSync(contentSlideMenu);
            }
           
                        // panelAnimator.ShowSync(slidemenu2);
        
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            contentSlideMenu.Visible = false;
          
           
           
            contentSlideMenu.Width = 26;
            contentSlideMenu.Height = 19;
        }

        private void imgBtn1_Click(object sender, EventArgs e)
        {
            carcasTypeBox.Text = "Рефрижератор-Евро";
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
private void vilBtn_Click_1(object sender, EventArgs e)
        {
            loaderTonnageBox.Text = "3000";
            loaderCapacityBox.Text = "5";
            loaderTypeBox.Text = "Вилочный";
        }

        private void kovshBtn_Click_1(object sender, EventArgs e)
        {
            loaderTonnageBox.Text = "5000";
            loaderCapacityBox.Text = "3";
            loaderTypeBox.Text = "Ковшовый";
        }

        private void addPanel_MouseEnter(object sender, EventArgs e)
        {
            addPanel.Select();
        }

        private void setLoaderBtn_Click(object sender, EventArgs e)
        {
            if (loaderSliderMenu.Width == 26 && loaderSliderMenu.Height == 19)   //26;19
            {
                loaderSliderMenu.Left = -10;
                loaderSliderMenu.Visible = true;
                loaderSliderMenu.Width = 1080;
                loaderSliderMenu.Height = 740;     //   990; 440      954; 530
                   
                

                //   contentSlideMenu.ShowSync(contentSlideMenu);
            }
            // panelAnimator.ShowSync(slidemenu2);
        }
       

       

        private void addPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            loaderSliderMenu.Visible = false;
            loaderSliderMenu.Width = 26;
            loaderSliderMenu.Height = 19;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            StartLogin st = new StartLogin();
            this.Hide();
            st.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutAddPurchaseBills abs = new aboutAddPurchaseBills();
            abs.ShowDialog();
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

        private void imgBtn2_Click(object sender, EventArgs e)  //ДА
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

        private void imgBtn3_Click(object sender, EventArgs e)//ДА
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

        private void imgBtn4_Click(object sender, EventArgs e)//DA
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

        private void imgBtn21_Click(object sender, EventArgs e)//ДА
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

        private void imgBtn22_Click(object sender, EventArgs e)//ДА
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

        private void imgBtn31_Click(object sender, EventArgs e)//ДА
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

        private void imgBtn32_Click(object sender, EventArgs e)//ДА
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

        private void imgBtn33_Click(object sender, EventArgs e)////ДА
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

        private void keepingForWeekPriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,,,\b]");
        }

        private void transportPriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,,,\b]");
        }

       

        
     

      
     

       
     
       
    }
}

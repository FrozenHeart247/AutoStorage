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
    public partial class addWayBill : MetroFramework.Forms.MetroForm
    {
        string imgLocation = "";
        SqlConnection sqlConnection;
        public addWayBill()
        {
            InitializeComponent();
        }

        private void addWayBill_Load(object sender, EventArgs e)
        {
            if (topPanel.Width == 1096 && addPanel.Height == 48) // 1096; 563  ///1096; 48
            {
                topPanel.Visible = false;
                topPanel.Width = 1097;
                topPanel.Height = 49;


                addPanelAnimator.ShowSync(topPanel);
            }
            else
            {
                topPanel.Visible = true;
                topPanel.Width = 1096;
                topPanel.Height = 48;
            }



            metroDateTime1.CustomFormat = "dd/MM/yyyy";
            metroDateTime1.Format = DateTimePickerFormat.Custom;
            addPanel.Select();
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AutoStorage\AutoStorage\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            /*
            SqlConnection sqlConnection;
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Frozen_Heart\Documents\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30");
            string imgLocation = "";
            SqlCommand cmd;
            */
        }
        
      

        private  void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (contentSlideMenu.Width == 26 && contentSlideMenu.Height == 19)   //26;19
            {
                contentSlideMenu.Visible = true;
                contentSlideMenu.Width = 1115;
                contentSlideMenu.Height = 740;     //   990; 440      954; 530
                contentSlideMenu.Left = -30;
                groupBox4.Visible = false;




             //   contentSlideMenu.ShowSync(contentSlideMenu);
            }
            else
            {
                
                contentSlideMenu.Visible = false;
                contentSlideMenu.Width = 26;
                contentSlideMenu.Height = 19;


                // panelAnimator.ShowSync(slidemenu2);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            contentSlideMenu.Visible = false;
            contentSlideMenu.Width = 26;
            contentSlideMenu.Height = 19;
            groupBox4.Visible = true;
            addPanel.Select();
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
            try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                consumptionBox.Text = result.ToString();
                
            }
            catch 
            { 
                return; 
            }

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
            try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                consumptionBox.Text = result.ToString();

            }
            catch
            {
                return;
            }

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
            try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                consumptionBox.Text = result.ToString();

            }
            catch
            {
                return;
            }

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
            try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                consumptionBox.Text = result.ToString();

            }
            catch
            {
                return;
            }
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
            try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                consumptionBox.Text = result.ToString();

            }
            catch
            {
                return;
            }
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
            try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                consumptionBox.Text = result.ToString();

            }
            catch
            {
                return;
            }
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
            try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                consumptionBox.Text = result.ToString();

            }
            catch
            {
                return;
            }
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
            try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                consumptionBox.Text = result.ToString();

            }
            catch
            {
                return;
            }
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
            try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                consumptionBox.Text = result.ToString();

            }
            catch
            {
                return;
            }
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
        private void addBillBtn_Click_1(object sender, EventArgs e)
        {
            checkFields();
        }
        public void checkFields()
        {
            if (string.IsNullOrEmpty(companyFromBox.Text) || string.IsNullOrWhiteSpace(fromAdresBox.Text) || string.IsNullOrWhiteSpace(fromCityBox.Text) ||
                string.IsNullOrWhiteSpace(fromPhoneBox.Text) || string.IsNullOrEmpty(fromEmailBox.Text) || string.IsNullOrWhiteSpace(companyToBox.Text) ||
                 string.IsNullOrWhiteSpace(toAdresBox.Text) || string.IsNullOrEmpty(toCityBox.Text) || string.IsNullOrWhiteSpace(toPhoneBox.Text) ||
                  string.IsNullOrWhiteSpace(toEmailBox.Text) || string.IsNullOrEmpty(goodsNameBox.Text)  ||string.IsNullOrWhiteSpace(weightBox.Text) ||
                  string.IsNullOrWhiteSpace(goodsTypeBox.Text) || string.IsNullOrEmpty(cubageBox.Text) || string.IsNullOrWhiteSpace(carcasTypeBox.Text) ||
                  string.IsNullOrEmpty(capacityBox.Text) || string.IsNullOrWhiteSpace(carryingBox.Text) ||string.IsNullOrWhiteSpace(lengthBox.Text) || 
                  string.IsNullOrEmpty(widthBox.Text) || string.IsNullOrWhiteSpace(heighBox.Text) || string.IsNullOrWhiteSpace(amountBox.Text) ||
                  string.IsNullOrEmpty(carcasMaterialBox.Text) || string.IsNullOrWhiteSpace(loadTypeBox.Text) ||
                       string.IsNullOrEmpty(transportPriceBox.Text))
            {
                MetroMessageBox.Show(this, "Заполните все поля");
                return;
            }
            if (imgList.Image == null)
            {
                MetroMessageBox.Show(this, "Ошибка", "Графический файл не загружен!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double a;
            a = Convert.ToDouble(weightBox.Text);
            if (a > 25 && carcasTypeBox.Text == "Рефрижератор-Евро")
                {
                    MetroMessageBox.Show(this, "Ошибка", "Данный тип перевозчика не может вместить данный вес(исправить)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                addBill();
            }
        }
        public void addBill()
        {

             byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);
        SqlCommand command = new SqlCommand(@"INSERT INTO [WayBills] (companyFrom,fromAdres,fromCity,fromPhone,fromEmail,
                companyTo,toAdres,toCity,toPhone,toEmail,goodsName,weight,cubage,goodsType,
                date,consumption,carcasType,capacity,carrying,length,width,height,amount,carcasMaterial,loadType,transportPrice,image) 
        VALUES (@companyFrom,@fromAdres,@fromCity,@fromPhone,@fromEmail,@companyTo,@toAdres,@toCity,@toPhone,
                @toEmail,@goodsName,@weight,@cubage,@goodsType,
                @date,@consumption,@carcasType,@capacity,@carrying,@length,@width,@height,@amount,@carcasMaterial,@loadType,@transportPrice,@image)", sqlConnection);

           
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
            command.Parameters.AddWithValue("date", metroDateTime1.Value.ToString("MM/dd/yyyy"));
            command.Parameters.AddWithValue("consumption", consumptionBox.Text);
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
            command.Parameters.AddWithValue("@image", images);
            command.ExecuteNonQuery();
            MetroMessageBox.Show(this, "Information", "Расходная накладная успешно добавлена, стоимость перегрузки составляет " + consumptionBox.Text.ToString() + " грн", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      

        private void backToWorkWithBills_Click(object sender, EventArgs e)
        {
            workWithBills wwb = new workWithBills();
            this.Hide();
            wwb.Show();
        }

     

        private void addWayBill_FormClosing(object sender, FormClosingEventArgs e)
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
                consumptionBox.Text = result.ToString();
            }
            catch (Exception ex)
            { }
        }

        private void goodsTypeBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            goodsTypeBox.Enabled = false;
            goodsTypeBox.Enabled = true;
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

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutAddWayBills abw = new aboutAddWayBills();
            abw.ShowDialog();
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

        private void transportPriceBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double weight = Convert.ToDouble(weightBox.Text);
                double transportPrice = Convert.ToDouble(transportPriceBox.Text);
                double result = weight * transportPrice;
                consumptionBox.Text = result.ToString();
            }
            catch (Exception ex)
            { }
        }

 
       

       
       

     //  MM/dd/yyyy HH:MM:SS
       

              /*
        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            addTxt();
        }


       public void addTxt()
        {
           // MetroFramework.Controls.MetroTextBox[] tb = new MetroFramework.Controls.MetroTextBox[Convert.ToInt32(txtCount.Text)]; //В textBox1 вводим количество строк
            Bunifu.Framework.UI.BunifuMaterialTextbox[] tb = new Bunifu.Framework.UI.BunifuMaterialTextbox[Convert.ToInt32(txtCount.Text)]; 
           for (int i = 0; i < tb.Length; i++)
            {
              //  tb[i] = new MetroFramework.Controls.MetroTextBox();
                tb[i] = new Bunifu.Framework.UI.BunifuMaterialTextbox();                
               tb[i].Location = new System.Drawing.Point(301, 450 + i * 30);
                tb[i].Name = "textBox" + i.ToString();
                tb[i].Size = new System.Drawing.Size(75, 23);
                tb[i].TabIndex = i;
                tb[i].Text = "textBox" + i.ToString();
                Controls.Add(tb[i]);
            }
        }
              /* 
                TextBox[] tb = new TextBox[20];

                for (int i = 0; i < tb.Length; i++)
                {
                    tb[i] = new TextBox();
                    tb[i].Location = new System.Drawing.Point(300, 300);
                    //бла-бла-бла
                    tb[i].BringToFront();
                    Controls.Add(tb[i]);
                }

            }

         */
              

    

    



     
       

      
    }
}

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
using System.Runtime.InteropServices;

namespace AutoStorage
{
    public partial class financerBillsLookUp : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public financerBillsLookUp()
        {
            InitializeComponent();
        }

        private void financerBillsLookUp_Load(object sender, EventArgs e)
        {
            imgList.SizeMode = PictureBoxSizeMode.StretchImage;
            metroGrid2.Visible = false;

            cmpnFromSearchBox.Visible = false;
            gdstpFromSearchBox.Visible = false;
            daysCountFromSearchBox.Visible = false;
            kpngPriceSearchBox.Visible = false;
            arrivaDateSearchBox.Visible = false;
            lookWayBillsBtn.Visible = false;
            createXLS2Btn.Visible = false;

            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AutoStorage\AutoStorage\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM [WayBills]", sqlConnection);
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            /**/
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = new SqlCommand("SELECT * FROM [PurchaseBills]", sqlConnection);
            da2.Fill(ds2);
            metroGrid2.DataSource = ds2.Tables[0];
            metroGrid1.Columns[0].Visible = false;
            metroGrid1.Columns[17].Visible = false;
            metroGrid2.Columns[0].Visible = false;
            metroGrid2.Columns[17].Visible = false;

            //////////////////GRID 1
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

            ////////////////GRID2
            metroGrid2.Columns[1].HeaderText = "Отправляющая компания";
            metroGrid2.Columns[2].HeaderText = "Адрес компании";
            metroGrid2.Columns[3].HeaderText = "Город отправки";
            metroGrid2.Columns[4].HeaderText = "Телфон отправляющей компании";
            metroGrid2.Columns[5].HeaderText = "Email отправляющей компании";
            metroGrid2.Columns[6].HeaderText = "Получающая компания";
            metroGrid2.Columns[7].HeaderText = "Адрес компании";
            metroGrid2.Columns[8].HeaderText = "Город получения";
            metroGrid2.Columns[9].HeaderText = "Телефон получающей компании";
            metroGrid2.Columns[10].HeaderText = "Email получающей компании";
            metroGrid2.Columns[11].HeaderText = "Имя группы товаров";
            metroGrid2.Columns[12].HeaderText = "Вес, т";
            metroGrid2.Columns[13].HeaderText = "Кубатура";
            metroGrid2.Columns[14].HeaderText = "Тип товаров";
            metroGrid2.Columns[15].HeaderText = "Дата прибытия на склад";
            metroGrid2.Columns[16].HeaderText = "Дата отправки со склада";
            //img 17
            metroGrid2.Columns[18].HeaderText = "Цена хранения за неделю";
            metroGrid2.Columns[19].HeaderText = "Кол-во дней";
            metroGrid2.Columns[20].HeaderText = "Стоимость хранения";
            metroGrid2.Columns[21].HeaderText = "Тип перевозчика";
            metroGrid2.Columns[22].HeaderText = "Вместимость перевозчика";
            metroGrid2.Columns[23].HeaderText = "Грузоподъемность";
            metroGrid2.Columns[24].HeaderText = "Длина, м";
            metroGrid2.Columns[25].HeaderText = "Ширина, м";
            metroGrid2.Columns[26].HeaderText = "Высота, м";
            metroGrid2.Columns[27].HeaderText = "Объем, м3";
            metroGrid2.Columns[28].HeaderText = "Материал кузова";
            metroGrid2.Columns[29].HeaderText = "Способы загрузки";
            metroGrid2.Columns[30].HeaderText = "Цена перевозки за 1 тонну";
            metroGrid2.Columns[31].HeaderText = "Тип погрузчика";
            metroGrid2.Columns[32].HeaderText = "Вместимость погрузчика";
            metroGrid2.Columns[33].HeaderText = "Грузоподъемность погрузчика";
        }

       

      
       private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                imgList.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])metroGrid1.Rows[e.RowIndex].Cells[17].Value));
            }
            catch { }
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {
           try
           {
               imgList.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])metroGrid2.Rows[e.RowIndex].Cells[17].Value));
           }
           catch { }
        }
        /// ////////////////////////////////////////WayBills
        private void cmpnFromSearchBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void gdstpFromSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand gdsTypeSearch = new SqlCommand("SELECT * FROM [WayBills] WHERE (goodsType LIKE N'%" + gdsTypeSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = gdsTypeSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void daysCountFromSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand daysCountFromSearch = new SqlCommand("SELECT * FROM [WayBills] WHERE (totalDays LIKE N'%" + daysCountFromSearchBox.Text + "%')", sqlConnection);

            SqlDataReader dr = daysCountFromSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid2.DataSource = dt;
        }

        private void kpngPriceSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand kpngPriceSearch = new SqlCommand("SELECT * FROM [WayBills] WHERE (keepingSumBox LIKE N'%" + kpngPriceSearchBox.Text + "%')", sqlConnection);

            SqlDataReader dr = kpngPriceSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid2.DataSource = dt;
        }

        private void arrivaDateSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand arrivaDateSearch = new SqlCommand("SELECT * FROM [WayBills] WHERE (date1 LIKE N'%" + arrivaDateSearchBox.Text + "%')", sqlConnection);

            SqlDataReader dr = arrivaDateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid2.DataSource = dt;
        }
        //////////////////////////////////////////////PurchaseBills

        private void financerBillsLookUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void cmpnToSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmpnToFromSearch = new SqlCommand("SELECT * FROM [PurchaseBills] WHERE (companyFrom LIKE N'%" + cmpnFromSearchBox.Text + "%')", sqlConnection);

            SqlDataReader dr = cmpnToFromSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid2.DataSource = dt;
        }

        private void gdsTypeSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand gdstpFromSearch = new SqlCommand("SELECT * FROM [PurchaseBills] WHERE (goodsType LIKE N'%" + gdstpFromSearchBox.Text + "%')", sqlConnection);

            SqlDataReader dr = gdstpFromSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid2.DataSource = dt;

        }

        private void trnsprtTypeSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand daysCountFromSearch = new SqlCommand("SELECT * FROM [PurchaseBills] WHERE (totalDays LIKE N'%" + daysCountFromSearchBox.Text + "%')", sqlConnection);

            SqlDataReader dr = daysCountFromSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid2.DataSource = dt;
        }
        //////////////////////////////////////////////////////////////WayBill
        private void cmpnToSearchBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            SqlCommand cmpnToSearch = new SqlCommand("SELECT * FROM [WayBills] WHERE (companyTo LIKE N'%" + cmpnToSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = cmpnToSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
            return;
        }

        private void gdsTypeSearchBox_KeyUp_1(object sender, KeyEventArgs e)  //типу товаров
        {
            SqlCommand gdsTypeSearch = new SqlCommand("SELECT * FROM [WayBills] WHERE (goodsType LIKE N'%" + gdsTypeSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = gdsTypeSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void trnsprtTypeSearchBox_KeyUp_1(object sender, KeyEventArgs e) //поиск по типу перевозчика
        {
            SqlCommand trnsprtTypeSearch = new SqlCommand("SELECT * FROM [WayBills] WHERE (carcasType LIKE N'%" + trnsprtTypeSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = trnsprtTypeSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void priceSearchBox_KeyUp(object sender, KeyEventArgs e) //поиск по цене перевозки
        {
            SqlCommand priceSearch = new SqlCommand("SELECT * FROM [WayBills] WHERE (consumption LIKE '%" + priceSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = priceSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void dateSearchBox_KeyUp(object sender, KeyEventArgs e)  //поиск по дате отправки
        {
            SqlCommand priceSearch = new SqlCommand("SELECT * FROM [WayBills] WHERE (date LIKE '%" + dateSearchBox.Text + "%')", sqlConnection);
            SqlDataReader dr = priceSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void cmpnFromSearchBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            SqlCommand cmpnToFromSearch = new SqlCommand("SELECT * FROM [PurchaseBills] WHERE (companyFrom LIKE N'%" + cmpnFromSearchBox.Text + "%')", sqlConnection);

            SqlDataReader dr = cmpnToFromSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid2.DataSource = dt;
        }

        private void gdstpFromSearchBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            SqlCommand gdstpFromSearch = new SqlCommand("SELECT * FROM [PurchaseBills] WHERE (goodsType LIKE N'%" + gdstpFromSearchBox.Text + "%')", sqlConnection);

            SqlDataReader dr = gdstpFromSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid2.DataSource = dt;
        }

        private void daysCountFromSearchBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            SqlCommand daysCountFromSearch = new SqlCommand("SELECT * FROM [PurchaseBills] WHERE (totalDays LIKE N'%" + daysCountFromSearchBox.Text + "%')", sqlConnection);

            SqlDataReader dr = daysCountFromSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid2.DataSource = dt;
        }

        private void kpngPriceSearchBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            SqlCommand kpngPriceSearch = new SqlCommand("SELECT * FROM [PurchaseBills] WHERE (keepingSumBox LIKE N'%" + kpngPriceSearchBox.Text + "%')", sqlConnection);

            SqlDataReader dr = kpngPriceSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid2.DataSource = dt;
        }

        private void arrivaDateSearchBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            SqlCommand arrivaDateSearch = new SqlCommand("SELECT * FROM [PurchaseBills] WHERE (date1 LIKE N'%" + arrivaDateSearchBox.Text + "%')", sqlConnection);

            SqlDataReader dr = arrivaDateSearch.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid2.DataSource = dt;
        }

        private void backToWorkWithBills_Click(object sender, EventArgs e)
        {
            finansersMenu fM = new finansersMenu();
            this.Hide();
            fM.Show();
        }

        private void createXLSBtn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Report";

            for (int i = 1; i < metroGrid1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = metroGrid1.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < metroGrid1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < metroGrid1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = metroGrid1.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Report";
            saveFileDialog.DefaultExt = "xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM [WayBills]", sqlConnection);
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            /**/
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = new SqlCommand("SELECT * FROM [PurchaseBills]", sqlConnection);
            da2.Fill(ds2);
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            billsLookup bL = new billsLookup();
            this.Hide();
            bL.Show();
        }

      

       

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            lookUpStorages lUS = new lookUpStorages();
            this.Hide();
            lUS.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Home2 h2 = new Home2();
            this.Hide();
            h2.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            StartLogin st = new StartLogin();
            this.Hide();
            st.Show();
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

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutFinansersBillLookUp afblp = new aboutFinansersBillLookUp();
            afblp.ShowDialog();
        }

        private void createXLS2Btn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Report";

            for (int i = 1; i < metroGrid2.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = metroGrid2.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < metroGrid2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < metroGrid2.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = metroGrid2.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Report";
            saveFileDialog.DefaultExt = "xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }
        private void lookPurchBtn_Click(object sender, EventArgs e)
                {
                    metroGrid1.Visible = false;
                    imgList.Image = null;
                    cmpnToSearchBox.Visible = false;
                    gdsTypeSearchBox.Visible = false;
                    trnsprtTypeSearchBox.Visible = false;
                    priceSearchBox.Visible = false;
                    dateSearchBox.Visible = false;
                    createXLSBtn.Visible = false;
           


                    lookPurchBtn.Visible = false;
                    /**/
                    metroGrid2.Visible = true;
                    cmpnFromSearchBox.Visible = true;
                    gdstpFromSearchBox.Visible = true;
                    daysCountFromSearchBox.Visible = true;
                    kpngPriceSearchBox.Visible = true;
                    arrivaDateSearchBox.Visible = true;
                    lookWayBillsBtn.Visible = true;
                    createXLS2Btn.Visible = true;
            
                }
        private void lookWayBillsBtn_Click(object sender, EventArgs e)
        {
            metroGrid1.Visible = true;
            imgList.Image = null;
            cmpnToSearchBox.Visible = true;
            gdsTypeSearchBox.Visible = true;
            trnsprtTypeSearchBox.Visible = true;
            priceSearchBox.Visible = true;
            dateSearchBox.Visible = true;
            lookPurchBtn.Visible = true;
            createXLSBtn.Visible = true;
            

            /**/
            metroGrid2.Visible = false;
            cmpnFromSearchBox.Visible = false;
            gdstpFromSearchBox.Visible = false;
            daysCountFromSearchBox.Visible = false;
            kpngPriceSearchBox.Visible = false;
            arrivaDateSearchBox.Visible = false;
            lookWayBillsBtn.Visible = false;
            createXLS2Btn.Visible = false;
          ;
        }

        



       
  
        

      
       
    }
}

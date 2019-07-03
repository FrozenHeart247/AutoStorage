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

namespace AutoStorage
{
    class ConnectionSql
    {
        public string queryString;
        string myConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Frozen_Heart\Documents\AutoStorage.mdf;Integrated Security=True;Connect Timeout=30";
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public void SetTable()//для редактирования базы
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(myConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    int number = command.ExecuteNonQuery();
                }

            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public void GetTable()//для запросов
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(myConnectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    dt = ds.Tables[0];
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public void GetList(string nameTable)
        {
            try
            {
                SqlConnection conDataBase = new SqlConnection(myConnectionString);
                SqlCommand cmdDataBase = new SqlCommand(queryString, conDataBase);
                cmdDataBase.CommandText = queryString;
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                ds = new DataSet();
                conDataBase.Open();
                sda.Fill(ds, nameTable);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
    }
}

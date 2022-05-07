using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Windows.Forms;

namespace WebApplication1
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }
        [WebMethod]
        public int Minus(int a, int b)
        {
            return a - b;
        }
        [WebMethod]
        public int Umn(int a, int b)
        {

            return a * b;
        }
        [WebMethod]
        public float Del(int a, int b)
        {
            if (b == 0)
            {
                MessageBox.Show("Error!!Попытка деления на 0");
                return 0;
            }
            else return a / b;

        }
        [WebMethod]
        public DataSet GetCustomers()
        {
            SqlConnection con;
            SqlDataAdapter mydataAdapter;
            DataSet myDS;
            String cmdString = "Select *from Заказчики";
            con = new SqlConnection(@"Server = DESKTOP-6BD9S0J\SQLEXPRESS01; uid =UserAdmin; pwd=123;database=TradeCompany");
            mydataAdapter = new SqlDataAdapter(cmdString, con);
            myDS = new DataSet();
            mydataAdapter.Fill(myDS, "Заказчики");
            return myDS;


        }
    }
}

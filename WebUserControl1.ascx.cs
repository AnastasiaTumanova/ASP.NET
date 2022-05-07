using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Plus_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient wb = new ServiceReference1.WebService1SoapClient();
            Res.Text = wb.Add(Convert.ToInt32(Num1.Text), Convert.ToInt32(Num2.Text)).ToString();
        }

        protected void Minus_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient wb = new ServiceReference1.WebService1SoapClient();
            Res.Text = wb.Minus(Convert.ToInt32(Num1.Text), Convert.ToInt32(Num2.Text)).ToString();
        }

        protected void Umn_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient wb = new ServiceReference1.WebService1SoapClient();
            Res.Text = wb.Umn(Convert.ToInt32(Num1.Text), Convert.ToInt32(Num2.Text)).ToString();
        }

        protected void Del_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient wb = new ServiceReference1.WebService1SoapClient();
            Res.Text = wb.Del(Convert.ToInt32(Num1.Text), Convert.ToInt32(Num2.Text)).ToString();
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            Num1.Text = "";
            Num2.Text = "";
            Res.Text = "";
        }

        protected void GetCus_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient wb = new ServiceReference1.WebService1SoapClient();
            GridView1.DataSource = wb.GetCustomers();
            GridView1.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vize
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sayac = 0,s=0;

            int sayi1 = Convert.ToInt32(TextBox1.Text);
    

            int sayi2 = Convert.ToInt32(TextBox2.Text);


            if (sayi1 < sayi2)
            {
                sayac = sayi1;
            }
            else
            {
                sayac = sayi2;
            }
            for(int i = 2; i <= sayac; i++)
            {
                if(sayi1%i==0 && sayi2 % i == 0)
                {
                    s = 1;
                }
            }
            if (s == 0)
            {
                Label1.Text = sayi1 + " ve " + sayi2 + " aralarında asaldır";
            }
            else
            {
                Label1.Text = sayi1 + " ve " + sayi2 + " aralarında asal değildir";
            }
        }
    }
}
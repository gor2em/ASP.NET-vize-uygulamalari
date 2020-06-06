using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vize
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.Enabled = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int girilenSayi = int.Parse(TextBox1.Text);
            for (int i = 1; i < 11; i++)
                ListBox1.Items.Add(girilenSayi + " x " + i + " = " + girilenSayi * i);
            ListBox1.Enabled = true;
        }
    }
}
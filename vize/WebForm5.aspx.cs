using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vize
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] st = new string[10];
            Label1.Text = "";
            st[0] = TextBox1.Text;
            st[1] = TextBox2.Text;
            st[2] = TextBox3.Text;
            st[3] = TextBox4.Text;
            st[4] = TextBox5.Text;
            st[5] = TextBox6.Text;
            st[6] = TextBox7.Text;
            st[7] = TextBox8.Text;
            st[8] = TextBox9.Text;
            st[9] = TextBox10.Text;

            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == "a" || st[i] == "A")
                {
                    Label1.Text += "<span style=background:red>" + st[i] + "</span>";
                }
                else if (st[i] == "t" || st[i] == "T")
                {
                    Label1.Text += "<span style=background:green>" + st[i] + "</span>";
                }
                else if (st[i] == "ü" || st[i] == "Ü")
                {
                    Label1.Text += "<span style=background:yellow>" + st[i] + "</span>";
                }
                else if (st[i] == "e" || st[i] == "E")
                {
                    Label1.Text += "<span style=background:cyan>" + st[i] + "</span>";
                }
                else
                {
                    Label1.Text += "<span style=background:none;color:white>" + st[i] + "</span>";
                }
            }
        }

    }
}
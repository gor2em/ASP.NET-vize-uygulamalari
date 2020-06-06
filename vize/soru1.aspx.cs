using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vize
{
    public partial class soru1 : System.Web.UI.Page
    {
        Random rnd = new Random();

        public Color BackColor { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_yazdir_Click(object sender, EventArgs e)
        {
            string metin = TextBox1.Text;
            Label1.Text = "";
            foreach (char harf in metin.ToCharArray())
            {
                int sayac = 0;
                for (int i = 0; i < metin.Length; i++)
                {
                    if (metin[i] == harf)
                    {
                        sayac++;
                    }

                }
                if (sayac >= 2)
                {
                    Label1.Text += "<span class='bg'>" + harf + "</span>";

                }
                else
                {
                    Label1.Text += "<span style=background:white>" + harf + "</span>";
                }
            }
        }


    }
}

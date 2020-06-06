using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vize
{
    public partial class soru3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            s3();
        }

        protected void btn_degis_Click(object sender, EventArgs e)
        {
            s3();
        }
        private void s3()
        {

            string[] resimler = { "~/images/Turkey.GIF", "~/images/Uruguay.GIF", "~/images/Uganda.GIF", "~/images/Sudan.GIF", "~/images/Sweden.GIF"};
            Random rnd = new Random();
            int uret;
            resim1.ImageUrl = resimler[uret = rnd.Next(5)]; resim2.ImageUrl = resimler[uret = rnd.Next(5)]; resim3.ImageUrl = resimler[uret = rnd.Next(5)];
            if (resim1.ImageUrl == resim2.ImageUrl && resim1.ImageUrl == resim3.ImageUrl)
            {
                btn_degis.Text = "EŞİTLENDİ!!!";
            }
            else btn_degis.Text = "Değiştir";
        }
    }
}
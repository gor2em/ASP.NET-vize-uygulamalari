using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vize
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            kucuksebuyukyap();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int uzunluk = TextBox1.Text.Length;
            for (int i = 1; i < 2 * uzunluk;)
            {
                TextBox1.Text = TextBox1.Text.Insert(i, " ");
                i = i + 2;
            }
        }
        private void kucuksebuyukyap()
        {
            
            string[] Harfler = new[] { "ğ", "ç", "ş","Ğ", "Ç", "Ş"};
            string txtMetin = TextBox1.Text;
            if (Harfler.Any(txtMetin.Contains))
            {
              
                //"ğ", "ç", "ş","Ğ", "Ç", "Ş" türkçe karakter var ise
            }
            else
            {
                Label1.Text = TextBox1.Text.ToUpper();
               //türkçe karakter yok isee
            }
        }
    }
}
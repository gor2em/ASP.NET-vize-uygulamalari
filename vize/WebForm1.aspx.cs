using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vize
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                for (int i = 0; i < 12; i++)
                {
                    DropDownList1.Items.Add(CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.MonthNames[i]);
                }
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int yil = Convert.ToInt32(TextBox1.Text);
            int ay = 0, a = 1, i = 1 ,tblRows = 5, tblCols = 7;
            for (int y = 0; y < 12; y++)
            {
                if (DropDownList1.Text == CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.MonthNames[y])
                {
                    ay = y;
                }
            }
            DateTime gun = new DateTime(yil, ay + 1, 1);
            int x = DateTime.DaysInMonth(yil, ay + 1);
            PlaceHolder1.Controls.Clear();
            Table tbl = new Table();
            PlaceHolder1.Controls.Add(tbl);
            for (int z = 0; z < tblRows; z++)
            {
                TableRow tr = new TableRow();
                for (int j = 0; j < tblCols; j++)
                {
                    TableCell tc = new TableCell();
                    TextBox txt = new TextBox();
                    txt.Enabled = false;
                    if (a % 2 == 0) txt.BackColor = System.Drawing.Color.GreenYellow; else { txt.BackColor = System.Drawing.Color.GhostWhite; }
                    i = a;
                    while (i <= x)
                    {
                        txt.Text = gun.Day + " " + DropDownList1.Text + " " + CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)gun.DayOfWeek];
                        gun = gun.AddDays(1);
                        a++;
                        break;
                    }

                    tc.Controls.Add(txt);
                    tr.Cells.Add(tc);
                }
                tbl.Rows.Add(tr);

                }
        }
    }
}
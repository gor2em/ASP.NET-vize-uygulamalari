using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace vize
{
    public partial class soru2 : System.Web.UI.Page
    {
        //protected int Rows
        //{
        //    get { return ViewState["Rows"] != null ? (int)ViewState["Rows"] : 0; }
        //    set { ViewState["Rows"] = value; }
        //}

        //protected int Columns
        //{
        //    get { return ViewState["Columns"] != null ? (int)ViewState["Columns"] : 0; }
        //    set { ViewState["Columns"] = value; }
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Page.IsPostBack)
            //{
            //    this.Rows = int.Parse(txtRow.Text);
            //    this.Columns = int.Parse(txtCol.Text);
            //}
            createRun_Table();
        }

        protected void btnRun_Click(object sender, EventArgs e)
        {
            createRun_Table();
        }
        private void createRun_Table()
        {

            int yil = int.Parse(txtYil.Text);

            int tblRows = 5;
            int tblCols = 7;

            PlaceHolder1.Controls.Clear();



            Table tbl = new Table();
          
            PlaceHolder1.Controls.Add(tbl);



            TableHeaderRow header = new TableHeaderRow(); // Creating a header row
            tbl.Rows.Add(header); // Add the header row to table tbl 

            int sayac = 0;
            for (int i = 0; i < tblRows; i++)
            {
                
                TableRow tr = new TableRow();
               
                for (int j = 0; j < tblCols; j++)
                {
                    TableCell tc = new TableCell();
                    TextBox txt = new TextBox();
                    sayac++;
                    txt.Text = " "+sayac;







                    tc.Controls.Add(txt);
                    tr.Cells.Add(tc);

                }

                tbl.Rows.Add(tr);

            }


        }
    }
}
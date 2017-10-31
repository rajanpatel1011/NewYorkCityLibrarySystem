using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace NYCLib
{
    public partial class ReaderFine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ReaderID"] == null)
            {
                Response.Redirect("Default.aspx");
            }
                bindFine();
            bindTotelFine();

        }
        public void bindFine()
        {
            int ReaderID = 0;
            if (!string.IsNullOrEmpty(Session["ReaderID"].ToString()))
            {
                ReaderID = Convert.ToInt32(Session["ReaderID"].ToString());
            }



            if (ReaderID != 0)
            {

                string query = "select bk.BookID,bk.BookTitle,res.BorrowId,res.ReservedId,res.fine from tblReserved as res inner join NYCLIB.dbo.tblBorrow as bor on res.BorrowId=bor.BorrowID inner join tblBook as bk on bor.BookId = bk.BookID where res.ReaderId="+ReaderID+"";
                DataSet ds = dataconnection.get_data(query, CommandType.Text, null);
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count>0)
                    {
                        FineGrid.DataSource = ds;
                        FineGrid.DataBind(); 
                    }
                }

            }
        }
        public void bindTotelFine()
        {
            int ReaderID = 0;
            if (!string.IsNullOrEmpty(Session["ReaderID"].ToString()))
            {
                ReaderID = Convert.ToInt32(Session["ReaderID"].ToString());
            }



            if (ReaderID != 0)
            {
                string query = "SELECT SUM(fine) as Total from tblReserved where ReaderId="+ReaderID+"";
                DataSet ds = dataconnection.get_data(query, CommandType.Text, null);
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        TotalFineGrid.DataSource = ds;
                        TotalFineGrid.DataBind();
                    }
                }
            }
        }
    }
}
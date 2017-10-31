using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace NYCLib
{
    public partial class BookReturn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ReaderID"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            if(!Page.IsPostBack)
            bindReturnBook();
        }
        public void bindReturnBook()
        {
            int ReaderID = 0;
            if (!string.IsNullOrEmpty(Session["ReaderID"].ToString()))
            {
                ReaderID = Convert.ToInt32(Session["ReaderID"].ToString());
            }



            if (ReaderID != 0)
            {
                string query = "SELECT * from tblBorrow as b inner join tblBook as bo on bo.BookID=b.BookId  inner join tblPublisher as p on p.PublisherId=bo.PublisherID Where b.IsReturned = 0 and b.ReaderID =" + ReaderID + "";
                DataSet ds = dataconnection.get_data(query, CommandType.Text, null);
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ReturnGrid.DataSource = ds;
                        ReturnGrid.DataBind();

                    }

                }
                else
                {
                    Response.Redirect("default.aspx");
                }
                pnlgrid.Visible = true;
                pnlform.Visible = false;


            }
        }
        protected void btnReturnBook_click(object sender, EventArgs e)
        {

        }
        protected void gvBorrowId_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("returnBook"))
            {
                int readerID = 0;
                if (!string.IsNullOrEmpty(Session["ReaderID"].ToString()))
                    readerID = Convert.ToInt32(Session["ReaderID"].ToString());
                if (readerID != 0)
                {
                    string[] s = e.CommandArgument.ToString().Split('-');
                    int BorrowID = Convert.ToInt32(s[0]);
                    DateTime retdate = Convert.ToDateTime(s[1]);
                    DateTime today = DateTime.Now;

                    if (today.Date > retdate.Date)
                    {
                        double fine = calculateFine(retdate);
                        string query1 = "insert into tblReserved values("+ BorrowID + ","+readerID+","+fine+")";
                        dataconnection.Execute_NonQuery(query1, CommandType.Text, null);
                    }
                    string query = "update  tblBorrow set IsReturned = 1 where BorrowID=" + BorrowID ;
                    bool b = dataconnection.Execute_NonQuery(query, CommandType.Text, null);
                    if (b)
                    {
                        Response.Redirect("BookCheckout.aspx");
                    }
                }
            }
        }

        public double calculateFine(DateTime returnDate)
        {
            double fine = 0;
            DateTime today = DateTime.Now;
            double latedays = (today.Date - returnDate.Date).TotalDays;
            fine = latedays * 0.20;
            return fine;
        }
    }
}
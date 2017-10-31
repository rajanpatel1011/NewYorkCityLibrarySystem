using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace NYCLib
{
    public partial class BookReserve : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ReaderID"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            bindBookReserve();

        }
        public void bindBookReserve()
        {

            int ReaderID = 0;
            if (!string.IsNullOrEmpty(Session["ReaderID"].ToString()))
            {
                ReaderID = Convert.ToInt32(Session["ReaderID"].ToString());
            }



            if (ReaderID != 0)
            {
                string query = "SELECT * from tblBorrow as b inner join tblBook as bo on bo.BookID=b.BookId  inner join tblPublisher as p on p.PublisherId=bo.PublisherID Where b.IsReturned=0 and b.ReaderID =" + ReaderID + "";
                DataSet ds = dataconnection.get_data(query, CommandType.Text, null);
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ReserveGrid.DataSource = ds;
                        ReserveGrid.DataBind();

                    }

                }
                else
                {
                    Response.Redirect("default.aspx");
                }
                pnlgrid.Visible = true;
          


            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NYCLib
{
    public partial class ReaderSearchBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                        

        }
        protected void btnserachbook_click(object sender, EventArgs e)
        {
            int bookID = 0;
            if (!string.IsNullOrEmpty(txtSeachBookById.Text))
            {
                bookID = Convert.ToInt32(txtSeachBookById.Text);
            }
            else
            {
                bookID = 0;
            }
            
            string bookTitle = txtSearchBookByTitle.Text;
            string publisher = txtSearchBookByPulisher.Text;
            
            string wherecond = "";

            if (bookID != 0)
            {
                wherecond = "where b.BookID = " + bookID ;
            }
            if (!string.IsNullOrEmpty(bookTitle))
            {
                if (wherecond.Equals(""))
                {
                    wherecond = "where BookTitle like '%" + bookTitle + "%'";
                }
                else
                {
                    wherecond = "or BookTitle like '%" + bookTitle + "%'";
                }
            }

            if (!string.IsNullOrEmpty(publisher))
            {
                if (wherecond.Equals(""))
                {
                    wherecond = "where p.PublisherName like '%" + publisher + "%'";
                }
                else
                {
                    wherecond = "or p.PublisherName like '%" + publisher + "%'";
                }
            }


            string query = "select * from tblBook as b inner join tblPublisher as p on b.PublisherID = p.PublisherId " + wherecond;
            DataSet ds = dataconnection.get_data(query, System.Data.CommandType.Text, null);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gvBooks.DataSource = ds;
                    gvBooks.DataBind();
                }
            }

            pnlgrid.Visible = true;
            pnlform.Visible = false;
        }

        protected void gvBooks_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("checkout"))
            {
                int readerID = 0;
                if (!string.IsNullOrEmpty(Session["ReaderID"].ToString()))
                    readerID = Convert.ToInt32(Session["ReaderID"].ToString());
                if (readerID != 0)
                {
                    int BookID = Convert.ToInt32(e.CommandArgument);
                    DateTime today = DateTime.Now;
                    DateTime release = today.AddDays(20);
                    string query = "insert into tblBorrow values('"+today+ "','" + release + "'," + BookID + "," + readerID+ ",0)";
                    bool b = dataconnection.Execute_NonQuery(query, CommandType.Text, null);
                    if (b)
                    {
                        Response.Redirect("BookReturn.aspx");
                    }
                }

            }
        }
    }
}
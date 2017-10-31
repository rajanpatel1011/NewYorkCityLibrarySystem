using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace NYCLib
{
    public partial class SearchBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnserachbook_click(object sender,EventArgs e)
        {

           
            string bookTitle = txtSerachByName.Text;
            string Author = txtSerachByAuthor.Text;

            string wherecond = "";

            
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

            if (!string.IsNullOrEmpty(Author))
            {
                if (wherecond.Equals(""))
                {
                    wherecond = "where author like '%" + Author + "%'";
                }
                else
                {
                    wherecond = "or author like '%" + Author + "%'";
                }
            }


            string query = "SELECT * FROM tblBook as bo inner join tblBorrow as b on bo.BookID=b.BookId inner join tblReader as r on b.ReaderID=r.ReaderId  " + wherecond;
            DataSet ds = dataconnection.get_data(query, System.Data.CommandType.Text, null);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    SearchGrid.DataSource = ds;
                    SearchGrid.DataBind();
                }
            }

            pnlgrid.Visible = true;
            pnlform.Visible = false;

            
           

            

          
        }
    }
}
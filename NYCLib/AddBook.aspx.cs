using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace NYCLib
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindPublisher();
                bindBookGrid();
            }
        }

        public void bindPublisher()
        {
            string query = "select * from tblPublisher";
            DataSet ds = dataconnection.get_data(query, System.Data.CommandType.Text, null);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    drpPublisher.DataTextField = "PublisherName";
                    drpPublisher.DataValueField = "PublisherID";
                    drpPublisher.DataSource = ds;
                    drpPublisher.DataBind();
                }
            }
        }

        public void bindBookGrid()
        {
            string query = "select * from tblBook";
            DataSet ds = dataconnection.get_data(query, System.Data.CommandType.Text, null);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    BookGrid.DataSource = ds;
                    BookGrid.DataBind();
                }
            }
        }
        protected void btnAddBook_Click(object sender, EventArgs e)
        {
           // int BookID = Convert.ToInt32(txtBookID.Text);
            string BookTitle = txtBookTitle.Text;
            string Author = txtAuthor.Text;
            string ISBN = txtISBN.Text;
            int PublisherID = Convert.ToInt32(drpPublisher.SelectedValue);
            DateTime dt = Convert.ToDateTime(txtPublicationDate.Text);

            string query = "insert into tblBook values ('"+BookTitle+"','"+Author+"','"+ISBN+"',"+PublisherID+")";
            
            bool b = dataconnection.Execute_NonQuery(query, CommandType.Text, null);
            if (b)
            {
                pnlForm.Visible = false;
                pnlGrid.Visible = true;
                bindBookGrid();
            }
            else
            {
                pnlForm.Visible = false;
                pnlGrid.Visible = true;
                bindBookGrid();
            }
        }

        protected void btnAddBookPanel_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = true;
            pnlGrid.Visible = false;
        }
    }
}
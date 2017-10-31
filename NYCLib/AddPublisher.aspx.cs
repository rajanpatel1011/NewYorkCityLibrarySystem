using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace NYCLib
{
    public partial class AddPublisher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
              
                bindPublisherGrid();
            }
        }

        public void bindPublisherGrid()
        {
            string query = "select * from tblPublisher";
            DataSet ds = dataconnection.get_data(query, System.Data.CommandType.Text, null);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {

                    PublisherGrid.DataSource = ds;
                    PublisherGrid.DataBind();

                 
                }
            }
        }
        protected void btnAddPublisher_click(object sender, EventArgs e)
        {
            string PublisherName = txtPublisherName.Text;
            string PublisherLocation = txtPublisherLocation.Text;
            DateTime PublishDate =Convert.ToDateTime( txtPublisherDate.Text);
            string query = " insert into tblPublisher values ('" + PublisherName + "','" + PublisherLocation + "','"+PublishDate+"')";

            bool q = dataconnection.Execute_NonQuery(query, CommandType.Text, null);
            if (q)
            {
                pnlgrid.Visible = true;
                pnlform.Visible = false;
                bindPublisherGrid();
            }else
            {

            }
        }
        protected void btnAddPublisherPanel_click(object sender, EventArgs e)
        {
            
            pnlform.Visible = true;
            pnlgrid.Visible = false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace NYCLib
{
    public partial class AddReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) { 
            bindReader();
        }
        }
        protected void bindReader()
        {
            string query = "select * from tblReader";
            DataSet ds = dataconnection.get_data(query, CommandType.Text, null);
            if(ds != null)
            {

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReaderGrid.DataSource = ds;
                    ReaderGrid.DataBind();

                }
                

            }
        }
        protected void btnAddReader_click(object sender, EventArgs e)
        {
            string name = txtReaderName.Text;
            string address = txtReaderAdd.Text;
            DateTime dob = Convert.ToDateTime(txtReaderDOB.Text);
            string phone = (txtReaderPhone.Text);
            string query = "insert into tblReader values ('"+name+"','"+address+"','"+phone+"')";
            bool b = dataconnection.Execute_NonQuery(query,CommandType.Text, null);
            if (b)
            {
                pnlgrid.Visible = true;
                pnlform.Visible = false;
                bindReader();
               
            }
        }
        protected void btnAddReaderPanel_click(object sender, EventArgs e)
        {

            pnlform.Visible = true;
            pnlgrid.Visible = false;
        }
    }
}
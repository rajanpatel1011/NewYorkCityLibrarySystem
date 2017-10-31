using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace NYCLib
{
    public partial class AddBranch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            BindBranch();
            pnlgrid.Visible = true;


        }
        public void BindBranch()
        {
            string query = "select * from tblBranch";
            DataSet ds = dataconnection.get_data(query, System.Data.CommandType.Text, null);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
           
                    BranchGrid.DataSource = ds;
                    BranchGrid.DataBind();
                }
            }
        }
        protected void btnAddBranch_click(object sender, EventArgs e)
        {
            string name = txtBranchName.Text;
            string location = txtBranchLocation.Text;
            string query = "insert into tblBranch (BranchName,BranchLocation) values ('"+name+"','"+location+"')";
            bool b = dataconnection.Execute_NonQuery(query, CommandType.Text, null);
            if (b)
            {
                pnlgrid.Visible = true;
                pnlform.Visible = false;
                
                BindBranch();
            }
        }
        protected void btnAddBranchPanel_click(object sender, EventArgs e)
        {
            pnlform.Visible = true;
        }
    }
}
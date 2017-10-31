using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace NYCLib
{
    public partial class BranchInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BindBranch();


        }
        public void BindBranch()
        {
            string query = "select * from tblBranch";
            DataSet ds = dataconnection.get_data(query, System.Data.CommandType.Text, null);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {

                    BranchInfoGrid.DataSource = ds;
                    BranchInfoGrid.DataBind();
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NYCLib
{
    public partial class ReaderMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ReaderID"] == null)
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}
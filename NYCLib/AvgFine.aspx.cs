using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace NYCLib
{
    public partial class AvgFine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bindAvgFine();
            //select r.ReaderId,r.ReaderName, SUM(fine)/COUNT(*) as avgFine from  tblReserved  as res inner join tblReader as r on res.ReaderId = r.ReaderId group by r.ReaderId,r.ReaderName
        }
        public void bindAvgFine()
        {
            string query = "select r.ReaderId,r.ReaderName, SUM(fine)/COUNT(*) as avgFine from  tblReserved  as res inner join tblReader as r on res.ReaderId = r.ReaderId group by r.ReaderId,r.ReaderName";
            DataSet ds = dataconnection.get_data(query, CommandType.Text, null);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FineGrid.DataSource = ds;
                    FineGrid.DataBind();
                }
            }

        }
    }
}
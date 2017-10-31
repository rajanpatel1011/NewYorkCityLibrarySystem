using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace NYCLib
{
    public partial class FeqBorrow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bindFeqBorrow();
            bindFeqBook();
            //select  r.ReaderName,COUNT(r.ReaderID) AS rEDcOUNT from tblBorrow as b INNER JOIN tblReader AS R  on  b.ReaderID = R.ReaderId GROUP BY r.ReaderId,r.ReaderName ORDER BY rEDcOUNT desc
        }
        public void bindFeqBorrow()
        {
            string query = "select  r.ReaderId,r.ReaderName,COUNT(r.ReaderID) AS read_Count from tblBorrow as b INNER JOIN tblReader AS R  on  b.ReaderID = R.ReaderId GROUP BY r.ReaderId,r.ReaderName ORDER BY read_Count desc";
            DataSet ds = dataconnection.get_data(query, CommandType.Text, null);
            if(ds!= null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    BorrowGrid.DataSource = ds;
                    BorrowGrid.DataBind();
                }
            } 
        }
        public void bindFeqBook()
        {
            string query = " select bo.BookID,bo.BookTitle,count(b.BookId) AS Book_Count from tblBorrow as b INNER JOIN tblBook AS bo on  b.BookId = bo.BookID GROUP BY bo.BookID,bo.BookTitle ORDER BY Book_Count desc ";
            DataSet ds = dataconnection.get_data(query, CommandType.Text, null);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    bookGrid.DataSource = ds;
                    bookGrid.DataBind();
                }
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace NYCLib
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (username.Equals("admin") && password.Equals("admin"))
                {
                    Session["admin"] = "admin";
                    Response.Redirect("AddBook.aspx");
                }
                else
                {
                    
                    string query = "select * from tblReader where ReaderName = '"+username+"'";
                    DataSet ds = dataconnection.get_data(query, CommandType.Text, null);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Session["ReaderID"] =  ds.Tables[0].Rows[0]["ReaderID"].ToString();
                        Response.Redirect("ReaderSearchBook.aspx");
                    }
                    else
                    {
                        Response.Redirect("Default.aspx");
                    }   
                }
            }
        }
    }
}
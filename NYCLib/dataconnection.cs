using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for dataconnection
/// </summary>
public class dataconnection
{
    public static String ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["NYCLIBConnection"].ToString();
     public static DataSet get_data(String query, CommandType commndtype, SqlParameter[] param)
    {
        SqlConnection conn = new SqlConnection(ConnStr);

        try
        {
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adp.SelectCommand.CommandType = commndtype;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    adp.SelectCommand.Parameters.Add(param[i]);
                }
            }
            adp.Fill(ds);
            return ds;
        }
        catch(Exception ex)
        {
            return null;
        }
        finally
        {
            conn.Close();
        }
    }

    public static bool Execute_NonQuery(String query, CommandType commndtype, SqlParameter[] param)
    {
        SqlConnection conn = new SqlConnection(ConnStr);
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = commndtype;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            cmd.ExecuteNonQuery();
            return true;
        }
        catch(Exception e)
        {
            Exception e1 = e;
            return false;
        }
        finally
        {
            conn.Close();

        }

    }


   
   

}
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;



namespace TaskCreator
{
    public partial class ViewTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conn = "";

        conn = ConfigurationManager.ConnectionStrings["Conn"].ToString();

         SqlConnection objsqlconn = new SqlConnection(conn);
       objsqlconn.Open();

  
       SqlCommand objcmd = new SqlCommand("Select * from inv_task", objsqlconn);

            GridView1.DataSource = objcmd.ExecuteReader();

            GridView1.DataBind();

       }

        
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)

    {

        int index = Convert.ToInt32(e.RowIndex);

        int TASK_ID = 0;



        TASK_ID = Convert.ToInt16(GridView1.Rows[index].Cells[2].Text);

        if (TASK_ID != 0)

        {

 

            string conn = "";

            

            conn = ConfigurationManager.ConnectionStrings["Conn"].ToString();

            SqlConnection objsqlconn = new SqlConnection(conn);

            try

            {

 

                    objsqlconn.Open();

                    SqlCommand objcmd = new SqlCommand("Delete from inv_task Where task_id='" + TASK_ID + "'", objsqlconn);

                    objcmd.ExecuteNonQuery();

                   // ClearAll();

                    Response.Redirect("ViewTask.aspx");

                 

 

 

 

            }

            catch (Exception ex)

            {

                Response.Write(ex.Message.ToString());

            }

            finally

            {

                objsqlconn.Close();

            }

           

        }

    }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = Convert.ToInt32(e.NewEditIndex);

            string TASK_ID = "";
            string TASK_NAME = "";
            string TASK_DESC= "";
            string TASK_DATE = "";



            TASK_ID = GridView1.Rows[id].Cells[2].Text.ToString();
          //  TASK_NAME = GridView1.Rows[index].Cells[3].Text.ToString();
          //  TASK_DESC = GridView1.Rows[index].Cells[4].Text.ToString();
          //  TASK_DATE = GridView1.Rows[index].Cells[5].Text.ToString();
            Session["task_id"] = TASK_ID;
          //  Session["task_name"] = TASK_NAME;
          //  Session["task_desc"] = TASK_DESC;
          //  Session["task_date"]=
            Response.Redirect("NewTask.aspx");
            //string field1 = (string)(Session["field1"]);

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

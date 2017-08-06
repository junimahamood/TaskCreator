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
    public partial class NewTask : System.Web.UI.Page
    {
        string task_id="";
        protected void Page_Load(object sender, EventArgs e)
        {
           // cleardata();

             task_id = (string)(Session["task_id"]);
             if (task_id != null && task_id != "")
                 fillData();
        }
        private void fillData()
        {
        //    string conn = "";
        //    DataTable dtbData = null;
        //    conn = ConfigurationManager.ConnectionStrings["Conn"].ToString();

        //    SqlConnection objsqlconn = new SqlConnection(conn);
        //    objsqlconn.Open();


        //    SqlCommand objcmd = new SqlCommand("Select * from inv_task where task_id='"+task_id+"'", objsqlconn);
        //  //  dtbData.DataSet = objcmd.ExecuteReader();

        //    // create data adapter
        //    SqlDataAdapter da = new SqlDataAdapter(objcmd);
        //// this will query your database and return the result to your datatable
        //da.Fill(dtbData);


            DataTable dt = new DataTable();

        string constr = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from inv_task where task_id='" + task_id + "'"))
                {
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        
                        sda.Fill(dt);
                    }
                }
            }

            if (dt.Rows.Count > 0)
        {
            txttaskid.Text = dt.Rows[0]["task_id"].ToString();
            txttaskname.Text = dt.Rows[0]["task_name"].ToString();
            txtTTaskDesc.Text = dt.Rows[0]["task_desc"].ToString();
            txttaskdate.Text = dt.Rows[0]["task_date"].ToString();
            
        }

          
           
        }
        private void cleardata()
        {
            txttaskdate.Text = "";
            txttaskid.Text = "";
            txttaskname.Text = "";
            txtTTaskDesc.Text = "";
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string conn = "";

            conn = ConfigurationManager.ConnectionStrings["Conn"].ToString();

            SqlConnection db = new SqlConnection(conn);

            db.Open();




            txttaskdate.Text = dtDate.SelectedDate.ToString();
            
            string insert="";
            if (txttaskid.Text == "")
            {
                DataTable dt = new DataTable();

                //string constr = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                //using (SqlConnection con = new SqlConnection(constr))
                //{
                using (SqlCommand cmdQ = new SqlCommand("Select ISNULL(MAX(task_id),0)+1 as task_id from inv_task "))
                    {
                        cmdQ.Connection = db;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmdQ))
                        {

                            sda.Fill(dt);
                        }
                    }
               // }

                if (dt.Rows.Count > 0)
                {
                    txttaskid.Text = dt.Rows[0]["task_id"].ToString();
                    
                }
                insert = "insert into inv_task (task_id,task_name,task_desc,task_date,task_flag) values ('"+txttaskid.Text+"','" + txttaskname.Text + "','" + txtTTaskDesc.Text + "','" + txttaskdate.Text + "','N')";

            }
            else
            {
                insert = "update inv_task set task_name='" + txttaskname.Text + "',task_desc='" + txtTTaskDesc.Text + "',task_date='" + txttaskdate.Text + "' ";
            }

        SqlCommand cmd = new SqlCommand(insert,db);  
         int m = cmd.ExecuteNonQuery();  
     if(m != 0)  
      
    {  
      Response.Write("  <script>alert('Data Inserted !!')</script>  ");  
     }  
    else  
    {  
     Response.Write("  <script>alert('Data Inserted !!')</script>  ");  
     }  
     db.Close();  
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mainopen.aspx");
        }
      }
   }

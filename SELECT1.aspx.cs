using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZstdSharp.Unsafe;


namespace select
{
    public partial class SELECT1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /* protected void Button1_Click(object sender, EventArgs e)
            {
                  string searchKey = TextBox1.Text;


                  string connectionString = "server=10.10.0.56;user=valetuser;password=Password@123;database=pcpb;";

                  using (MySqlConnection con = new MySqlConnection(connectionString))
                  {
                      string query = "SELECT PATIENT_ID, FIRST_NAME, LAST_NAME, middle_name, GENDER, ADDRESS1, CITY FROM patients WHERE (FIRST_NAME LIKE @searchKey) OR (LAST_NAME LIKE @searchKey);";

                      using (MySqlCommand cmd = new MySqlCommand(query, con))
                      {


                          cmd.Parameters.AddWithValue("@searchKey", "%" + searchKey + "%");

                          using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                          {
                              DataTable dt = new DataTable();
                              da.Fill(dt);

                              if (dt.Rows.Count > 0)
                              {

                                  GridView1.DataSource = dt;
                                  GridView1.DataBind();
                                  lblNoResults.Visible = false;
                              }
                              else
                              {

                                  GridView1.DataSource = null;
                                  GridView1.DataBind();
                                  lblNoResults.Visible = true;
                              }
                          }
                      }
                  }
            }

            protected void Button2_Click(object sender, EventArgs e)
            {
                string patientIdText = TextBox2.Text;
                string searchKey = TextBox1.Text;
                string connectionString = "server=10.10.0.56;user=valetuser;password=Password@123;database=pcpb;";

                int patientId = Convert.ToInt32(string.IsNullOrEmpty(patientIdText) ? "0" : patientIdText);



                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    string query = "SELECT PATIENT_ID, FIRST_NAME, LAST_NAME, middle_name, CASE WHEN GENDER = 'F' THEN 'Female' WHEN GENDER = 'M' THEN 'Male' ELSE 'Other' END AS GENDER,ADDRESS1, CITY FROM patients where 1=1 ";

                    if (patientId > 0)
                    {
                        query += " AND PATIENT_ID = @PATIENT_ID";
                    }

                    else if (!string.IsNullOrEmpty(searchKey))
                    {
                        query += " AND FIRST_NAME LIKE @searchKey or LAST_NAME LIKE @searchKey ";
                    }


                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {

                        if (patientId > 0)
                        {
                            cmd.Parameters.AddWithValue("@PATIENT_ID", patientId);
                        }

                        if (!string.IsNullOrEmpty(searchKey))
                        {
                            cmd.Parameters.AddWithValue("@searchKey", "%" + searchKey + "%");
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                GridView1.DataSource = dt;
                                GridView1.DataBind();
                                lblNoResults.Visible = false;
                            }
                            else
                            {
                                GridView1.DataSource = null;
                                GridView1.DataBind();
                                lblNoResults.Visible = true;
                            }
                        }
                    }
                }
            }*/

        /* protected void Button2_Click(object sender, EventArgs e)
         {

             string patientIdText = TextBox2.Text;
             string searchKey = TextBox1.Text;
             string DOB=TextBox3.Text;
             string connectionString = "server=10.10.0.56;user=valetuser;password=Password@123;database=pcpb;";

             int patientId = Convert.ToInt32(string.IsNullOrEmpty(patientIdText) ? "0" : patientIdText);



             using (MySqlConnection con = new MySqlConnection(connectionString))
             {
                 string query = "SELECT p.PATIENT_ID, p.FIRST_NAME, p.LAST_NAME, p.middle_name, CASE WHEN GENDER = 'F' THEN 'Female' WHEN GENDER = 'M' THEN 'Male' ELSE 'Other' END AS GENDER , p.ADDRESS1, p.CITY, pd.DOB FROM patients p INNER JOIN patient_demos pd  on p.PATIENT_ID=pd.PATIENT_ID where 1=1 ";

                 if (patientId > 0)
                 {
                     query += " AND p.PATIENT_ID = @PATIENT_ID";
                 }

                 else if (!string.IsNullOrEmpty(searchKey))
                 {
                     query += " AND FIRST_NAME LIKE @searchKey or LAST_NAME LIKE @searchKey ";
                 }
                 else if (!string.IsNullOrEmpty(DOB))
                 {
                     query += " AND pd.DOB = @DOB ";
                 }


                 using (MySqlCommand cmd = new MySqlCommand(query, con))
                 {

                     if (patientId > 0)
                     {
                         cmd.Parameters.AddWithValue("@PATIENT_ID", patientId);
                     }

                    else if (!string.IsNullOrEmpty(searchKey))
                     {
                         cmd.Parameters.AddWithValue("@searchKey", "%" + searchKey + "%");
                     }
                     else if (!string.IsNullOrEmpty(DOB))
                     {
                         cmd.Parameters.AddWithValue("@DOB",DOB);
                     }

                     using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                     {
                         DataTable dt = new DataTable();
                         da.Fill(dt);

                         if (dt.Rows.Count > 0)
                         {
                             GridView1.DataSource = dt;
                             GridView1.DataBind();
                             lblNoResults.Visible = false;
                         }
                         else
                         {
                             GridView1.DataSource = null;
                             GridView1.DataBind();
                             lblNoResults.Visible = true;
                         }
                     }
                 }
             }
         }*/
        protected void Button2_Click(object sender, EventArgs e)
        { 
            string patientIdText=TextBox2.Text;
            string DOB=TextBox3.Text;
            string SearchKey=TextBox1.Text;
            string connectionString = "server=10.10.0.56;user=valetuser;password=Password@123;database=pcpb;";
            int patientId = Convert.ToInt32(string.IsNullOrEmpty(patientIdText) ? "0" : patientIdText);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "select p.PATIENT_ID,FIRST_NAME,p.LAST_NAME,p.middle_name,CASE WHEN GENDER='F' THEN 'FEMALE' WHEN GENDER='M' THEN 'MALE' END AS GENDER,p.ADDRESS1,p.CITY,pd.DOB FROM patients p inner join patient_demos pd ON p.PATIENT_ID=pd.PATIENT_ID where 1=1";

                if (patientId > 0)
                {
                    query += " AND p.PATIENT_ID = @PATIENT_ID";
                }
                else if (!string.IsNullOrEmpty(SearchKey))
                {
                    query += " AND FIRST_NAME LIKE @SearchKey or LAST_NAME LIKE @SearchKey";
                }
                else if (!string.IsNullOrEmpty(DOB))
                {
                    query += " AND pd.DOB = @DOB";   
                }
                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Connection = conn;
                    
                    if (patientId > 0)
                    {
                        cmd.Parameters.AddWithValue("@patient_ID", patientId);
                    }
                    else if (!string.IsNullOrEmpty(SearchKey))
                    {
                        cmd.Parameters.AddWithValue("@SearchKey","%"+ SearchKey+"%");
                    }
                    else if(!string.IsNullOrEmpty(DOB))
                    {
                        cmd.Parameters.AddWithValue("@DOB", DOB);
                    }
                    using(MySqlDataAdapter da=new MySqlDataAdapter(cmd))
                    {
                       
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0) {
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                            lblNoResults.Visible = false;    
                        }
                        else
                        {
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                            lblNoResults.Visible = true;
                        }
                            
                    }
                   
                    
                }


            }
        }
        }

    }

        

     
    

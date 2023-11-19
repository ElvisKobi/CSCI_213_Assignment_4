using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4
{
    public partial class Administrator : System.Web.UI.Page
    {
        KarateSchoolDataContext dbcon;
        protected void Page_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            string conn = ConnectionString.conn;

            dbcon = new KarateSchoolDataContext(conn);

            //Fill GridView
            using (SqlConnection dbconn = new SqlConnection(conn))
            {
                string query = "select MemberFirstName, MemberLastName, MemberPhoneNumber, MemberDateJoined " +
                    "from Member";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, dbconn);


                //set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set the DataGridView control's data source/data table
                GridView1.DataSource = ds.Tables[0];

                GridView1.DataBind();

                string query2 = "select InstructorFirstName, InstructorLastName " +
                    "from Instructor";

                //define the SqlCommand object
                SqlCommand cmd2 = new SqlCommand(query2, dbconn);


                //set the SqlDataAdapter object
                SqlDataAdapter dAdapter2 = new SqlDataAdapter(cmd2);

                //define dataset
                DataSet ds2 = new DataSet();

                //fill dataset with query results
                dAdapter2.Fill(ds2);

                //set the DataGridView control's data source/data table
                GridView2.DataSource = ds2.Tables[0];

                GridView2.DataBind();

                //close connection
                dbconn.Close();
            }

        }

        protected void MemberCreateBtn_Click(object sender, EventArgs e)
        {
            string conn = ConnectionString.conn;

            dbcon = new KarateSchoolDataContext(conn);

            // Create Instance of the Member Table
            //Member NewMember = new Member();
           // NetUser user = new NetUser();
            //NewMember.Member_UserID = NetUser.
        }

        protected void MemberFirstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
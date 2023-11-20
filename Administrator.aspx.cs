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
        string conn = ConnectionString.conn;
        KarateSchoolDataContext dbcon;
        protected void Page_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {

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
            //get dropdown data
            var result = from item in dbcon.Members
                         select new { item.MemberFirstName, item.Member_UserID};
            memberDropDwn.DataTextField = "MemberFirstName";
            memberDropDwn.DataValueField = "Member_UserID";
            //fill dropdown
            memberDropDwn.DataSource = result;
            memberDropDwn.DataBind();
            
            //get dropdown data for instructor
            var result2 = from item in dbcon.Instructors
                         select new { item.InstructorFirstName, item.InstructorID };
            instructorDropDwn.DataTextField = "InstructorFirstName";
            instructorDropDwn.DataValueField = "InstructorID";
            //fill dropdown
            instructorDropDwn.DataSource = result;
            instructorDropDwn.DataBind();

        }

        protected void MemberCreateBtn_Click(object sender, EventArgs e)
        {
            string conn = ConnectionString.conn;

            dbcon = new KarateSchoolDataContext(conn);

            // create instance of new user
            NetUser newuser = new NetUser();
            if (usertypeDropDown.SelectedValue == "Member")
            {
                Member newmember = new Member();
                newuser.UserName = usernameTextBox.Text;
                newuser.UserPassword = passwordTextBox.Text;
                newuser.UserType = "Member";
                dbcon.NetUsers.InsertOnSubmit(newuser);
                try
                {
                    dbcon.SubmitChanges();
                    newuser = (from x in dbcon.NetUsers
                              where (x.UserName == usernameTextBox.Text)
                              select x).First();
                    newmember.Member_UserID = newuser.UserID;
                    newmember.MemberFirstName = MemberFirstNameTxt.Text;
                    newmember.MemberLastName = MemberLastNameTxt.Text;
                    newmember.MemberPhoneNumber = MemberPhoneTxt.Text;
                    newmember.MemberEmail = MemberEmailTxt.Text;
                    newmember.MemberDateJoined = DateTime.Now;
                    dbcon.Members.InsertOnSubmit(newmember);
                    dbcon.SubmitChanges();
                    errorlbl.Text = "Member successfully created! :)";
                }
                catch 
                {
                    errorlbl.Text = "Something went wrong :(";
                }

            }
            else if (usertypeDropDown.SelectedValue == "Instructor")
            {
                Instructor newinstructor = new Instructor();
                newuser.UserName = usernameTextBox.Text;
                newuser.UserPassword = passwordTextBox.Text;
                newuser.UserType = "Instructor";
                dbcon.NetUsers.InsertOnSubmit(newuser);
                try
                {
                    dbcon.SubmitChanges();
                    newuser = (from x in dbcon.NetUsers
                               where (x.UserName == usernameTextBox.Text)
                               select x).First();
                    newinstructor.InstructorID = newuser.UserID;
                    newinstructor.InstructorFirstName = MemberFirstNameTxt.Text;
                    newinstructor.InstructorLastName = MemberLastNameTxt.Text;
                    newinstructor.InstructorPhoneNumber = MemberPhoneTxt.Text;
                    dbcon.Instructors.InsertOnSubmit(newinstructor);
                    dbcon.SubmitChanges();
                    errorlbl.Text = "Instructor successfully created! :)";
                }
                catch
                {
                    errorlbl.Text = "Something went wrong :(";
                }
            }
            Refresh();
        }

        protected void MemberFirstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = deleteNameTxt.Text;
                NetUser deleteuser = (from x in dbcon.NetUsers
                                      where x.UserName == userName
                                      select x).First();
                if(deleteuser.UserType == "Member")
                {
                    Member deletemember = (from x in dbcon.Members
                                           where x.Member_UserID == deleteuser.UserID
                                           select x).First();
                    dbcon.Members.DeleteOnSubmit(deletemember);
                    dbcon.SubmitChanges();
                    dbcon.NetUsers.DeleteOnSubmit(deleteuser); 
                    dbcon.SubmitChanges();
                    deleteError.Text = "Member sucessfully deleted.";
                }
                else if(deleteuser.UserType == "Instructor")
                {
                    Instructor deleteinstructor = (from x in dbcon.Instructors
                                           where x.InstructorID == deleteuser.UserID
                                           select x).First();
                    dbcon.Instructors.DeleteOnSubmit(deleteinstructor);
                    dbcon.SubmitChanges();
                    dbcon.NetUsers.DeleteOnSubmit(deleteuser);
                    dbcon.SubmitChanges();
                    deleteError.Text = "Instructor sucessfully deleted";
                }
            }
            catch 
            {
                deleteError.Text = "Something went wrong";
            }
            Refresh();
        }
    }
}
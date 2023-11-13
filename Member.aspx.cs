using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4
{
    public partial class Member : System.Web.UI.Page
    {
        //create database context and use connection string
        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO -- get first name and last name using session and database context
            string fname = "FirstName";
            string lname = "LastName";

            //set label to name
            fnameLabel.Text = fname;
            lnameLabel.Text = lname;

            //TODO -- fill gridview
        }
    }
}
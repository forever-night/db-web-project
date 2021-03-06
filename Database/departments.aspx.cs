﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Database
{
    public partial class Departments : System.Web.UI.Page
    {		
        protected void Page_Load(object sender, EventArgs e)
        {
			switch ((int)Session["Role"])
			{
				case -1:
					Response.Redirect("Login.aspx");
					break;
				case 10:
					Response.Redirect("Main.aspx");
					break;
				case 50:
					btn_add_dept.Enabled = false;
					btn_add_dept.Visible = false;
					break;
			}

			gv_depts.DataBind();
        }


        protected void btn_add_dept_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_department.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LoginSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtun.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertMessage", "alert('Enter UserName')", true);
            }
            else
                if (txtpwd.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertMessage", "alert('Enter password')", true);
            }
            else
                if (txtun.Text == "abc" && txtpwd.Text == "abc")
            {
                Response.Redirect("Welcome.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertMessage", "alert('Incorrect Un or Pwd')", true);
            }
        }
    }
}
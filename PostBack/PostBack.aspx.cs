using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBack
{
    public partial class PostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                Label1.Text = "Welcome Again";
            }
            else
            {
                Label1.Text = "Welcome to my page";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
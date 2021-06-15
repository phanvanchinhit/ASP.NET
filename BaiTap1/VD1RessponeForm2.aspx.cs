using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap1
{
    public partial class VD1RessponeForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbKetqua.Text = "UserName: " + Request.QueryString["Name"].ToString() +
                "<br> Password: " + Request.QueryString["Pass"].ToString();
        }
    }
}
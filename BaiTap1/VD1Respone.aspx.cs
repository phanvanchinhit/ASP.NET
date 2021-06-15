using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap1
{
    public partial class VD1Respone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string sName = txtUserName.Text;
            string sPass = txtPass.Text;
            Response.Redirect("VD1RessponeForm2.aspx?Name=" + sName + "&Pass=" + sPass);
        }
    }
}
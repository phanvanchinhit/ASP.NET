using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap1
{
    public partial class VD2WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int soCu, soMoi, tinh;
            soCu = Int32.Parse(Request.Form.Get("txtSoCu"));
            soMoi = Int32.Parse(Request.Form.Get("txtSoMoi"));
            tinh = soMoi - soCu;
            if(tinh <= 100)
            {
                lbKQ.Text = "Tổng tiền : " + tinh * 2000;
            }
            else if (tinh > 100 && tinh <= 150) 
            {
                lbKQ.Text = "Tổng tiền : " + tinh * 2500;
            }
            else if (tinh > 150 && tinh <= 200)
            {
                lbKQ.Text = "Tổng tiền : " + tinh * 2800;
            }
            else if (tinh > 200)
            {
                lbKQ.Text = "Tổng tiền : " + tinh * 3500;
            }

        }
    }
}
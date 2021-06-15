using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap1
{
    public partial class VD2TinhLuongForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtMa.Text = Request.QueryString["Ma"].ToString();
            //txtNgay.Text = Int32.Parse(Request.QueryString["Ngay"]);
            //txtTien.Text = Request.QueryString["Tien"].ToString();
            lbKetqua.Text = "Mã NV: " + Request.QueryString["Ma"].ToString() +
               "<br> Ngày Công: " + Request.QueryString["Ngay"].ToString() +
               "<br> Tiền lĩnh: " + Request.QueryString["Tien"].ToString();
        }
    }
}
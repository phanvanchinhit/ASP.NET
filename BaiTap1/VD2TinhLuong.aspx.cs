using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap1
{
    public partial class VD2TinhLuong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                select.Items.Add("Trưởng Phòng");
                select.Items.Add("Phó Phòng");
                select.Items.Add("Nhân Viên");
            }

        }

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            string sMa = txtMaNV.Text;
            int sBac = Int32.Parse(txtBacLuong.Text);
            int sNgay = Int32.Parse(txtNgayCong.Text);
            double tien = 0;
            if (sNgay < 25)
            {
                if (select.Items[select.SelectedIndex].Value == "Trưởng Phòng")
                {
                    tien = sBac * 650000 * sNgay + 500000;
                }
                else if (select.Items[select.SelectedIndex].Value == "Phó Phòng")
                {
                    tien = sBac * 650000 * sNgay + 300000;
                }
                else if (select.Items[select.SelectedIndex].Value == "Nhân Viên")
                {
                    tien = sBac * 650000 * sNgay + 100000;
                }
            }
            else if (sNgay >= 25)
            {
                int ngay = (sNgay - 25) * 2 + 25;
                if (select.Items[select.SelectedIndex].Value == "Trưởng Phòng")
                {
                    tien = sBac * 650000 * ngay + 500000;
                }
                else if (select.Items[select.SelectedIndex].Value == "Phó Phòng")
                {
                    tien = sBac * 650000 * ngay + 300000;
                }
                else if (select.Items[select.SelectedIndex].Value == "Nhân Viên")
                {
                    tien = sBac * 650000 * ngay + 100000;
                }
            }
            Response.Redirect("VD2TinhLuongForm2.aspx?Ma=" + sMa + "&Ngay=" + sNgay + "&Tien="+ tien);

        }
    }
}
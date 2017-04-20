using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhoHang.Views
{
    public partial class frm_NhapXuat : Form
    {
        public frm_NhapXuat()
        {
            
            InitializeComponent();
            if (Share.Ultil.checkNhapXuat == true)
            {
                textLable.Text = Share.Constant.Text_Nhap;
                txt_hd_Loai.Text = Share.Constant.Text_Loai_hd_Nhap;
            }
            else
            {
                textLable.Text = Share.Constant.Text_Xuat;
                txt_hd_Loai.Text = Share.Constant.Text_Loai_hd_Xuat;
            }
            txt_hd_nguoiLap.Text = Share.Constant.admin;
            txt_hd_ngay_lap.Text = DateTime.Today.ToString();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_themChiTiet_Click(object sender, EventArgs e)
        {
            pan_ChiTiet.Visible = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            pan_ChiTiet.Visible = false;
        }
    }
}

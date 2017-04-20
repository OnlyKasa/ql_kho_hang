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
    public partial class frm_ChiTietKho : Form
    {
        public frm_ChiTietKho()
        {
            InitializeComponent();
        }

        private void ChiTietKho_Load(object sender, EventArgs e)
        {
            Control.GetView view = new Control.GetView();
            txt_kh_id.Text = Share.Constant.khohang.kh_id;
            txt_kh_diachi.Text = Share.Constant.khohang.kh_dia_chi;
            txt_kh_quanly.Text = Share.Constant.khohang.kh_quan_ly;
            txt_kh_succhua.Text = Share.Constant.khohang.kh_suc_chua.ToString();
            txt_tong_hang.Text = Share.Constant.tong_kho_chua.ToString();
            Model.ResultsData<List<Model.ChiTiet>> key = view.view_chi_tiet(Share.Constant.khohang.kh_id);   // lấy dữ liệu từ control getview
            switch (key.err_code)
            {
                case QLKhoHang.Model.ErrorCode.fail:
                    MessageBox.Show(key.err_desc, Share.Constant.Error_msg_cap, MessageBoxButtons.OK);
                    break;
                case QLKhoHang.Model.ErrorCode.success:
                    dgv_chitiet_kho.DataSource = key.data;
                    break;
                case QLKhoHang.Model.ErrorCode.empty:
                    MessageBox.Show(key.err_desc, Share.Constant.Info_msg_cap, MessageBoxButtons.OK);
                    break;
                default:
                    break;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_kh_diachi.Text = Share.Constant.khohang.kh_dia_chi;
            txt_kh_quanly.Text = Share.Constant.khohang.kh_quan_ly;
            txt_kh_succhua.Text = Share.Constant.khohang.kh_suc_chua.ToString();
        }

        private void btn_sua_kh_Click(object sender, EventArgs e)
        {
            Model.tbl_kho_hang khohang = new Model.tbl_kho_hang();
            khohang = Share.Constant.khohang;
            if (txt_kh_diachi.Text == "" || txt_kh_quanly.Text == "" || txt_kh_id.Text == "")
            {
                throw new Exception(Share.Constant.notValue_msg);
            }
            else
            {
                khohang.kh_dia_chi = txt_kh_diachi.Text;
                khohang.kh_quan_ly = txt_kh_quanly.Text;
                khohang.kh_id = txt_kh_id.Text;
                try
                {
                    Share.Constant.khohang.kh_suc_chua = Int16.Parse(txt_kh_succhua.Text);
                    Control.UpdateData update = new Control.UpdateData();
                    Model.ResultsData<List<Model.tbl_kho_hang>> key = update.Update(khohang);
                    switch (key.err_code)
                    {
                        case QLKhoHang.Model.ErrorCode.fail:
                            MessageBox.Show(key.err_desc, Share.Constant.Error_msg_cap, MessageBoxButtons.OK);
                            break;
                        case QLKhoHang.Model.ErrorCode.success:
                            MessageBox.Show(key.err_desc, Share.Constant.Info_msg_cap, MessageBoxButtons.OK);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    khohang.kh_suc_chua = 0;

                    throw ex;
                }

               
            }
        }

        private void frm_ChiTietKho_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_MainForm.Instance().Show();
        }

        private void btn_NhapKho_Click(object sender, EventArgs e)
        {
            Share.Ultil.checkNhapXuat = true;
            frm_NhapXuat nhap = new frm_NhapXuat();
            nhap.ShowDialog();
        }

        private void btn_XuatKho_Click(object sender, EventArgs e)
        {
            Share.Ultil.checkNhapXuat = false;
            frm_NhapXuat xuat = new frm_NhapXuat();
            xuat.ShowDialog();
        }
    }
}

using QLKhoHang.Model;
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
    public partial class frm_MainForm : Form
    {
        public static frm_MainForm instance;
        public static frm_MainForm Instance()
        {
            //Đảm bảo luôn chỉ có duy nhất 1 instance của frm_MainForm được khởi tạo
            if (instance == null || instance.IsDisposed)
            {
                instance = new frm_MainForm();
            }
            else {
               instance.LoadView("");
            }
            return instance; 
        }  
        public frm_MainForm()
        {
           instance = this;
           InitializeComponent();
           this.LoadView("");
        }

        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {
           
            if (txt_kh_id.Text == "")
            {
                MessageBox.Show(Share.Constant.notValue_msg, Share.Constant.Error_msg_cap, MessageBoxButtons.OK);
            }else
            {
                this.LoadView(txt_kh_id.Text);
            }
        }

        private void btn_them_moi_Click(object sender, EventArgs e)
        {
            addKhoHang1.Visible = true;
        }

    
        public void LoadView(string control)
        {
            Control.GetView view = new Control.GetView();
            if (control == "")
            {
                switch (view.view_kho_hang().err_code)
                {
                    case QLKhoHang.Model.ErrorCode.fail:
                        MessageBox.Show(view.view_kho_hang().err_desc, Share.Constant.Error_msg_cap, MessageBoxButtons.OK);
                        break;
                    case QLKhoHang.Model.ErrorCode.success: 
                        dgv_all_kho.DataSource = view.view_kho_hang().data;
                        break;
                    case QLKhoHang.Model.ErrorCode.empty:
                        MessageBox.Show(view.view_kho_hang().err_desc, Share.Constant.Info_msg_cap, MessageBoxButtons.OK);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (view.view_kho_hang(control).err_code)
                {
                    case QLKhoHang.Model.ErrorCode.fail:
                        MessageBox.Show(view.view_kho_hang(control).err_desc, Share.Constant.Error_msg_cap, MessageBoxButtons.OK);
                        break;
                    case QLKhoHang.Model.ErrorCode.success:
                        MessageBox.Show(String.Format(Share.Constant.func_rs_seach_success, view.view_kho_hang(control).data.Count), Share.Constant.Info_msg_cap, MessageBoxButtons.OK);
                        dgv_all_kho.DataSource = view.view_kho_hang(control).data;
                        break;
                    case QLKhoHang.Model.ErrorCode.empty:
                        MessageBox.Show(Share.Constant.func_rs_seach_fall, Share.Constant.Info_msg_cap, MessageBoxButtons.OK);
                        dgv_all_kho.DataSource = view.view_kho_hang(control).data;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            this.LoadView("");
        }
 
        private void addKhoHang1_SubmitClickCancel()
        {
            addKhoHang1.Visible = false;
        }

        private void addKhoHang1_SubmitClickOK()
        {
            Control.UpdateData updata = new Control.UpdateData();
            ResultsData<List<tbl_kho_hang>> rs = updata.AddKho(Share.Constant.khohang);
            switch (rs.err_code)     // lấy giá trị từ control. updatedata đổ về view 
            {
                case QLKhoHang.Model.ErrorCode.fail:
                    MessageBox.Show(rs.err_desc, Share.Constant.Error_msg_cap, MessageBoxButtons.OK);
                    break;
                case QLKhoHang.Model.ErrorCode.success:
                    MessageBox.Show(rs.err_desc, Share.Constant.Info_msg_cap, MessageBoxButtons.OK);
                    dgv_all_kho.DataSource = rs.data;
                    break;
                default:
                    break;
            }
        }
        private void dgv_all_kho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Share.Constant.khohang.kh_id = getdatarow("kh_id");
            Share.Constant.khohang.kh_dia_chi = getdatarow("kh_dia_chi");
            Share.Constant.khohang.kh_quan_ly = getdatarow("kh_quan_ly");
            Share.Constant.khohang.kh_suc_chua =(int)dgv_all_kho.CurrentRow.Cells["kh_suc_chua"].Value;
            frm_ChiTietKho chitiet = new frm_ChiTietKho();
            chitiet.ShowDialog();
           
        }
         private string getdatarow(string name) {
             return dgv_all_kho.CurrentRow.Cells[name].Value.ToString();
        }
    }
    

}

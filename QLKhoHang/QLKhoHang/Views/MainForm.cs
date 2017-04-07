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
    public partial class MainForm : Form
    {
        
        Control.GetView view = new Control.GetView();
        Control.UpdateData updata = new Control.UpdateData();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {
           
            if (txt_kh_id.Text == "")
            {

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.LoadView("");
        }

        private void addKhoHang1_SubmitClickCancel()
        {
            addKhoHang1.Visible = false;
        }

        private void addKhoHang1_SubmitClickOK()
        {
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
            string a = dgv_all_kho.CurrentRow.Cells["kh_id"].Value.ToString();
            
        }
    }
}

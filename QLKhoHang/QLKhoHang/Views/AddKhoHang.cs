using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhoHang.Model;
namespace QLKhoHang.Views
{
    public partial class AddKhoHang : UserControl
    {
        public delegate void SubmitHandler();
        public event SubmitHandler SubmitClickOK ;
        public event SubmitHandler SubmitClickCancel;
        public AddKhoHang()
        {
            InitializeComponent();
        }
      
        private void btn_submit_Click(object sender, EventArgs e)
        {
          if (txt_kh_dia_chi.Text == "" || txt_kh_quan_ly.Text == "" || txt_kh_id.Text == "")
          {
              throw new Exception(Share.Constant.notValue_msg); 
          }
          else 
           {
            Share.Constant.khohang.kh_dia_chi = txt_kh_dia_chi.Text;
            Share.Constant.khohang.kh_quan_ly = txt_kh_quan_ly.Text;
            Share.Constant.khohang.kh_id = txt_kh_id.Text;
            try
            {   
               
                Share.Constant.khohang.kh_suc_chua = Int16.Parse(txt_suc_chua.Text);
            }
            catch (Exception ex)
            {
                Share.Constant.khohang.kh_suc_chua = 0;
                throw ex;
            }
           
           if(SubmitClickOK != null){        // gọi đến sự kiện submit ok bên form chính 
             SubmitClickOK() ;
           }
         }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
             if(SubmitClickCancel != null)
             {
             SubmitClickCancel() ;
             }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_kh_dia_chi.Text = "";
            txt_kh_id.Text = "";
            txt_kh_quan_ly.Text = "";
            txt_suc_chua.Text = "";
        }
    }
}

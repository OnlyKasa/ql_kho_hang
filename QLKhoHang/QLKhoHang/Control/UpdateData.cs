using QLKhoHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhoHang.Control
{
    class UpdateData
    {
        DataQLKDataContext db = new DataQLKDataContext();
        Control.GetView view = new Control.GetView();

        public ResultsData<List<tbl_kho_hang>> AddKho(tbl_kho_hang khohang)   // trả về kết quả update
        {
            ResultsData<List<tbl_kho_hang>> results = new ResultsData<List<tbl_kho_hang>>();
            if (khohang.kh_suc_chua <= 0 || khohang.kh_id == "")
            {
                results.err_code = ErrorCode.fail;
                results.err_desc = String.Format(Share.Constant.Insert_false_msg, " kho hàng");
                results.data = view.view_kho_hang().data;
            }
            else
                try
                {
                    db.tbl_kho_hangs.InsertOnSubmit(khohang);
                    db.SubmitChanges();
                    results.err_code = ErrorCode.success;
                    results.err_desc = String.Format(Share.Constant.Insert_success_msg, " kho hàng");
                    results.data = view.view_kho_hang().data;
                }
                catch (Exception ex)
                {
                    results.err_code = ErrorCode.fail;
                    results.err_desc = String.Format(Share.Constant.Insert_false_msg, " kho hàng");
                    results.err_desc += " \n Chi tiết lỗi: \n" + ex.ToString();
                    results.data = view.view_kho_hang().data;
                }
            return results;
        }
        public ResultsData<List<tbl_kho_hang>> Update(tbl_kho_hang khohang)   // trả về kết quả update
        {
            ResultsData<List<tbl_kho_hang>> results = new ResultsData<List<tbl_kho_hang>>();
            var data = from kho in db.tbl_kho_hangs where kho.kh_id == khohang.kh_id select kho;
            if (khohang.kh_suc_chua <= 0)
            {
                results.err_code = ErrorCode.fail;
                results.err_desc = String.Format(Share.Constant.Update_false_msg, " kho hàng");
              //  results.data = view.view_kho_hang().data;
            }
            else
                try
                {
                    foreach (tbl_kho_hang ord in data)
                    {
                        ord.kh_dia_chi = khohang.kh_dia_chi;
                        ord.kh_quan_ly = khohang.kh_quan_ly;
                        ord.kh_suc_chua = khohang.kh_suc_chua;
                    }
                    db.SubmitChanges();
                    results.err_code = ErrorCode.success;
                    results.err_desc = String.Format(Share.Constant.Update_success_msg, " kho hàng");
                    results.data = view.view_kho_hang().data;
                }
                catch (Exception ex)
                {
                    results.err_code = ErrorCode.fail;
                    results.err_desc = String.Format(Share.Constant.Update_false_msg, " kho hàng");
                    results.err_desc += " \n Chi tiết lỗi: \n" + ex.ToString();
                    results.data = view.view_kho_hang().data;
                }
            return results;
        }

       
    }
}

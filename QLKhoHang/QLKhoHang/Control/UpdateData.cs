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
        public   ResultsData<List<tbl_kho_hang>> AddKho(tbl_kho_hang khohang)   // trả về kết quả update
        {
            ResultsData<List<tbl_kho_hang>> results = new ResultsData<List<tbl_kho_hang>>();
            if (khohang.kh_suc_chua <= 0 || khohang.kh_id =="") 
            {
                results.err_code = ErrorCode.fail;
                results.err_desc = String.Format(Share.Constant.Insert_false_msg, " kho hàng");
                results.data = view.view_kho_hang().data;
            }else
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
    }
}

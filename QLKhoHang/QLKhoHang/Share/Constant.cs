using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhoHang.Share
{
    class Constant
    {
        public static Model.tbl_kho_hang khohang =  new Model.tbl_kho_hang();
        public static double tong_kho_chua;
        #region MSG Box Caption
        public const string Info_msg_cap = "Thông báo";
        public const string Error_msg_cap = "Lỗi";
        public const string Warning_msg_cap = "Cảnh báo";
        #endregion


        #region Func Result Description
        public const string func_rs_success = "Lấy ra dữ liệu thành công";
        public const string func_rs_empty = "Không có dữ liệu trong database";
        #endregion

        #region Func seach
        public const string func_rs_seach_success = "Tìm được {0} bản ghi phù hợp";
        public const string func_rs_seach_fall = "Không tìm được bản ghi nào phù hợp";
        #endregion
        #region insert 
        public const string Insert_success_msg = "Thêm mới {0} thành công";
        public const string Insert_false_msg = "Thêm mới {0} không thành công";

        #endregion
        #region 
        public const string notValue_msg = "Dữ liệu nhập vào không hợp lệ, mời nhập lại";
        #endregion
        public const string Update_success_msg = "Thay đổi  {0} thành công";
        public const string Update_false_msg = "Thay đổi {0} không thành công";
        public const string Text_Nhap = "Nhập Kho ";
        public const string Text_Xuat = "Xuất Kho";
        public const string admin = "Nguyễn Văn Quang";
        public const string Text_Loai_hd_Nhap = "Hóa đơn nhập";
        public const string Text_Loai_hd_Xuat = "Hóa đơn xuất";
    }
}

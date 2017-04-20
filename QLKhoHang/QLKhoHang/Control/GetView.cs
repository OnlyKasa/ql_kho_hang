using QLKhoHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhoHang.Control
{    
    class GetView
    {   
       
        DataQLKDataContext db = new DataQLKDataContext();
        public   ResultsData<List<tbl_kho_hang>> view_kho_hang(string control)
        {
            ResultsData<List<tbl_kho_hang>> results = new ResultsData<List<tbl_kho_hang>>();
            try
            {
               var data = from khohang in db.tbl_kho_hangs where khohang.kh_id == control  select khohang;
                if (data.Count() >0)
                {
                    results.data = data.ToList();
                    results.err_desc = Share.Constant.func_rs_success;
                    results.err_code = ErrorCode.success;
                }
                else
                {
                    results.data =data.ToList();
                    results.err_desc = Share.Constant.func_rs_empty;
                    results.err_code = ErrorCode.empty;
                }
            }
            catch (Exception ex) {
                results.data = null;
                results.err_desc = ex.ToString();
                results.err_code = ErrorCode.fail;
            }
            return results;
        }
        public   ResultsData<List<tbl_kho_hang>> view_kho_hang()
        {
            ResultsData<List<tbl_kho_hang>> results = new ResultsData<List<tbl_kho_hang>>();
            try
            {
                var data = from khohang in db.tbl_kho_hangs select khohang;
                if (data.Count() > 0)
                {
                    results.data = data.ToList();
                    results.err_desc = Share.Constant.func_rs_success;
                    results.err_code = ErrorCode.success;
                }
                else
                {
                    results.data = null;
                    results.err_desc = Share.Constant.func_rs_empty;
                    results.err_code = ErrorCode.empty;
                }
            }
            catch (Exception ex)
            {
                results.data = null;
                results.err_desc = ex.ToString();
                results.err_code = ErrorCode.fail;
            }
            return results ;
        }
        public void ConvestData() 
        {
            
        }
       public  ResultsData<List<Model.ChiTiet>> view_chi_tiet(string id_kho_hang) 
        {   
            ResultsData<List<Model.ChiTiet>> results = new ResultsData<List<Model.ChiTiet>>();
            try
            {
                var data = from chitiet in db.tbl_chi_tiet_khos
                           where chitiet.kh_id == id_kho_hang
                           join hanghoa in db.tbl_hang_hoas
                           on chitiet.hh_id equals hanghoa.hh_id
                           select new
                           {
                               ct_id = chitiet.ct_id,
                               hh_id = hanghoa.hh_id,
                               hh_ten = hanghoa.hh_ten,
                               hh_nha_cung_cap = hanghoa.hh_noi_san_xuat,
                               ngay_cap_nhat = chitiet.ngay_cap_nhat,
                               ct_soluong = chitiet.ct_so_luong
                           };
                     
                 if (data.Count() > 0)
                    {   
                        List<ChiTiet> list = new List<ChiTiet>();
                        
                        foreach (var item in data)
                        {
                            Model.ChiTiet row = new ChiTiet() ;
                            row.ct_id = item.ct_id ;
                            row.hh_id = item.hh_id;
                            row.hh_ten = item.hh_ten;
                            row.hh_nha_cung_cap = item.hh_nha_cung_cap;
                            row.ngay_cap_nhat = item.ngay_cap_nhat;
                            row.ct_soluong = (double) item.ct_soluong;
                            Share.Constant.tong_kho_chua += row.ct_soluong;
                            list.Add(row);
                        }
                        results.data = list.ToList();
                        results.err_desc = Share.Constant.func_rs_success;
                        results.err_code = ErrorCode.success;  
                    }
                    else
                    {
                        results.data = null;
                        results.err_desc = Share.Constant.func_rs_empty;
                        results.err_code = ErrorCode.empty;
                        Share.Constant.tong_kho_chua = 0;
                    }
                }
                catch (Exception ex)
                {
                    results.data = null;
                    results.err_desc = ex.ToString();
                    results.err_code = ErrorCode.fail;
                    Share.Constant.tong_kho_chua = 0;
                }
         
            return results;
        }
    }
}

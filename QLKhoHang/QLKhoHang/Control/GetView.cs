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
        public  ResultsData<List<tbl_chi_tiet_kho>> view_chi_tiet(string id_kho_hang) 
        {
            ResultsData<List<tbl_chi_tiet_kho>> results = new ResultsData<List<tbl_chi_tiet_kho>>();
            try
            {
                var data = from chitiet in db.tbl_chi_tiet_khos where chitiet.kh_id == id_kho_hang select chitiet;
               
            }
            catch(Exception ex )
            {
                
            }
            return results;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhoHang.Model
{
    public class  ResultsData <T>
    {
        public T data { get; set; }
        public string err_desc { get; set; }
        public ErrorCode err_code { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class BaiHocViewDetails
    {
        public BaiHocDTO baiHoc { get; set; }

        public ChiTietBaiHocDTO chiTietBaiHoc { get; set; }

        public IEnumerable<CauHoiDTO> cauHois { get; set; }
    }
}

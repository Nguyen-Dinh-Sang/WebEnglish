using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class ChuDeViewDetails
    {
        public ChuDeDTO chuDe { get; set; }

        public ICollection<BaiHocDTO> baiHocs { get; set; }
    }
}

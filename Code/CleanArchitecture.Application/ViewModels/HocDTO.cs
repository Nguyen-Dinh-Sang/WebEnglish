using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    class HocDTO
    {
        [Key]
        public int Id { get; set; }
        public int? IdthamGiaChuDe { get; set; }
        public int? IdbaiHoc { get; set; }
        public int? Diem { get; set; }
    }
}

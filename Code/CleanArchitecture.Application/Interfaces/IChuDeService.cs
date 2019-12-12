using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IChuDeService
    {
        IEnumerable<ChuDeDTO> GetChuDes();
        public IEnumerable<ChuDeDTO> GetSearchTenChuDe(string dataTimKiem, string loaiTimKiem);
        ChuDeDTO GetChuDe(int? Id);

        void Create(ChuDeDTO chuDe);

        void Remove(int? Id);

        ICollection<BaiHocDTO> GetBaiHocs(int? Id);

        ICollection<ThamGiaChuDeDTO> GetThamGiaChuDes(int? Id);
    }
}

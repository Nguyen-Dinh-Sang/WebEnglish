using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IChuDeRepository
    {
        IEnumerable<ChuDe> GetChuDes();

        ChuDe GetChuDe(int? Id);
        ICollection<ChuDe> GetSearchTenChuDe(string dataTimKiem, string loaiTimKiem);
        void Create(ChuDe chuDe);

        void Remove(int? Id);

        ICollection<BaiHoc> GetBaiHocs(int? Id);

        ICollection<ThamGiaChuDe> GetThamGiaChuDes(int? Id);
    }
}

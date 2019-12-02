using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IChuDeService
    {
        IEnumerable<ChuDeDTO> GetChuDes();

        ChuDeDTO GetChuDe(int? Id);

        void Create(ChuDeDTO chuDe);

        void Remove(int? Id);
    }
}

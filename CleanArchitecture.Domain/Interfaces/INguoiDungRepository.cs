using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface INguoiDungRepository
    {
        IEnumerable<NguoiDung> GetNguoiDungs();
        void Add(NguoiDung nguoi);

        void Remove(int? id);

        NguoiDung GetNguoiDung(int? iD);
    }
}
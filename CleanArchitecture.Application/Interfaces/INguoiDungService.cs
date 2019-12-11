using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface INguoiDungService
    {
        NguoiDungViewModel GetNguoiDungs();

        void Create(SaveNguoiDung save);

        void remove(int? id);

        SaveNguoiDung GetNguoiDung(int? iD);

        bool CheckTaiKhoan(string taiKhoan);
    }
}

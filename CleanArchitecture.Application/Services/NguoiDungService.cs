using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.Services
{
    public class NguoiDungService : INguoiDungService
    {
        private readonly INguoiDungRepository iNguoiDungRepository;
        private readonly IMapper iMapper;

        public NguoiDungService(INguoiDungRepository iNguoiDungRepository, IMapper mapper)
        {
            this.iNguoiDungRepository = iNguoiDungRepository;
            this.iMapper = mapper;
        }

        public void Create(SaveNguoiDung save)
        {
            var nguoiDung = iMapper.Map<SaveNguoiDung, NguoiDung>(save);
            iNguoiDungRepository.Add(nguoiDung);
        }

        public SaveNguoiDung GetNguoiDung(int? iD)
        {
            var nguoiDung = iNguoiDungRepository.GetNguoiDung(iD);
            var ok = iMapper.Map<NguoiDung, SaveNguoiDung>(nguoiDung);
            return ok;
        }

        public NguoiDungViewModel GetNguoiDungs()
        {
            return new NguoiDungViewModel()
            {
                NguoiDungs = iNguoiDungRepository.GetNguoiDungs()
            };
        }

        public void remove(int? id)
        {
            iNguoiDungRepository.Remove(id);
        }
    }
}

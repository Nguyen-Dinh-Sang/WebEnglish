﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanArchitecture.Data.Context;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Data.Repository
{
    public class ChuDeRepository : IChuDeRepository
    {
        private WebEnglishDBContext webEnglishDBContext;

        public ICollection<ChuDe> GetSearchTenChuDe(string dataTimKiem, string loaiTimKiem)
        {
            var chuDe = from m in webEnglishDBContext.ChuDe
                        select m;
            if (!String.IsNullOrEmpty(dataTimKiem) && loaiTimKiem == "tenchude")
            {
                chuDe = chuDe.Where(m => m.TenChuDe.Contains(dataTimKiem));
                chuDe = chuDe.OrderBy(x => x.TenChuDe);
            }
            return chuDe.ToList();
        }
        public ChuDeRepository(WebEnglishDBContext webEnglishDBContext)
        {
            this.webEnglishDBContext = webEnglishDBContext;
        }
        public void Create(ChuDe chuDe)
        {
            if (chuDe.Id == 0)
            {
                webEnglishDBContext.ChuDe.Add(chuDe);
                webEnglishDBContext.SaveChanges();
            }
            else
            {
                ChuDe findResults = webEnglishDBContext.ChuDe.Find(chuDe.Id);
                findResults.TenChuDe = chuDe.TenChuDe;
                findResults.ThongTin = chuDe.ThongTin;
                webEnglishDBContext.SaveChanges();
            }
        }

        public ChuDe GetChuDe(int? Id)
        {
            ChuDe findResults = webEnglishDBContext.ChuDe.Find(Id);
            return findResults;
        }

        public IEnumerable<ChuDe> GetChuDes()
        {
            return webEnglishDBContext.ChuDe;
        }

        public void Remove(int? Id)
        {
            ChuDe findResults = webEnglishDBContext.ChuDe.Find(Id);
            webEnglishDBContext.ChuDe.Remove(findResults);
            webEnglishDBContext.SaveChanges();
        }

        public ICollection<BaiHoc> GetBaiHocs(int? Id)
        {
            var baiHoc = from m in webEnglishDBContext.BaiHoc
                           where m.IdchuDe == Id
                           select m;
            return baiHoc.OrderBy(x => x.BaiSo).ToList();
        }

        public ICollection<ThamGiaChuDe> GetThamGiaChuDes(int? Id)
        {
            throw new NotImplementedException();
        }
    }
}


using System.Collections.Generic;
using CleanArchitecture.Data.Context;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Data.Repository
{
    public class BaiHocRepository : IBaiHocRepository
    {
        private WebEnglishDBContext webEnglishDBContext;
        
        public BaiHocRepository(WebEnglishDBContext webEnglishDBContext)
        {
            this.webEnglishDBContext = webEnglishDBContext;
        }
        public void Add(BaiHoc entity)
        {
            if (entity.Id == 0)
            {
                webEnglishDBContext.BaiHoc.Add(entity);
                webEnglishDBContext.SaveChanges();
            }
            else
            {
                BaiHoc findResults = webEnglishDBContext.BaiHoc.Find(entity.Id);
                findResults.IdchuDe = entity.IdchuDe;
                findResults.BaiSo = entity.BaiSo;
                findResults.TenBaiHoc = entity.TenBaiHoc;
                webEnglishDBContext.SaveChanges();
            }
        }

        public void AddRange(IEnumerable<BaiHoc> entities)
        {
            webEnglishDBContext.BaiHoc.AddRange(entities);
        }

        public IEnumerable<BaiHoc> GetAll()
        {
            return webEnglishDBContext.BaiHoc.Include(g => g.IdchuDeNavigation);
        }


        public BaiHoc GetBy(int? Id)
        {
            BaiHoc findResults = webEnglishDBContext.BaiHoc.Find(Id);
            findResults.IdchuDeNavigation = webEnglishDBContext.ChuDe.Find(findResults.IdchuDe);
            return findResults;
        }

        public void Remove(int? Id)
        {
            BaiHoc findResults = webEnglishDBContext.BaiHoc.Find(Id);
            webEnglishDBContext.BaiHoc.Remove(findResults);
            webEnglishDBContext.SaveChanges();
        }
    }
}

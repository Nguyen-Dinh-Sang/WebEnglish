using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Data.Context;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Data.Repository
{
    public class ChuDeRepository : IChuDeRepository
    {
        private WebEnglishDBContext webEnglishDBContext;

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
                
                webEnglishDBContext.SaveChanges();
            }
        }

        public ChuDe GetChuDe(int? Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChuDe> GetChuDes()
        {
            throw new NotImplementedException();
        }

        public void Remove(int? Id)
        {
            throw new NotImplementedException();
        }
    }
}

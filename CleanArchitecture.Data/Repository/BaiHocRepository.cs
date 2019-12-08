using System.Linq;
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

        public BaiKiemTra GetBaiKiemTra(int? Id)
        {
            var baiKiemtra = from m in webEnglishDBContext.BaiKiemTra
                             where m.IdbaiHoc == Id
                             select m;
            if(baiKiemtra.Count() > 0)
            {
                return baiKiemtra.First();
            }
            return null;
        }

        public ICollection<CauHoi> GetCauHoi(int? Id)
        {
            var cauHoi = from m in webEnglishDBContext.CauHoi
                         where m.IdbaiKiemTra == Id
                         select m;
            return cauHoi.ToList();
        }

        public ChiTietBaiHoc GetChiTietBaiHoc(int? Id)
        {
            var chiTietBaiHoc = from m in webEnglishDBContext.ChiTietBaiHoc
                                where m.IdbaiHoc == Id
                                select m;
            if (chiTietBaiHoc.Count() > 0)
            {
                return chiTietBaiHoc.First();
            }
            return null;
        }

        public void AddChiTietBaiHoc(ChiTietBaiHoc chiTietBaiHoc)
        {
            if (chiTietBaiHoc.Id == 0)
            {
                webEnglishDBContext.ChiTietBaiHoc.Add(chiTietBaiHoc);
                webEnglishDBContext.SaveChanges();
            }
            else
            {
                ChiTietBaiHoc findResults = webEnglishDBContext.ChiTietBaiHoc.Find(chiTietBaiHoc.Id);
                findResults.NoiDung = chiTietBaiHoc.NoiDung;
                findResults.GhiChu = chiTietBaiHoc.GhiChu;
                findResults.LinkMp3 = chiTietBaiHoc.LinkMp3;
                webEnglishDBContext.SaveChanges();
            }
        }

        public void AddBaiKiemTra(BaiKiemTra baiKiemTra)
        {
            if (baiKiemTra.Id == 0)
            {
                webEnglishDBContext.BaiKiemTra.Add(baiKiemTra);
                webEnglishDBContext.SaveChanges();
            }
        }

        public void AddCauHoi(CauHoi cauHoi)
        {
            if(cauHoi.Id == 0)
            {
                webEnglishDBContext.CauHoi.Add(cauHoi);
                webEnglishDBContext.SaveChanges();
            } else
            {
                CauHoi findResults = webEnglishDBContext.CauHoi.Find(cauHoi.Id);
                findResults.CauHoi1 = cauHoi.CauHoi1;
                findResults.DapAnA = cauHoi.DapAnA;
                findResults.DapAnB = cauHoi.DapAnB;
                findResults.DapAnC = cauHoi.DapAnC;
                findResults.DapAnD = cauHoi.DapAnD;
                findResults.DapAnDung = cauHoi.DapAnDung;
                findResults.GoiY = cauHoi.GoiY;
                webEnglishDBContext.SaveChanges();
            }   
        }
        public int GetIDBaiHoc()
        {
            return webEnglishDBContext.BaiHoc.Max(x => x.Id);
        }

        public int GetIDBaiKiemTra()
        {
            return webEnglishDBContext.BaiKiemTra.Max(x => x.Id);
        }

        public CauHoi GetCauHoiEdit(int? Id)
        {
            var cauHoi = webEnglishDBContext.CauHoi.Find(Id);
            cauHoi.IdbaiKiemTraNavigation = webEnglishDBContext.BaiKiemTra.Find(cauHoi.IdbaiKiemTra);
            return cauHoi;
        }
    }
}

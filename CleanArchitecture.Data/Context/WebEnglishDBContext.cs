using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Data.Context
{  
    public class WebEnglishDBContext : DbContext
    {
        public WebEnglishDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<NguoiDung> NguoiDung { get; set; }
    }
}

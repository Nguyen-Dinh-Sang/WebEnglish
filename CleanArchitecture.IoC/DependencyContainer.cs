using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Mapping;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Data.Context;
using CleanArchitecture.Data.Repository;
using CleanArchitecture.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddScoped<INguoiDungService, NguoiDungService>();

            // Infrastructure.Data
            services.AddScoped<INguoiDungRepository, NguoiDungRepository>();

            services.AddScoped<WebEnglishDBContext>();

            services.AddAutoMapper(typeof(MappingProfile));

            // mỗi đứa một cặp
            services.AddScoped<IChuDeService, ChuDeService>();
            services.AddScoped<IChuDeRepository, ChuDeRepository>();

            services.AddScoped<IBaiHocService, BaiHocService>();
            services.AddScoped<IBaiHocRepository, BaiHocRepository>();
        }
    }
}

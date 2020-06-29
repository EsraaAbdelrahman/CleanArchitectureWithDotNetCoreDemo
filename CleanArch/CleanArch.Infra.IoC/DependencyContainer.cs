using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static  void RegisterServices(IServiceCollection services)
        {
            //Application layer
            services.AddScoped<ICourseService, CourseService>();
            //Domain Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}

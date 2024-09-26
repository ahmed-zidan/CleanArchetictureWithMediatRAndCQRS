using Core.IRepo;
using Infrastructure.Data;
using Infrastructure.Repo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class ConfugureService
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration) {
            services.AddTransient<IUnitOFWork, UnitOfWork>();
            services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer(
                configuration.GetConnectionString("MediatRDb")));
            return services;
        }
    }
}

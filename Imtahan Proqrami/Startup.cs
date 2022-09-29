using AutoMapper;
using Imtahan_Proqrami.BLL.Services;
using Imtahan_Proqrami.BLL.Services.IServices;
using Imtahan_Proqrami.DAL.Core;
using Imtahan_Proqrami.DAL.DatabaseContext;
using Imtahan_Proqrami.DAL.Repositories;
using Imtahan_Proqrami.DAL.Repositories.IRepositories;
using Imtahan_Proqrami.UnitOfWorks;
using Imtahan_Proqrami.UnitOfWorks.IUnitOfWorks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<DataContext>(options =>
            {

                options.UseSqlServer(Configuration.GetConnectionString("Db"));


            });
            services.AddScoped<ILessonRepository,LessonRepository>();
            services.AddScoped<ILessonService, LessonService>();
            services.AddScoped<IPupilRepository, PupilRepository>();
            services.AddScoped<IPupilService, PupilService>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(typeof(Automapper));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

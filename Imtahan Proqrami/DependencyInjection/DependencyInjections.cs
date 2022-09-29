using AutoMapper;
using Imtahan_Proqrami.BLL.Abstract;
using Imtahan_Proqrami.BLL.Concrete;
using Imtahan_Proqrami.DAL.Abstract;
using Imtahan_Proqrami.DAL.Concrete;
using Imtahan_Proqrami.DAL.Core;
using Imtahan_Proqrami.DAL.DatabaseContext;
using Imtahan_Proqrami.UnitOfWork.Abstract;
using Imtahan_Proqrami.UnitOfWork.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Imtahan_Proqrami.DependencyInjection
{
    public class DependencyInjections
    {
        private readonly IConfiguration Configuration;

        public DependencyInjections(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void RegisterServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<DataContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("Db"));
            });
            services.AddScoped<ILessonRepository, LessonRepository>();
            services.AddScoped<ILessonService, LessonService>();
            services.AddScoped<IPupilRepository, PupilRepository>();
            services.AddScoped<IPupilService, PupilService>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IUnitOfWorks, UnitOfWorks>();

            services.AddAutoMapper(typeof(Automapper));
        }
    }
}

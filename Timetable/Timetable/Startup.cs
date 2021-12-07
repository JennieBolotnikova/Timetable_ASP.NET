using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.Business.IServices;
using TimetableApp.Business.Services;
using TimetableApp.DataAccess.Interfaces;
using TimetableApp.DataAccess.Repositories;
using TimetableApp.DataAccess.Entities;
using TimetableApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using TimetableApp.Business.Mapper;
using TimetableApp.Web.Mapper;
using TimetableApp.DataAccess.Middleware;

namespace TimetableApp
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
            // внедрение зависимости дл€ доступа к Ѕƒ с использованием EF
            string connection = Configuration.GetConnectionString("SqlServerConnection");
            services.AddDbContext<TimetableContext>(options => options.UseSqlServer(connection));
            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new BusinessLogicMapperProfile());
                mc.AddProfile(new WebUIMapperProfile());
             });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddControllersWithViews();
            services.AddSession();

            //
            services.AddScoped<IActivityTypeService, ActivityTypeService>();
            services.AddScoped<IBellService, BellService>();
            services.AddScoped<IBuildingService, BuildingService>();
            services.AddScoped<IClassroomsService, ClassroomsService>();
            services.AddScoped<IClassroomTypeService, ClassroomTypeService>();
            services.AddScoped<IDayService, DayService>();
            services.AddScoped<IDisciplineService, DisciplineService>();
            services.AddScoped<IFacultyService, FacultyService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<ISemesterService, SemesterService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<ITimetableService, TimetableService>();
            //
            services.AddScoped<IRepository<ActivityType>, ActivityTypeRepository>();
            services.AddScoped<IRepository<Bell>, BellRepository>();
            services.AddScoped<IRepository<Building>, BuildingRepository>();
            services.AddScoped<IRepository<Classroom>, ClassroomRepository>();
            services.AddScoped<IRepository<ClassroomType>, ClassroomTypeRepository>();
            services.AddScoped<IRepository<Day>, DayRepository>();
            services.AddScoped<IRepository<Discipline>, DisciplineRepository>();
            services.AddScoped<IRepository<Faculty>, FacultyRepository>();
            services.AddScoped<IRepository<Group>, GroupRepository>();
            services.AddScoped<IRepository<Semester>, SemesterRepository>();
            services.AddScoped<IRepository<Teacher>, TeacherRepository>();
            services.AddScoped<IRepository<Timetable>, TimetableRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.AddEfDiagrams<TimetableContext>();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();
            // добавл€ем компонент middleware по инициализации базы данных и производим инициализацию базы
            //app.UseDbInitializer();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

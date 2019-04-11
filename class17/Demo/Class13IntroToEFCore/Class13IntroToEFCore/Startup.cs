using Class13IntroToEFCore.Data;
using Class13IntroToEFCore.Models.Interfaces;
using Class13IntroToEFCore.Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Class13IntroToEFCore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get; }


        public Startup(IHostingEnvironment environment)
        {
            Environment = environment;
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();


            //Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //var connectionString = Environment.IsDevelopment()
            //    ? Configuration.GetConnectionString("DefaultConnection")
            //    : Configuration.GetConnectionString("ProductionConnection");


            services.AddDbContext<StudentEnrollmentDbContext>(options =>
            options.UseSqlServer(Configuration["DefaultConnection"]));


            // Mappings
            services.AddScoped<ICourseManager, CourseService>();
            services.AddTransient<IStudentManager, StudentService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(route =>
            {
                route.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}

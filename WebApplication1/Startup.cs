using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        //声明跨域策略名称
        readonly string MyCorsPolicy = "CorsPolicy";
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //引入跨域服务
            services.AddCors(options => options.AddPolicy(MyCorsPolicy, builder => {
                builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            }));
            //引入ef叫做ProductContext的appsettings.json里面叫做"ProductDB"的信息
            services.AddDbContext<HongDaContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("ProductDB"));
            });
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            //允许跨域请求
            app.UseCors();  
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers().RequireCors(MyCorsPolicy);
            });
            
        }
    }
}

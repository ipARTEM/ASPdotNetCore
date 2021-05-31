using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPdotNetCore
{
    public class Startup
    {
       
        public void ConfigureServices(IServiceCollection services)
        {
            // добавляем поддержку контроллеров и представлений(MVC)
            services.AddControllersWithViews()
                // выставляем совместимость с asp.net core 3.0
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();

        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //подключаем поддержку статичных файлов в приложении (css, js и т.д.)
            app.UseStaticFiles();

            //регистрируем нужные нам маршруты 
            app.UseEndpoints(endpoints =>
            {
                 endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                
            });
        }
    }
}

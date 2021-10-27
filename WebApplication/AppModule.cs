using Volo.Abp.Modularity;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;

// 没有模块类就无法构建具体的app应用，每个模块都要含有模块类，
// 把复杂的系统分解成可管理的模块

namespace WebApplication
{
    // 定义依赖模块，配置AspCore里面的管道，在应用启动之前进行
    [DependsOn(typeof(AbpAspNetCoreMvcModule))]
    public class AppModule : AbpModule // 使用模块初始化应用
    {
        // 执行OnAppInit初始化方法，复写方法，用于构建中间件管道,配置管道
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseRouting();

            app.UseConfiguredEndpoints(); // 配置Abp端点，使用控制器
        }
    }
}

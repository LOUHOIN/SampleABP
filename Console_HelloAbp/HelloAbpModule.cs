using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;

namespace Console_HelloAbp
{
    [DependsOn(typeof(AbpAutofacModule))]
    public class HelloAbpModule : AbpModule //继承于AbpModule类，ABP启动模块
    {
        // 模块配置
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);

            context.Services.AddTransient<HelloWorldService>();
            // context.Services.AddTransient<HelloWorldServiceDependency>();
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp;

namespace Console_HelloAbp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用启动模块类来创建Abp应用
            // Abp工厂类的creat方法,在泛型里面启动模块配置
            var application = AbpApplicationFactory.Create<HelloAbpModule>(options=>
            {
                options.UseAutofac();//配置调用autofac方法
            });
            application.Initialize(); // 初始化app方法

            // 注入服务：从应用对象的容器application中获取已经注册的服务
            // 从服务提供者里获取,使用泛型方法获取
            var service = application.ServiceProvider.GetService<HelloWorldService>();
            service.helloword();

            var serviceDep = application.ServiceProvider.GetService<HelloWorldServiceDependency>();
            serviceDep.helloword_Dep();
            // application.ServiceProvider.GetService<HelloWorldServiceDependency>().helloword_Dep();


            

            

        }
    }
}

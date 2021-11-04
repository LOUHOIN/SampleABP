using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Console_HelloAbp
{
    // HelloWorld 服务类，实现一个接口，由于Abp使用/依赖注入/，








    // 以类名作为标识，进行自动注册





    // 通过特性方式定义依赖
    [Dependency(ServiceLifetime.Transient)]
    public class HelloWorldServiceDependency// : ITransientDependency
    {
        public void helloword_Dep()
        {
            Console.WriteLine("Hello World:Dependency");
        }
    }
}

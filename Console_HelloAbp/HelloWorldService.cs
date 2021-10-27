using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Console_HelloAbp
{
    // HelloWorld 服务类，实现一个接口，由于Abp使用/依赖注入/，
    // 以类名作为标识，进行自动注册
    public class HelloWorldService //: ITransientDependency
    {
        public void helloword()
        {
            Console.WriteLine("Hello World");
        }
    }
}

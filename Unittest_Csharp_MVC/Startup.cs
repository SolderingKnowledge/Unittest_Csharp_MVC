using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Unittest_Csharp_MVC.Startup))]
namespace Unittest_Csharp_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

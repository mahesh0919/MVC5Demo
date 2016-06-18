using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Demo.Startup))]
namespace MVC5Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

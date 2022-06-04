using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnishaDemoProjectMVC.Startup))]
namespace AnishaDemoProjectMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

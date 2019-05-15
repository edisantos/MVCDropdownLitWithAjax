using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDropdowlist.MVC.Startup))]
namespace MVCDropdowlist.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

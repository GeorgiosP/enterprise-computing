using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(summerWebApp.Startup))]
namespace summerWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

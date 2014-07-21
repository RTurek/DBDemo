using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OGSys.Web.Startup))]
namespace OGSys.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

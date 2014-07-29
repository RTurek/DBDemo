using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBDemo.Web.Startup))]
namespace DBDemo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

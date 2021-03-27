using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CINC.Web.Startup))]
namespace CINC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

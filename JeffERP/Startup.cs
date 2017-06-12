using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JeffERP.Startup))]
namespace JeffERP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

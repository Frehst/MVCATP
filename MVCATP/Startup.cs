using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCATP.Startup))]
namespace MVCATP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

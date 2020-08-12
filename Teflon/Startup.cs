using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Teflon.Startup))]
namespace Teflon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

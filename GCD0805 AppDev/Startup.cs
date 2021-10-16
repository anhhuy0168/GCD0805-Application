using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GCD0805_AppDev.Startup))]
namespace GCD0805_AppDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

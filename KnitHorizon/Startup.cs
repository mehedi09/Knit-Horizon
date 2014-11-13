using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnitHorizon.Startup))]
namespace KnitHorizon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

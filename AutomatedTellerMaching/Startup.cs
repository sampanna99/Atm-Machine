using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomatedTellerMaching.Startup))]
namespace AutomatedTellerMaching
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

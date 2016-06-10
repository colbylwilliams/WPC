using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WpcService.Startup))]

namespace WpcService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}
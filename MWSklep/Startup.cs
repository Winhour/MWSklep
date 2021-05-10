using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MWSklep.Startup))]
namespace MWSklep
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

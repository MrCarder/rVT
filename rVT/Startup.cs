using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rVT.Startup))]
namespace rVT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

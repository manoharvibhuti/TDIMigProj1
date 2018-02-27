using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDIMigProj1.Startup))]
namespace TDIMigProj1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SNSimplev7.Startup))]
namespace SNSimplev7
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

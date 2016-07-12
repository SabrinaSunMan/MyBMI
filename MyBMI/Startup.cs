using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBMI.Startup))]
namespace MyBMI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GCD1670_Assignment1.Startup))]
namespace GCD1670_Assignment1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

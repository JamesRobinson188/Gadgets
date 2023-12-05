using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gadgets.Startup))]
namespace Gadgets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

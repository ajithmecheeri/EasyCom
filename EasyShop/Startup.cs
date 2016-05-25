using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyShop.Startup))]
namespace EasyShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

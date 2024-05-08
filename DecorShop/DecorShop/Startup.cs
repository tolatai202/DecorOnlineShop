using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DecorShop.Startup))]
namespace DecorShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

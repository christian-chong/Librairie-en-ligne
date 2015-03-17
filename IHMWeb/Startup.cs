using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IHMWeb.Startup))]
namespace IHMWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

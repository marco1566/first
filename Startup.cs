using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppTestMVC_PS.Startup))]
namespace WebAppTestMVC_PS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

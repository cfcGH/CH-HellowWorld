using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CH.HelloWorld.Web.Startup))]
namespace CH.HelloWorld.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

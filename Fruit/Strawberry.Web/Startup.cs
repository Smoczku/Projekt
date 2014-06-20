using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Strawberry.Web.Startup))]
namespace Strawberry.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

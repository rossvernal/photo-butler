using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(photo_butler_web.Startup))]
namespace photo_butler_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

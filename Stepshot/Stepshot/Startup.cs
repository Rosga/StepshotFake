using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stepshot.Startup))]
namespace Stepshot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

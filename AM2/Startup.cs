using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AM2.Startup))]
namespace AM2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

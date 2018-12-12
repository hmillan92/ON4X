using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ON4X.Backend.Startup))]
namespace ON4X.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

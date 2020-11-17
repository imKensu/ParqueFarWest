using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParqueFarWest.Startup))]
namespace ParqueFarWest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

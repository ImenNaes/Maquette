using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Maquette.Startup))]
namespace Maquette
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(stjornutextar.Startup))]
namespace stjornutextar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

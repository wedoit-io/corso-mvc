using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CorsoMVC.Startup))]
namespace CorsoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

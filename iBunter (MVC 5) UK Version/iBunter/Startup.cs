using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iBunter.Startup))]
namespace iBunter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_OnlineBanking.Startup))]
namespace MVC_OnlineBanking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FSDPortfolio.Startup))]
namespace FSDPortfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

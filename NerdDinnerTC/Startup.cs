using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NerdDinnerTC.Startup))]
namespace NerdDinnerTC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

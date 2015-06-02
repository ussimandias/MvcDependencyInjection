using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SearchClaim.Startup))]
namespace SearchClaim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

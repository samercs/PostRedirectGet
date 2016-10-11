using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PostRedirectGet.Startup))]
namespace PostRedirectGet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

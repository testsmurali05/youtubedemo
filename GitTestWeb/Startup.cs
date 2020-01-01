using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTestWeb.Startup))]
namespace GitTestWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SushiRestoran.Startup))]
namespace SushiRestoran
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

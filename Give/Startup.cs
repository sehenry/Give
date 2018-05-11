using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Give.Startup))]
namespace Give
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

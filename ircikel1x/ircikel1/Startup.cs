using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ircikel1.Startup))]
namespace ircikel1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

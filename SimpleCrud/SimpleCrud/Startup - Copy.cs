using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleCrud.Startup))]
namespace SimpleCrud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

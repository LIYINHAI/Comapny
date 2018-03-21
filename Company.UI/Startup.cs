using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Company.UI.Startup))]
namespace Company.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

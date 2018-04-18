using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DNet46AISite.Startup))]
namespace DNet46AISite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

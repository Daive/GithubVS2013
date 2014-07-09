using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sofa.Startup))]
namespace Sofa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

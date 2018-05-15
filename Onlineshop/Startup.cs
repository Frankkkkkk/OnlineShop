using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewAssign2.Startup))]
namespace NewAssign2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Caught_.Startup))]
namespace Caught_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

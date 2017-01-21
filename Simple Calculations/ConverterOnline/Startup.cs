using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConverterOnline.Startup))]
namespace ConverterOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

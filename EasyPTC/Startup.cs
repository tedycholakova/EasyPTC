using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyPTC.Startup))]
namespace EasyPTC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

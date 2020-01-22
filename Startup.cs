using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sk611715MIS4200.Startup))]
namespace Sk611715MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

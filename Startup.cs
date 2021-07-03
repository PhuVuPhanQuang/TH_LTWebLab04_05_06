using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TH_LTWebLab04_05_06.Startup))]
namespace TH_LTWebLab04_05_06
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

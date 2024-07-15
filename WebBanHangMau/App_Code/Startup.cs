using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBanHangMau.Startup))]
namespace WebBanHangMau
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

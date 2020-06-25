using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab2_le_thanh_phong.Startup))]
namespace lab2_le_thanh_phong
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCuatroMovie.Startup))]
namespace MvcCuatroMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoBienes.Startup))]
namespace ProyectoBienes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

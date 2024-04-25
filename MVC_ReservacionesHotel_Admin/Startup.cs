using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_ReservacionesHotel_Admin.Startup))]
namespace MVC_ReservacionesHotel_Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

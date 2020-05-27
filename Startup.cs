using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeApp.Startup))]
namespace TimeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

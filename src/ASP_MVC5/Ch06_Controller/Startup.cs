using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ch06_Controller.Startup))]
namespace Ch06_Controller
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

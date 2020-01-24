using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Crispy.Startup))]
namespace Crispy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

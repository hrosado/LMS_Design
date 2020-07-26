using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LMS_Design.Startup))]
namespace LMS_Design
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

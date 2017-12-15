using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewbridgeLibrary.Startup))]
namespace NewbridgeLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

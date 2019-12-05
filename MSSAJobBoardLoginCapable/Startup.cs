using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSSAJobBoardLoginCapable.Startup))]
namespace MSSAJobBoardLoginCapable
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

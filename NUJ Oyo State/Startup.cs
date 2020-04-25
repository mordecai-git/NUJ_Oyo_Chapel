using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NUJ_Oyo_State.Startup))]
namespace NUJ_Oyo_State
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

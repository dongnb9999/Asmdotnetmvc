using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asm.Startup))]
namespace Asm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

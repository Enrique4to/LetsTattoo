using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LetsTatto.Backend.Startup))]
namespace LetsTatto.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

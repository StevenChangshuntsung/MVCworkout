using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewRepo.Startup))]
namespace NewRepo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

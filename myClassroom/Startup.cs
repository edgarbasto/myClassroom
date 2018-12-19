using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myClassroom.Startup))]
namespace myClassroom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

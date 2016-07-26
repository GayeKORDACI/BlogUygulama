using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogUygulama.Startup))]
namespace BlogUygulama
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
          
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BinarySearchTreeDemo.Startup))]
namespace BinarySearchTreeDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

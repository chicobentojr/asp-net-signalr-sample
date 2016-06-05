using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(asp_net_signalr.Startup))]

namespace asp_net_signalr
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
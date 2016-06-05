using asp_net_signalr.Hubs;
using Microsoft.AspNet.SignalR;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_net_signalr.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Api()
        {
            var dict = HttpUtility.ParseQueryString(Request.QueryString.ToString());
            var json = dict.AllKeys.ToDictionary(k => k, k => dict[k]);
            var context = GlobalHost.ConnectionManager.GetHubContext<MainHub>();

            context.Clients.All.receiveData(json);

            return Json("data sent", JsonRequestBehavior.AllowGet);
        }
    }
}
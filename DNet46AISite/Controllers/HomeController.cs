using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Web.Mvc;

namespace DNet46AISite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var req = WebRequest.Create("http://bing.com");
            var response = req.GetResponse();
            using (var s = response.GetResponseStream())
            {
                byte[] content = new byte[512];
                s.Read(content, 0, content.Length);
                var contentS = System.Text.Encoding.UTF8.GetString(content);
                Console.WriteLine(contentS);
                ViewBag.Content = contentS;
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page." + Assembly.GetExecutingAssembly().FullName;

            ViewBag.Assemblies = AppDomain.CurrentDomain.GetAssemblies();

            ViewBag.Modules = Process.GetCurrentProcess().Modules;

            ViewBag.EnvironmentVariables = Environment.GetEnvironmentVariables();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
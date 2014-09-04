using System;
using System.IO;
using System.Web.Mvc;

namespace FileCounterMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string siteFolder;
            int fileCount;

            if (Environment.GetEnvironmentVariable("home") != null)
            {
                // Maps to the physical path of your site in Azure
                siteFolder =
                    Environment.ExpandEnvironmentVariables(@"%HOME%\site\wwwroot");
            }
            else
            {
                // Maps to the current sites root physical path.  Allows us to run locally.
                siteFolder = Server.MapPath("/");
            }

            fileCount =
                Directory.GetFiles(siteFolder, "*.*", SearchOption.AllDirectories).Length;
            return View(model: fileCount);
        }
    }
}
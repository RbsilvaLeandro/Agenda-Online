using System.Web.Optimization;

namespace AgendaOnline.MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/modernizr-2.6.2.js",
                        "~/Scripts/MenuAdmin.js",
                        "~/Scripts/custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/font-awesome.min.css",
                      "~/Content/bootstrap.css",
                      "~/Content/custom.css"));

            bundles.Add(new ScriptBundle("~/bundles/Admin").Include("~/Content/Site.css"));
        }
    }
}

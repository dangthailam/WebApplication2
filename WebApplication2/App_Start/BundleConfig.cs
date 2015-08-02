using System.Web.Optimization;

namespace WebApplication2
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/js").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.js"
                ));

            bundles.Add(new ScriptBundle("~/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/angular-animate.js",
                "~/Scripts/angular-resource.js",
                "~/Scripts/angular-sanitize.js"
                ));

            bundles.Add(new ScriptBundle("~/angularUI").Include(
                "~/Scripts/dialogs/*.js",
                "~/Scripts/toaster/*.js",
                "~/Scripts/angular-ui/*.js"
                ));

            bundles.Add(new StyleBundle("~/content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-theme.css",
                "~/Content/ui-bootstrap-csp.css",
                "~/Content/custom.css",
                "~/Content/shared.css",
                "~/Content/font-awesome.css"
                ));

            bundles.Add(new ScriptBundle("~/angularDirectives").Include(
                "~/AngularAppContext/Controllers/*.js",
                "~/AngularAppContext/Services/*.js",
                "~/AngularAppContext/Directives/*.js"
                ));


            BundleTable.EnableOptimizations = false;
        }
    }
}
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
                "~/Scripts/angular-sanitize.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                "~/Scripts/angular-ui/ui-bootstrap.js"
                ));

            bundles.Add(new StyleBundle("~/content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-theme.css",
                "~/Content/ui-bootstrap-csp.css",
                "~/Content/sb-admin-2.css"
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
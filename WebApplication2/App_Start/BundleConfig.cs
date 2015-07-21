using System.Web.Optimization;

namespace WebApplication2
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            ScriptBundle bootstrapScripts = new ScriptBundle("~/Scripts/jquery-{version}.js");

            bootstrapScripts.Include("~/Scripts/bootstrap.js");

            ScriptBundle angularScripts = new ScriptBundle("~/Scripts/angular.js");

            angularScripts.Include("~/Scripts/angular-route.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                "~/Scripts/angular-ui/ui-bootstrap.js");

            StyleBundle bootstrapCss = new StyleBundle("~/Content/bootstrap.css");

            bootstrapCss.Include("~/Content/bootstrap-theme.css",
                "~/Content/ui-bootstrap-csp.css");

            bundles.Add(bootstrapScripts);
            bundles.Add(angularScripts);
            bundles.Add(bootstrapCss);
            BundleTable.EnableOptimizations = true;
        }
    }
}
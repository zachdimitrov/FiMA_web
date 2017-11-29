namespace Fima.Web
{
    using System.Web.Optimization;

    public static class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScripts(bundles);
            RegisterStyles(bundles);
        }

        private static void RegisterScripts(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include("~/Scripts/jquery-ui-1.12.1.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/Bootstrap/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/grid").Include("~/Scripts/gridmvc.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/local").Include("~/Scripts/sidebar.js"));
        }

        private static void RegisterStyles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/site.css",
                "~/Content/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/jqueryui").Include(
                "~/Content/themes/base/jquery-ui.css"));

            bundles.Add(new StyleBundle("~/Content/pure").Include(
                "~/Content/third-party/pure.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                "~/Content/Bootstrap/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/grid").Include(
                "~/Content/Gridmvc.css"));
        }
    }
}

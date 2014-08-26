using System.Web;
using System.Web.Optimization;

namespace Portal
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;

            #region For FrontEnd

            bundles.Add(new ScriptBundle("~/bundles/frontend/scripts").Include(
                        "~/Scripts/FrontEnd/bootstrap-hover-dropdown-min.js",
                        "~/Scripts/FrontEnd/back-to-top.js",
                        "~/Scripts/FrontEnd/plugins/jquery-placeholder/jquery.placeholder.js",
                        "~/Scripts/FrontEnd/plugins/pretty-photo/js/jquery.prettyPhoto.js",
                        "~/Scripts/FrontEnd/plugins/flexslider/jquery.flexslider-min.js",
                        "~/Scripts/FrontEnd/plugins/jflickrfeed/jflickrfeed-min.js",
                        "~/Scripts/FrontEnd/main.js",
                        "~/Scripts/FrontEnd/map.js"));

            bundles.Add(new ScriptBundle("~/bundles/frontend/jquery").Include(
                        "~/Scripts/FrontEnd/jquery-1.10.2-min.js",
                        "~/Scripts/FrontEnd/jquery-migrate-1.2.1-min.js",
                        "~/Scripts/FrontEnd/plugins/bootstrap/js/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/frontend/jqueryui").Include(
                        "~/Scripts/FrontEnd/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/frontend/jqueryval").Include(
                        "~/Scripts/FrontEnd/jquery.unobtrusive*",
                        "~/Scripts/FrontEnd/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/frontend/modernizr").Include(
                        "~/Scripts/FrontEnd/modernizr-*"));

            //Css Part
            bundles.Add(new StyleBundle("~/Content/frontend/globalcss").Include(
                "~/Content/FrontEnd/plugins/bootstrap/css/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/frontend/plugincss").Include(
                "~/Content/FrontEnd/plugins/font-awesome/css/font-awesome.css",
                "~/Content/FrontEnd/plugins/flexslider/flexslider.css",
                "~/Content/FrontEnd/plugins/pretty-photo/css/prettyPhoto.css"
                ));

            bundles.Add(new StyleBundle("~/Content/frontend/stylescss").Include(
                "~/Content/FrontEnd/styles.css"));
            #endregion
        }
    }
}

using System.Web;
using System.Web.Optimization;

namespace NUJ_Oyo_State
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/js/jquery-1.12.1.min.js",
                      "~/Scripts/js/popper.min.js",
                      "~/Scripts/js/bootstrap.min.js",
                      "~/Scripts/js/owl.carousel.min.js",
                      "~/Scripts/js/jquery.nice-select.min.js",
                      "~/Scripts/js/jquery.form.js",
                      "~/Scripts/js/jquery.validate.min.js",
                      "~/Scripts/js/contact.js",
                      "~/Scripts/js/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/animate.css",
                      "~/Content/owl.carousel.min.css",
                      "~/Content/themify-icons.css",
                      "~/Content/carousel.css",
                      "~/Content/style.css",
                      "~/Content/Site.css"));
                
        }
    }
}

using System.Web;
using System.Web.Optimization;

namespace Store
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Website CSS
            bundles.Add(new StyleBundle("~/Content/first").Include(
                "~/Content/Website_Design/vendor/bootstrap/css/bootstrap.min.css",
                "~/Content/Website_Design/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
                "~/Content/Website_Design/fonts/iconic/css/material-design-iconic-font.min.css"));
            bundles.Add(new StyleBundle("~/Content/Second").Include(
                "~/Content/Website_Design/fonts/linearicons-v1.0.0/icon-font.min.css",
                "~/Content/Website_Design/vendor/animate/animate.css",
                "~/Content/Website_Design/vendor/css-hamburgers/hamburgers.min.css"));
            bundles.Add(new StyleBundle("~/Content/Third").Include(
                "~/Content/Website_Design/vendor/animsition/css/animsition.min.css",
                "~/Content/Website_Design/vendor/select2/select2.min.css",
                "~/Content/Website_Design/vendor/daterangepicker/daterangepicker.css"));
            bundles.Add(new StyleBundle("~/Content/Forth").Include(
                "~/Content/Website_Design/vendor/slick/slick.css",
                "~/Content/Website_Design/vendor/MagnificPopup/magnific-popup.css",
                "~/Content/Website_Design/vendor/perfect-scrollbar/perfect-scrollbar.css"));
            bundles.Add(new StyleBundle("~/Content/Fifth").Include(
                "~/Content/Website_Design/css/util.css",
                "~/Content/Website_Design/css/main.css"));
        }
    }
}

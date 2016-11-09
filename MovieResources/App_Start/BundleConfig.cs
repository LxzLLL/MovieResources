using System.Web;
using System.Web.Optimization;

namespace MovieResources
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Resources/jquery/jquery-2.2.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Resources/jquery/jquery.validate.js"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Resources/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Resources/bootstrap/bootstrap.js",
                      "~/Resources/bootstrap/respond.js",
                      "~/Resources/bootstrap/modernizr-2.6.2.js"));

            bundles.Add(new ScriptBundle("~/bundles/backstrech").Include(
                      "~/Resources/backstrech/jquery.backstrech.js"));

            bundles.Add(new ScriptBundle("~/bundles/smoothscroll").Include(
                      "~/Resources/smooths-croll/jquery.smooth-scroll.js"));

            bundles.Add(new StyleBundle("~/Styles/css").Include(
                      "~/Resources/bootstrap/bootstrap.css",
                      "~/Resources/Site.css",
                      "~/Resources/Custom.css",
                      "~/Resources/font-awesome/font-awesome.css"));

        }
    }
}

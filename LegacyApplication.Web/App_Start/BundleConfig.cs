﻿using System.Web;
using System.Web.Optimization;

namespace LegacyApplication.Web
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

            //VUE #2
            bundles.Add(new ScriptBundle("~/bundles/vue").Include(
                      "~/Scripts/vue/vue.min.js",
                      "~/Scripts/vue/vue-resource.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/vue-app").Include(
                      "~/Scripts/vue/app/*.js"));

            bundles.Add(new ScriptBundle("~/bundles/vue-app-1").Include(
                      "~/Scripts/vue/app-1/*.js"));

            bundles.Add(new ScriptBundle("~/bundles/vue-app-2").Include(
                      "~/Scripts/vue/app-2/*.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}

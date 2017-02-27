﻿using System.Web;
using System.Web.Optimization;

namespace ContactApplication
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/js/lib/jquery-2.2.4.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/js/lib/bootstrap.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/js/lib/jquery.dataTables.min.js",
                         "~/js/lib/dataTables.bootstrap.min.js",
                         "~/js/lib/dataTables.colReorder.min.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/jquery.dataTables.min.css",
                      "~/css/jquery.dataTables_themeroller.min.css",
                      "~/css/dataTables.bootstrap.min.css",
                      "~/css/dataTables.bootstrap.min.css",
                      "~/css/site.css"));
        }
    }
}

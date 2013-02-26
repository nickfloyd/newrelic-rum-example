using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace RUMExample.Utils
{
    public class ViewHelpers
    {

        public static bool ShouldRenderRum(string controllerName, string actionName){

            var searchString = controllerName + "/" + actionName;

            // Can use a static string, config, db etc... to store values
            var pagesToExclude = ConfigurationManager.AppSettings["NewRelic.Rum.ExcludeViews"].Split(new char[] { ',' });
            
            bool shouldRender = !Array.Exists
            (
                pagesToExclude,
                delegate(string s) { return s == searchString; }
            );

            return shouldRender;
        }

    }
}
﻿using System.Web;
using System.Web.Mvc;

namespace Form_Ajax_Jquery
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

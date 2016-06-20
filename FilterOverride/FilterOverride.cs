using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MVC5Demo.FilterOverride
{
    public class FilterOverriddeAttribute : FilterAttribute,IOverrideFilter
    {
        public Type FiltersToOverride
        {
            get
            {
                return typeof(IAuthorizationFilter);
            }
        }
    }
}
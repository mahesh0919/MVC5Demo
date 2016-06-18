using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5Demo.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int UnitsinStock { get; set; }
    }
}
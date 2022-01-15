using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wad.Models
{
    public class product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public int QuantityiPerUnit { get; set; }
        public double  UnitPrice { get; set; }
        public string UnitslnStock { get; set; }


    }
}
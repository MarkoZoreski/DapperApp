using System;
using System.Collections.Generic;
using System.Text;

namespace DapperConsoleApp.Models
{
    public class Order
    {
        public int MyProperty { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipVia { get; set; }
        public float Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAdress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCoe { get; set; }
        public string ShipCountry { get; set; }

    }
}

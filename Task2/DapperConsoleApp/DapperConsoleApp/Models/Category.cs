using System;

namespace DapperConsoleApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public int TotalQuantitySold { get; set; }
    }
}
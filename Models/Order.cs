using System;
using System.Collections.Generic;

namespace CheckerLangDaiHocAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderDetail> details { get; set; }
    }
}
using System;
using System.Collections.Generic;

#nullable disable

namespace daaataabasefirst.Entities
{
    public partial class OrderLine
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public TimeSpan ElapsedTime { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}

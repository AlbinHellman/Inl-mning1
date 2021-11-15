using System;
using System.Collections.Generic;

#nullable disable

namespace daaataabasefirst.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public string OurReference { get; set; }
        public string TrackingNumber { get; set; }
        public string DeliveryCompany { get; set; }
        public DateTimeOffset EstimatedShippingTime { get; set; }
        public string Status { get; set; }
        public int DeliveryTypeId { get; set; }
        public int BillingAddressId { get; set; }
        public int AddressId { get; set; }

        public virtual UserAddress Address { get; set; }
        public virtual UserAddress BillingAddress { get; set; }
        public virtual DeliveryType DeliveryType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}

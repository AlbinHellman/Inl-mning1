using System;
using System.Collections.Generic;

#nullable disable

namespace daaataabasefirst.Entities
{
    public partial class UserAddress
    {
        public UserAddress()
        {
            OrderAddresses = new HashSet<Order>();
            OrderBillingAddresses = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int BillingAddressId { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual BillingAddress BillingAddress { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Order> OrderAddresses { get; set; }
        public virtual ICollection<Order> OrderBillingAddresses { get; set; }
    }
}

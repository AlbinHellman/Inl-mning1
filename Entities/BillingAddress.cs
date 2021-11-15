using System;
using System.Collections.Generic;

#nullable disable

namespace daaataabasefirst.Entities
{
    public partial class BillingAddress
    {
        public BillingAddress()
        {
            UserAddresses = new HashSet<UserAddress>();
        }

        public int Id { get; set; }
        public string AddressLine { get; set; }
        public long? HouseNr { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}

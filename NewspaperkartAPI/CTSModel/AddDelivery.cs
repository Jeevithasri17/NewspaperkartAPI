using System;
using System.Collections.Generic;

#nullable disable

namespace NewspaperkartAPI.CTSModel
{
    public partial class AddDelivery
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string NewspaperName { get; set; }
        public string Phoneno { get; set; }
        public string DeliveryMan { get; set; }
    }
}

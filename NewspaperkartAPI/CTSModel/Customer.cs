using System;
using System.Collections.Generic;

#nullable disable

namespace NewspaperkartAPI.CTSModel
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Title { get; set; }
        public string Subscriptiontype { get; set; }
        public string Timeperiod { get; set; }
    }
}

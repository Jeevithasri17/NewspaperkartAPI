using System;
using System.Collections.Generic;

#nullable disable

namespace NewspaperkartAPI.CTSModel
{
    public partial class Newspaper
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Price { get; set; }
    }
}

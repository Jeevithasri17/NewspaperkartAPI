using System;
using System.Collections.Generic;

#nullable disable

namespace NewspaperkartAPI.CTSModel
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phoneno { get; set; }
        public string NewspaperTitle { get; set; }
        public string Issue { get; set; }
    }
}

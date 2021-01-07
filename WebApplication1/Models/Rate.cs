using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Rate
    {
        public int Id { get; set; }
        public string RateName { get; set; }
        public double RateFloat { get; set; }
        public string Info { get; set; }
    }
}

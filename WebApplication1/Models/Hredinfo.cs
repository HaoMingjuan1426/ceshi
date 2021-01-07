using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Hredinfo
    {
        public int Id { get; set; }
        public int RedId { get; set; }
        public int RedCount { get; set; }
        public DateTime CreateDate { get; set; }
        public int ResetDays { get; set; }
        public int Days { get; set; }
        public string Isf { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Hredlog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OldCount { get; set; }
        public int Count { get; set; }
        public string Addsub { get; set; }
        public string Type { get; set; }
        public string DescInfo { get; set; }
    }
}

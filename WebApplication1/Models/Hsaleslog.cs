using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Hsaleslog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OldCount { get; set; }
        public string IdCard { get; set; }
        public string StartDate { get; set; }
        public string Result { get; set; }
        public string Info { get; set; }
    }
}

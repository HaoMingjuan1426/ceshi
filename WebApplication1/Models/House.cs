using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class House
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string GroupId { get; set; }
        public string FloorId { get; set; }
        public string UnitId { get; set; }
        public string HId { get; set; }
        public int State { get; set; }
    }
}

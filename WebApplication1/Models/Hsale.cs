using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Hsale
    {
        public int Id { get; set; }
        public int? HouseId { get; set; }
        public int? UserId { get; set; }
        public int? State { get; set; }
        public string CustomerName { get; set; }
        public string IdCard { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Family { get; set; }
        public string Job { get; set; }
        public string Address { get; set; }
        public string FamilyCount { get; set; }
        public string PayType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string EndDate { get; set; }
    }
}

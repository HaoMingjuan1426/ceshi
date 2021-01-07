using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Huser
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string UserNick { get; set; }
        public string UserPhone { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime LastDate { get; set; }
        public int Count { get; set; }
        public int Isf { get; set; }
    }
}

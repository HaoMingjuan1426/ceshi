using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Bankinfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserNick { get; set; }
        public int? BankCard { get; set; }
        public string BankAddress { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}

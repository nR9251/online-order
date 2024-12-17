using System;
using System.Collections.Generic;
using System.ComponentModel;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prjonlineorder.Models
{
    public partial class TableA
    {
        [DisplayName("訂單編號")]
        public string TId { get; set; }
        [DisplayName("桌號")]
        public int? TDesk { get; set; }
        [DisplayName("總金額")]
        public int? TTotal { get; set; }
    }
}

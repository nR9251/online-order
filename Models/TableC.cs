using System;
using System.Collections.Generic;
using System.ComponentModel;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prjonlineorder.Models
{
    public partial class TableC
    {
        public int TNumber { get; set; }
        [DisplayName("餐點")]
        public string TMeal { get; set; }
        [DisplayName("價格")]
        public int? TPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BookDotNetCore.Entity
{
    public class CustomerDetails
    {
        public int CstomerId { get; set; }
        public string CstomerName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Adderss { get; set; }
        public int Mobile { get; set; }
    }
}

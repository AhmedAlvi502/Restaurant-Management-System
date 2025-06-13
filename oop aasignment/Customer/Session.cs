using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedapmakanCustomer
{
    public static class Session
    {
        public static int UserId { get; set; }
        public static decimal WalletBalance { get; set; } = 0.00m;
        public static string CustomerName { get; set; }
        public static string CustomerEmail { get; set; }
        public static string UserPassword { get; set; }  // ✅ New
    }

}

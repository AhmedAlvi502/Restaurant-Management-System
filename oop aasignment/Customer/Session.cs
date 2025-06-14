using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedapmakanCustomer
{
    public static class Session // A static class that stores session-level information // for the currently logged-in customer.
    {
        public static int UserId { get; set; } // Stores the unique ID of the currently logged-in user.
        public static decimal WalletBalance { get; set; } = 0.00m; // Stores the user's current wallet balance. // This is updated during top-up or deduction operations.
        public static string CustomerName { get; set; } // Typically loaded at login or profile fetch.
        public static string CustomerEmail { get; set; } // Email address of the customer.
        public static string UserPassword { get; set; }  // // Password of the customer.
    }

}

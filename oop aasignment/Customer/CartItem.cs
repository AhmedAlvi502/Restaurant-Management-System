using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedapmakanCustomer // Represents a single item in the shopping cart // Used during order placement and display.
{
    public class CartItem
    {
        public int MenuId { get; set; } // Unique identifier for the menu item.
        public string ItemName { get; set; } // Name of the food or drink item.
        public string Category { get; set; } // The category of the item (e.g., Main Dish, Beverage, Dessert).
        public decimal Price { get; set; } // Price of the item in RM.
    }


}

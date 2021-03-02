using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{ 
        class Program
        {
            public static void OrderDetails(string SellerName, string ProductName, int OrderQuantity = 1, bool IsReturnable = true)
            {
                Console.WriteLine("Here is the order details- {0} number of {1} by {2} is ordered.It's returnable status is {3}", OrderQuantity, ProductName, SellerName, IsReturnable);
            }
            static void Main(string[] args)
            {
                OrderDetails("Amazon Seller", "Mobile phone");
                OrderDetails("Flipkart", "T-shirts", 2, false);
                Console.Read();
            }
        }
    }


using Day35_LambdaExpress_LinQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day35_LambdaExpress_LinQ
{
    public class Management
    {
        //UC2:-Retrieve top 3 records from the list who’s rating is high using Lambda 
        public void TopRecord(List<ProductReview> products)
        {

            var result = products.OrderByDescending(x => x.Rating).Take(3);
            Console.WriteLine("Using lambda Expression");
            Console.WriteLine("-------------------------------");
            foreach (var prod in result)
            {
                Console.WriteLine(prod.ProductID + "  " + prod.UserID + "  " + prod.Rating + "  " + prod.Review + "  " + prod.IsLike);

            }
            Console.WriteLine("----------------------------------------------------------------------------");
            //UC2:- Retrieve top 3 records from the list whos rating is high using LINQ
            var record = (from product in products orderby product.Review descending select product).Take(3);
            Console.WriteLine("Using LinQ");
            Console.WriteLine("-------------------------------");
            foreach (var prod in record)
            {
                Console.WriteLine(prod.ProductID + "  " + prod.UserID + "  " + prod.Rating + "  " + prod.Review + "  " + prod.IsLike);

            }
        }
        //UC3:-Product Review Management - Retrieve all record from the list who’s rating are greater then 3and productID is 1 or 4 or 9 using lambda Expression
        public void ProductRating(List<ProductReview> products)
        {
            var result = products.Where(x => x.Rating > 3 && (x.ProductID == 1 || x.ProductID == 4 || x.ProductID == 9));
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Using Lambda");
            Console.WriteLine("---------------------------------------------------");

            // Display(result);
            foreach (var prod in result)
            {
                Console.WriteLine(prod.ProductID + "  " + prod.UserID + "  " + prod.Rating + "  " + prod.Review + "  " + prod.IsLike);

            }
            Console.WriteLine("---------------------------------------------------------");

            //UC3:-Product Review Management - Retrieve all record from the list who’s rating are greater then 3and productID is 1 or 4 or 9 using LINQ Query

            Console.WriteLine("Using LINQ");
            Console.WriteLine("-----------------------------------------------");
            //LINQ Query
            var record = from product in products where (product.ProductID == 1 || product.ProductID == 4 || product.ProductID == 9) && product.Rating > 3 select product;
            // Display(result);
            foreach (var prod in record)
            {
                Console.WriteLine(prod.ProductID + "  " + prod.UserID + "  " + prod.Rating + "  " + prod.Review + "  " + prod.IsLike);

            }
        }
        //Display method.
            public void Display(IEnumerable<ProductReview> result)
            {
            foreach (var prod in result)
            {
                Console.WriteLine(prod.ProductID + "  " + prod.UserID + "  " + prod.Rating + "  " + prod.Review + "  " + prod.IsLike);

            }

        }
    }
}

       

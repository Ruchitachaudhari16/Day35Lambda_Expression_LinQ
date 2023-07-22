using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}

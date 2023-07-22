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
            Console.WriteLine("Using lambda");
            Console.WriteLine("-------------------------------");
            foreach (var prod in result)
            {
                Console.WriteLine(prod.ProductID + "  " + prod.UserID + "  " + prod.Rating + "  " + prod.Review + "  " + prod.IsLike);

            }
        }
    }
}

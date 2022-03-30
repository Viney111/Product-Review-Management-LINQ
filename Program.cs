using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Review_Management_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductReviewManager manager = new ProductReviewManager();
            List<ProductReview> productReviewFilledList = new List<ProductReview>();
            productReviewFilledList = manager.AddingValuesInProductReviewList(productReviewFilledList);
            foreach(ProductReview productReview in productReviewFilledList)
            {
                Console.WriteLine(productReview.ToString());
            }
        }
    }
}

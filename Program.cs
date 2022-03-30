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
            Console.WriteLine("Enter 1 to Write all Product Review Values in Console\nEnter 2 to retrieve top 3 Records as per rating");
            int UC = Convert.ToInt32(Console.ReadLine());
            productReviewFilledList = manager.AddingValuesInProductReviewList(productReviewFilledList);
            switch (UC)
            {
                case 1:
                    PrintListToConsole(productReviewFilledList);
                break;
                case 2:
                    var result = productReviewFilledList.OrderByDescending(x => x.rating).Take(3).ToList();
                    PrintListToConsole(result);
                break;
            }
        }
        public static void PrintListToConsole(List <ProductReview> printedList)
        {
            foreach(ProductReview productReview in printedList)
            {
                Console.WriteLine(productReview.ToString());
            }
        }
    }
}

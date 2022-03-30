using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management_LINQ
{
    internal class ProductReview
    {
        public int productID { get; set; }
        public int userID { get; set; }
        public double rating { get; set; }
        public string review { get; set; }
        public bool isLike { get; set; }

        public override string ToString()
        {
            return $"Product ID : {productID} , User ID : {userID} , Rating : {rating} , Review : {review}  , IsLike : {isLike}";
        }
    }
}

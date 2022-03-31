using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management_LINQ
{
    internal class ProductReviewManager
    {
        public List<ProductReview> AddingValuesInProductReviewList(List<ProductReview> productReviewList)
        {
            productReviewList.Add(new ProductReview() { productID = 1,userID = 1,rating = 5, review = "Very Good",isLike = true});
            productReviewList.Add(new ProductReview() { productID = 2, userID = 2, rating = 4, review = "Good", isLike = true });
            productReviewList.Add(new ProductReview() { productID = 3, userID = 3, rating = 3, review = "Average", isLike = true });
            productReviewList.Add(new ProductReview() { productID = 3, userID = 4, rating = 2, review = "Bad", isLike = false });
            productReviewList.Add(new ProductReview() { productID = 3, userID = 5, rating = 1, review = "Very Bad", isLike = false });
            productReviewList.Add(new ProductReview() { productID = 4, userID = 6, rating = 4, review = "Good", isLike = true });
            productReviewList.Add(new ProductReview() { productID = 5, userID = 7, rating = 5, review = "Very Good", isLike = true });
            productReviewList.Add(new ProductReview() { productID = 6, userID = 8, rating = 3, review = "Average", isLike = true });
            productReviewList.Add(new ProductReview() { productID = 7, userID = 7, rating = 1, review = "Very Bad", isLike = false });
            productReviewList.Add(new ProductReview() { productID = 8, userID = 8, rating = 5, review = "Very Good", isLike = true });
            productReviewList.Add(new ProductReview() { productID = 9, userID = 5, rating = 2, review = "Bad", isLike = false });
            productReviewList.Add(new ProductReview() { productID = 10, userID = 9, rating = 3, review = "Average", isLike = false });
            productReviewList.Add(new ProductReview() { productID = 1, userID = 3, rating = 4, review = "Good", isLike = true });
            productReviewList.Add(new ProductReview() { productID = 3, userID = 2, rating = 3, review = "Average", isLike = true });
            productReviewList.Add(new ProductReview() { productID = 7, userID = 1, rating = 2, review = "Bad", isLike = false });
            productReviewList.Add(new ProductReview() { productID = 9, userID = 2, rating = 3, review = "Average", isLike = false });
            productReviewList.Add(new ProductReview() { productID = 5, userID = 9, rating = 4, review = "Good", isLike = true });
            productReviewList.Add(new ProductReview() { productID = 7, userID = 10, rating = 3, review = "Average", isLike = false });
            productReviewList.Add(new ProductReview() { productID = 8, userID = 3, rating = 4, review = "Good", isLike = true });
            productReviewList.Add(new ProductReview() { productID = 7, userID = 8, rating = 1, review = "Very Bad", isLike = false });
            productReviewList.Add(new ProductReview() { productID = 4, userID = 10, rating = 4, review = "Good", isLike = true });
            productReviewList.Add(new ProductReview() { productID = 6, userID = 9, rating = 2, review = "Bad", isLike = false });
            productReviewList.Add(new ProductReview() { productID = 2, userID = 7, rating = 5, review = "Very Good", isLike = true });
            productReviewList.Add(new ProductReview() { productID = 6, userID = 9, rating = 1, review = "Very Bad", isLike = false });
            productReviewList.Add(new ProductReview() { productID = 4, userID = 2, rating = 5, review = "Very Good", isLike = true });
            return productReviewList;
        }
        public static DataTable AddingDefaultValueswithDataTable(List<ProductReview> productReviews)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("productID",typeof(int));
            dataTable.Columns.Add("userID",typeof (int));
            dataTable.Columns.Add("rating",typeof (double));
            dataTable.Columns.Add("review");
            dataTable.Columns.Add("isLike",typeof(bool));
            foreach(ProductReview productReview in productReviews)
            {
                dataTable.Rows.Add(productReview.productID,productReview.userID,productReview.rating,productReview.review,productReview.isLike);
            }
            return dataTable;
        }
    }
}

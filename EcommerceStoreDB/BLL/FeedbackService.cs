// FeedbackService.cs
using EcommerceStoreDB.DAL;
using System;

namespace EcommerceStoreDB.BLL
{
    public class FeedbackService
    {
        private readonly FeedbackRepository feedbackRepository;
        private readonly UserRepository userRepository;
        private readonly ProductRepository productRepository;

        public FeedbackService()
        {
            feedbackRepository = new FeedbackRepository();
            userRepository = new UserRepository();
            productRepository = new ProductRepository();
        }

        public bool SubmitFeedback(string username, string productName, string rating, string comments)
        {
            int userId = userRepository.GetUserId(username);
            if (userId == -1) return false;

            int productId = productRepository.GetProductId(productName);
            if (productId == -1) return false;

            int ratingValue = int.Parse(rating);
            return feedbackRepository.SaveFeedback(userId, productId, ratingValue, comments, productName);
        }
    }
}

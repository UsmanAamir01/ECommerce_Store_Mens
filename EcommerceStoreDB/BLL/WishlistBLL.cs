using System.Collections.Generic;

namespace EcommerceStoreDB.DAL
{
    public class WishlistBLL
    {
        private readonly WishlistDAL wishlistDAL;

        public WishlistBLL()
        {
            wishlistDAL = new WishlistDAL();
        }

        public List<WishlistItem> GetWishlist(string username, string role)
        {
            int userId = wishlistDAL.GetUserId(username, role);
            if (userId == -1)
                return new List<WishlistItem>();

            return wishlistDAL.FetchWishlistItems(userId);
        }

        public bool RemoveItem(string wishlistId)
        {
            return wishlistDAL.DeleteWishlistItem(wishlistId);
        }

        public bool MoveToCart(string username, string role, string wishlistId, string productId, string productName)
        {
            int userId = wishlistDAL.GetUserId(username, role);
            if (userId == -1)
                return false;

            bool addedToCart = wishlistDAL.AddToCart(userId, productId, productName);
            if (!addedToCart)
                return false;

            return wishlistDAL.DeleteWishlistItem(wishlistId);
        }
    }
}

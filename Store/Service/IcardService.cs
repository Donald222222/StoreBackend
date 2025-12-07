namespace Store.Service
{
  
        public interface ICartService
        {
            IEnumerable<CartItem> GetCart();
            void AddToCart(CartItem item);
            void UpdateCart(CartItem item);
        }

    
}

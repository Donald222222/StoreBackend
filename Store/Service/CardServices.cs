namespace Store.Service
{
   
        public class CartService : ICartService
        {
            private readonly List<CartItem> _cart = new();

            public IEnumerable<CartItem> GetCart() => _cart;

            public void AddToCart(CartItem item)
            {
          
                var existing = _cart.FirstOrDefault(c => c.ProductId == item.ProductId);
                if (existing != null)
                {
                    existing.Quantity += item.Quantity;
                }
                else
                {
                    _cart.Add(item);
                }
            }

            public void UpdateCart(CartItem item)
            {
                var existing = _cart.FirstOrDefault(c => c.ProductId == item.ProductId);
                if (existing != null)
                {
                    existing.Quantity = item.Quantity;
                }
            }
        }

    
}

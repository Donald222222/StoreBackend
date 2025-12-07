namespace Store.Entiies
{
    public class Order
    {
       
            public int Id { get; set; } 
            public int CustomerId { get; set; }
            public List<Guid> ProductIds { get; set; } = new();
            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        }

  
}

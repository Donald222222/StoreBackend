using System.ComponentModel.DataAnnotations;

namespace Store.Entiies
{
    


        public class Product
        {
            public int Id { get; set; } 
            [Required]
            public string Name { get; set; }
            [Range(0.01, 10000)]
            public decimal Price { get; set; }
            public int Stock { get; set; }
            public string Description { get; set; } = "";
           public string Model { get; set; } = "";
    }

    
}

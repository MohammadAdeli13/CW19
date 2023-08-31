namespace Store.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string? Title { get; set; }

        public double Price { get; set; }

        public string? Photo { get; set; }

        public string? Description { get; set; }

        //navigation:
        //each product own many orders

        public List<Order> Orders { get; set; }
    }
}

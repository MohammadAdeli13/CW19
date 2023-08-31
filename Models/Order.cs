namespace Store.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int Count { get; set; }

        //navigation:
        //each order own 1 cart and has 1 product

        public int CartId { get; set; }

        public Cart Cart { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}

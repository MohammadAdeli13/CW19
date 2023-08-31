namespace Store.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FullName { get; set; }

        public string? NationalCode { get; set; }

        //navigation :
        //each customer has 1 cart

        public int CartId { get; set; }

        public Cart Cart { get; set; }

    }
}

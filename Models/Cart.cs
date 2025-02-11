namespace dotnetShop.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int? UserID { get; set; }
        public int ProductID { get; set; }
        public int ItemQuantity { get; set; }

        public Cart()
        {

        }

        public Cart(int productId)
        {
            Id = 0;
            ProductID = productId;
            ItemQuantity = 1;
        }
    }
}

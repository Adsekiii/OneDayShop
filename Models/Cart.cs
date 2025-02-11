namespace dotnetShop.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        
        public Cart()
        {
            
        }
    }
}

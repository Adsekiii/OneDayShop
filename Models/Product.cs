namespace dotnetShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }


        public Product()
        {
            
        }
        public Product(int id, string name, int amount, float price)
        {
            Id = id;
            Name = name;
            Amount = amount;
            Price = price;
        }
    }
}

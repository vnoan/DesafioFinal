namespace DesafioFinal.Models
{
    public class Order : BaseModel
    {
        public int ClientId { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal TotalAmount => Products.Sum(p => p.Price);
    }
}

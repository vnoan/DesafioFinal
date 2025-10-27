namespace DesafioFinal.Models
{
    public class Order : BaseModel
    {
        public int ClientId { get; set; }
        public Status Status { get; set; } = Status.Pending;
        public DateTime Date { get; set; } = DateTime.Now;
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public virtual List<Product> Products { get; set; } = new List<Product>();
        public decimal TotalAmount => Products.Sum(p => p.Price);
    }

    public enum Status
    {
        Pending,
        Completed,
        Canceled
    }
}

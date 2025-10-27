namespace DesafioFinal.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; internal set; }
    }
}

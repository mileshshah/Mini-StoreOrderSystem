namespace Mini_StoreOrderSystem.Services.DTO
{
    public class ProductDto
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }
    }
}
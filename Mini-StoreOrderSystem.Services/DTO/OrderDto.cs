namespace Mini_StoreOrderSystem.Services.DTO
{
    public class OrderDto
    {
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
namespace Mini_StoreOrderSystem.Data.Entities
{
    public class Order
    {
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }
    }
}




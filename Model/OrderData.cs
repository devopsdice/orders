namespace Order.Model
{
    public class OrderData
    {
        public OrderData()
        {
            Status = "Created";
        }
        public int OrderId { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
    }
}

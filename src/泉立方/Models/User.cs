namespace 泉立方.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ItemName { get; set; }
        public int QtyBox { get; set; }
        public decimal TotalPrice { get; set; }
        public string Address { get; set; }

        public decimal PostFee { get; set; }
        public decimal ActCost { get; set; }
    }
}


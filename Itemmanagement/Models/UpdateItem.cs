namespace Itemmanagement.Models
{
    public class UpdateItem
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Delivery { get; set; }
        public int price { get; set; }
    }
}

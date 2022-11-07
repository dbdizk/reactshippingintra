namespace Domain
{
    public class Shipment
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string FromWhere { get; set; }
        public string ToWhere { get; set; }
        public int Weight { get; set; }
        public int Distance { get; set; }
    }
}
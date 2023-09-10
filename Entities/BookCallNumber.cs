namespace BookInventory.Entities
{
    public class BookCallNumber
    {
        public int Id { get; set; }
        public int CallNumber { get; set; }
        public string ISBN { get; set; }
        public int BookId { get; set; }
        public bool isAvailable { get; set; }
    }
}

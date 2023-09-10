namespace BookInventory.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public int RequestorId { get; set; }
       
        public int BookId { get; set; }
        public string RequestorFirstName { get; set; }
        public string RequestorLastName { get; set; }
        public string RequestorEmail { get; set; }
        public int? ApproverId { get; set; }
        
    }
}

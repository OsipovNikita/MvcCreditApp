namespace MvcCreditApp.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public ICollection<Bid> Bids { get; set; }
    }
}

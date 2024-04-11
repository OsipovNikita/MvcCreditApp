namespace MvcCreditApp.Models
{
    public class Bid
    {
        // ID заявки
        public virtual int BidId { get; set; }
        public virtual Credit Credit { get; set; }
        public virtual Client Client { get; set; }
        
        // Дата подачи заявки
        public virtual DateTime bidDate { get; set; }
        public virtual int CreditId { get; set; }
        public virtual int ClientId { get; set; }
    }
}

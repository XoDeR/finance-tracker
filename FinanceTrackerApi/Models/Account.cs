using System.ComponentModel.DataAnnotations;

namespace FinanceTrackerApi.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; // "Checking", "Savings"
        public decimal Balance { get; set; }
        public User? User { get; set; }
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
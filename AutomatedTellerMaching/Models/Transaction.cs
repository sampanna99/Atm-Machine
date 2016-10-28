using System.ComponentModel.DataAnnotations;

namespace AutomatedTellerMaching.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int Amount { get; set; }

        public virtual CheckingAccount CheckingAccount { get; set; }

        [Required]
        public int CheckingAccountId { get; set; }
    }
}
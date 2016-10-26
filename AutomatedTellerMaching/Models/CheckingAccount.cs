using System.ComponentModel.DataAnnotations;

namespace AutomatedTellerMaching.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Display(Name = "Account #")]
        public string AccountNumber { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        [DataType(DataType.Currency)]
        public int Balance { get; set; }

    }
}
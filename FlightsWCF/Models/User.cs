using System.ComponentModel.DataAnnotations.Schema;

namespace FlightsWCF.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Phone { get; set; }
    }
}

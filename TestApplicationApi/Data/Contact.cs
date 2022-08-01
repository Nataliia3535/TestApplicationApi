using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApplicationApi.Data
{
    [Table("Contact")]
    public class Contact
    {
        [Key, Required]
        public string email { get; set; }

        
        public string contact_firstname { get; set; }

        
        public string contact_lastname { get; set; }

    }
}

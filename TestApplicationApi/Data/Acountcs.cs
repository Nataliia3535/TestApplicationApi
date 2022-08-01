using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApplicationApi.Data
{
    [Table("Acounts")]
    public class Acountcs
    {
        
        [Key, Required]
        
        public string accountName { get; set; }
       
       
        public virtual Contact Contact { get; set; }
    }
}

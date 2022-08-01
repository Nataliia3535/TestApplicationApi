using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApplicationApi.Data
{
    [Table("Incident")]
    public class Incident
    {
       
        [Key,Required]
        public string incident_name { get; set; }

       
        public string incident_description { get; set; }

        
        
        public virtual Acountcs Acount { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace MISTeamProjectAPI.Entities
{
    public partial class Disaster {

        [Key]
        [Display(Name = "City ID")]
        public int CID { get; set; }
        
     public string NDType { get; set; }

    public DateOnly NDDate { get; set; }
        

    }
}

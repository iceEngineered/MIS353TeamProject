using System.ComponentModel.DataAnnotations;

namespace MISTeamProjectAPI.Entities
{
    public partial class Disaster {

        
     public int CID { get; set; }
        
     public string NDType { get; set; }

    public DateOnly NDDate { get; set; }
        

    }
}

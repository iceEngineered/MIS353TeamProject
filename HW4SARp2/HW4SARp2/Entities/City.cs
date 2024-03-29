using System.ComponentModel.DataAnnotations;



namespace HW4SARp2.Entities
{
    public class City
    {
            public int CID { get; set; }
        [Required]
            public string CName { get; set; }
        [Required]
        public string CState { get; set; } 
       
    }
}

using System.ComponentModel.DataAnnotations;
namespace PuccioAPIs.Entities
{
    public class Forecast
    {
        public int CID { get; set; }
        [Required]
        public int FCTemp { get; set; }
        
        public int ATemp { get; set; }

    }
}

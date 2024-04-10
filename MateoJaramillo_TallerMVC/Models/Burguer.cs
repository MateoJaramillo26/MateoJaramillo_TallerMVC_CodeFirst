using System.ComponentModel.DataAnnotations;

namespace MateoJaramillo_TallerMVC.Models
{
    public class Burguer
    { 
        public int Id { get; set; }

        [Required]
        public String? Name { get; set; }
        public bool? IsBurguer { get; set; }

        [Range(0.01, 99999.99)]
        public decimal? BurguerPrice { get;set; }   
    }

}

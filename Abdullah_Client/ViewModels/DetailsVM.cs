using Abdullah_Models;
using System.ComponentModel.DataAnnotations;

namespace Abdullah_Client.ViewModels
{
    public class DetailsVM
    {
        public DetailsVM()
        {
            ProductPrice = new();
            count = 1;
        }

        [Range(1,int.MaxValue,ErrorMessage ="Please enter a value greater than 0")]
        public int count { get; set; }
        [Required]
        public int SelectedProductPriceId { get; set; } 
        
        public ProductPriceDTO ProductPrice { get; set; }  
    }
}

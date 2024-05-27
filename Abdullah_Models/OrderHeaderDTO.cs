using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdullah_Models
{
    public class OrderHeaderDTO
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [Display(Name ="Order Total")]
        public double OrderTotal { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        [Display(Name ="Shipping Date")]
        public DateTime ShippingDate { get; set; }
        [Required]
        public string Status { get; set; }  

        //stripe payment
        public string? SessionId { get; set; }
        public string? PaymentIntentId { get; set; }

        [Required]
        [Display(Name="Name")]

        public string Name { get; set; }

        [Required]
        [Display(Name ="PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name ="Street Address")]
        public string Address { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        [Display(Name ="Postal Code")]
        public string PostalCode { get; set; }

    public string Email { get; set; }
    }
}

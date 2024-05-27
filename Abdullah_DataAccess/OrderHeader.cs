using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangy_DataAccess
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }
        // add nagivation property : #TODO

        [Required]
        public double OrderTotal { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime ShippingDate { get; set; }
        [Required]
        public string Status { get; set; }  

        //stripe payment
        public string? SessionId { get; set; }
        public string? PaymentIntentId { get; set; }

        [Required]

        public string Name { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string Email { get; set; }
    }
}

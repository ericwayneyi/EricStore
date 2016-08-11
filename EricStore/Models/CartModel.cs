using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EricStore.Models
{
    public class CartModel
    {
        public Product[] Products { get; set; }

        [Required]
        [CreditCard]
        public int CreditCardNumber { get; set; }

        [Required]
        public int CVV { get; set; }

        [Required]
        [Range(1,12)]
        public int ExpirationMonth { get; set; }

        [Required]
        [Range(2016,2099)]
        public int ExpirationYear { get; set; }

        [Required]
        public string BillingFirstName { get; set; }
        [Required]
        public string BillingLastName { get; set; }
        [Required]
        public string Address { get; set; }

        
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string ZipCode { get; set; }
    }
}
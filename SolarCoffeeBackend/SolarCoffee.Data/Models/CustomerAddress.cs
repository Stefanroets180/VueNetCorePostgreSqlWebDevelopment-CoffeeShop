using System;
using System.ComponentModel.DataAnnotations;

namespace SolarCoffee.Data.Models {
    public class CustomerAddress {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdateOn { get; set; }
        
        [MaxLength(100)]
        public string AddressLine1 { get; set; }
        
        [MaxLength(100)]
        public string AddressLine2 { get; set; }
        
        [MaxLength(100)]
        public string City { get; set; }
        
        [MaxLength(20)]
        public string Province { get; set; }
        
        [MaxLength(10)]
        public string PostalCode { get; set; }
        
        [MaxLength(50)]
        public string Country { get; set; }
        
    }
}
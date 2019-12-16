using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModel
{
    [Table("Customer")]
    public class Customer
    {
        #region Attributs 

        private int customerId;
        private string fulName;
        
        private string dateOfBirth;
       
        #endregion

        #region propriété
        public int CustomerId { get => customerId; set => customerId = value; }
        
        [StringLength(250)]
        [Required]
        public string Fulname { get => fulName; set => fulName = value; }
       
        [Range(typeof(DateTime), "01/01/1900", "31/12/2020")]
        [Required]
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        public virtual Address Address { get; set; }
        public ICollection<Booking> Booking { get; set; }

        #endregion

    }
}

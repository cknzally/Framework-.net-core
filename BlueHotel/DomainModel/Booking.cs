using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModel
{
    [Table("booking")]
    public class Booking
    {
        #region Attributs
        private int bookingId;
        private DateTime created;
        private DateTime chekIn;
        private DateTime checkOut;
        private bool isPaid;
        private decimal price;

 
        #endregion

        #region propriétés

        public int BookingId { get => bookingId; set => bookingId = value; }
       
        [Range (typeof(DateTime), "01/01/1900", "01/01/3000")]
        [Required]
        public DateTime Created { get => created; set => created = value; }

        [Range(typeof(DateTime), "01/01/1900", "01/01/3000")]
        [Required]
        public DateTime ChekIn { get => chekIn; set => chekIn = value; }

        [Range(typeof(DateTime), "01/01/1900", "01/01/3000")]
        [Required]
        public DateTime CheckOut { get => checkOut; set => checkOut = value; }
       
        [Required]
        public bool IsPaid { get => isPaid; set => isPaid = value; }

       [Required]
       [Range(0.0f,double.MaxValue)]
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<BookingRoom> BookingRooms { get; set; }
        #endregion

    }
}

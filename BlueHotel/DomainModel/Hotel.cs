using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel
{
   [Table("Hotel")]
    public class Hotel
    {

        #region Attributs 

        private int hotelId;
        private int name;
        private int star;
        
        #endregion


        #region propriétés

        public int HotelId
		{
			get { return hotelId; }
			set { hotelId = value; }
		}
        [StringLength(30)]
        [Required]
        public int Name
        {
            get { return name; }
            set { name = value; }
        }

        [Required]
        public int Star
        {
            get { return star; }
            set { star = value; }
        }


        public virtual Address address { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        #endregion
    }
}

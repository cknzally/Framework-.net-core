using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModel
{
    [Table("Room")]
    public class Room
    {
        #region Attribut
        private int roomId;
		private string name;
		private int floor;
		private int category;
		
        #endregion

        #region Propriétés
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId { get => roomId; set => roomId = value; }
        
        [StringLength(30)]
        [Required]
		public string Name { get => name; set => name = value; }
		
        [Range(0,200)]
        public int Floor { get => floor; set => floor = value; }
		
        [StringLength(50)]
        public int Category { get => category; set => category = value; }

        public virtual Hotel Hotel { get; set; }
        public virtual ICollection<BookingRoom> BookingRooms { get; set; }

        #endregion
    }
}

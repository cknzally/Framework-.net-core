using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModel
{
    [Table("Adress")]
    public class Address
    {
        #region Attributs 

        private int adressId;
        private string street;
        private string zipcod;
        private string city;
        private string contry;
        private double latitude;
        private double longitude;
        private string phone;
        private string email;

       


        #endregion


        #region propriétés

        public int AdressId
        {
            get { return adressId; }
            set { adressId = value; }
        }

        [StringLength (55)]
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        [StringLength(10)]
        public string Zipcod
        {
            get { return zipcod; }
            set { zipcod = value; }
        }

        [StringLength(50)]
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        [StringLength(55)]
        public string Contry
        {
            get { return contry; }
            set { contry = value; }
        }

        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }


        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        [StringLength(14)]
        [Required]
        [RegularExpression(@"\+(9[976]\d|8[987530]\d|6[987]\d|5[90]\d|42\d|3[875]\d|2[98654321]\d|9[8543210]|8[6421]|6[6543210]|5[87654321]|4[987654310]|3[9643210]|2[70]|7|1)\d{1,14}$")]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        [StringLength(50)]
        [Required]
        [RegularExpression(@"^\w + ([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Hotel Hotel { get; set; }
        public Customer Customer { get; set; }
        #endregion
    }
}

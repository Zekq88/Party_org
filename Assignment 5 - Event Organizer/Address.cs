using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5___Event_Organizer
{
    internal class Address
    {

        // Variables.
        private string city;
        private string street;
        private string zipCode;

        // Instance variable.
        private Countries country;


        #region Properties

        /// <summary>
        /// Propeties for city.
        /// </summary>
        public string City
        {
            get { return city; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    city = value;
                }
            }
        }

        /// <summary>
        /// Propeties for street.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Propeties for zipCode.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Propeties for instance variable object.
        /// </summary>
        public Countries Country { get; set; }
        #endregion


        #region Constructors

        /// <summary>
        /// Default constructor with empty variables.
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// Chain constructor with four parameters:street, zipCode, city, countries object.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zipCode"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        public Address(string street, string zipCode, string city, Countries country)
        {
            this.street = street;
            this.zipCode = zipCode;
            this.city = city;
            this.country = country;
        }

        /// <summary>
        /// Constructor with three parameters: street, zipCode, city and calling the constructor with 4 parameters.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zipCode"></param>
        /// <param name="city"></param>
        public Address(string street, string zipCode, string city) :
            this(street,zipCode,city, Countries.Sverige)
        { 
        }
        
        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="other"></param>
        public Address(Address other)
        {
            this.city = other.City;
            this.street = other.Street;
            this.zipCode = other.ZipCode;
            this.country = other.country;
        }

        #endregion


        #region Methods

        /// <summary>
        /// This method returns a formated string of the address.
        /// </summary>
        /// <returns></returns>
        public string GetAddressLabel()
        {
            return $"{street} \n {zipCode} {city}";
        }

        /// <summary>
        /// This method returns the countrys name and replace under scores with a space instead.
        /// </summary>
        /// <returns></returns>
        public string GetCountryString() 
        {
            return country.ToString().Replace("_", " ");
        }

        /// <summary>
        /// This overridded method returns a formated string with a specific setup.
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
        
            return string.Format("{0, -28} {1, -9} {2, -15} {3}", Street, ZipCode, City, Country);
        }

        /// <summary>
        /// This method validates with a boolean if the address is either null or empty.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool validation = false;

            if (!string.IsNullOrEmpty(city))
            {
                validation = true;
            }
            return validation;
        }
        #endregion
    }
}

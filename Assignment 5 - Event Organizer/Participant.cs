using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5___Event_Organizer
{
    internal class Participant
    {
        // Variables.
        private string firstName;
        private string lastName;

        // Instance variable.
        private Address address;


        #region Propities

        /// <summary>
        /// Propeties for instance variable object.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Propities for firstName.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Propities for lastName with toUpper() on the set value.
        /// </summary>
        public string LastName { get { return lastName; } set { lastName = value.ToUpper(); } }
        #endregion


        #region Constructors

        /// <summary>
        /// Constructor thats instancite instance variable.
        /// </summary>
        public Participant() 
        {
            address = new Address();
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public Participant(Participant other)
        {
            firstName = other.FirstName;
            lastName = other.LastName;
            this.address = new Address(other.address);
        } 

        
         /// <summary>
         /// Constructor that take 3 paramters: firstName, lastName and Address object. if the Address object is null or empty,
         /// it will create a Address object.
         /// </summary>
        public Participant(string firstName, string lastName, Address address)
        {
            if(!string.IsNullOrEmpty(address.ToString())){
                Address = address;
            } else
            {
                address = new Address() ;
            }

                FirstName = firstName;
                LastName = lastName;   
            
        }
        #endregion



        /// <summary>
        /// This overridded method returns a formatted string. 
        /// </summary>
        /// <returns> $"{LastName}, {FirstName,-20}  {Address}" </returns>
        public override string ToString()
        {
            return $"{LastName}, {FirstName,-20}  {Address}";
        }

    }
}

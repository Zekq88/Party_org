using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5___Event_Organizer
{
    internal class ParticipantManager
    {
        // Variable.
        private int count;

        // Instance List variable.
        public List<Participant> participants;

        /// <summary>
        /// Property for Count.
        /// </summary>
        public int Count { get { return count; } }

        /// <summary>
        /// Constructor thats instancite instance variable.
        /// </summary>
        public ParticipantManager()
        {
            participants = new List<Participant>();
        }

        #region Methods
        /// <summary>
        /// Method for adding a participant to the list using the parameter Participant object. 
        /// </summary>
        /// <param name="ParticipantIn"></param>
        /// <returns>boolean</returns>
        public bool AddParticipant(Participant ParticipantIn)
        {
            if(ParticipantIn == null)  
                return false; 
                
            participants.Add(ParticipantIn);
            count++;
            return true;
        }

        /// <summary>
        /// Method for adding a participant to the list using the parameters firstName, lastName and Address object. 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <returns>boolean</returns>
        public bool AddParticipant(string firstName, string lastName, Address address)
        {
            Participant irma = new Participant(firstName, lastName, address);

            
                participants.Add(irma);
                count++;
                return true;
 
        }

        /// <summary>
        /// This method edit the participants info and replace it using the index parameter and Participant object.
        /// </summary>
        /// <param name="ParticipantIn"></param>
        /// <param name="index"></param>
        /// <returns>boolean</returns>
        public bool ChanngeParticipantAt(Participant ParticipantIn, int index)
        {

            if ((index < 0 || index >= Count) && ParticipantIn == null)
            {
                return false;
            }

           participants[index] = ParticipantIn;
                return true;
        }

        /// <summary>
        /// This method deletes the participent using index parameter.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>boolean</returns>
        public bool DeleteParticipantAt(int index)
        {
            if (index < 0 || index >= participants.Count())
            {
                return false;
            }

            participants.RemoveAt(index);
            count--;
            return true;
        }

        /// <summary>
        /// This method is a get method for a specific participent using index parameter.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>participants[index]</returns>
        public Participant GetParticipantAt(int index)
        {
            if (index < 0 || index >= participants.Count())
            {
                return null;
            }
            return participants[index];
        }

        /// <summary>
        /// This method is a get method for all particiants and returns a string array.
        /// </summary>
        /// <returns>string[]</returns>
        public string[] GetParticipantInfo()
        {
            string[] partArray = new string[participants.Count()];

            int i = 0;
            foreach (Participant participant in participants)
            {
                partArray[i++] = participant.ToString();
            }
            return partArray;
        }
        #endregion
    }
}

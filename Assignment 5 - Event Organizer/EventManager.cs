using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5___Event_Organizer
{
    internal class EventManager
    {
        // Variables.
        private double costPerPerson = 0.0;
        private double feePerPerson = 0.0;
        private string title; 

        /// <summary>
        /// Instance variable.
        /// </summary>
        private ParticipantManager participantManager;


        #region Propeties

        /// <summary>
        /// Propeties for costPerPerson.
        /// </summary>
        public double CostPerPerson { get { return costPerPerson; } set
            {
                if (value >= 0.0) { costPerPerson = value; }
                
            }
        }

        /// <summary>
        /// Propeties for feePerPerson.
        /// </summary>
        public double FeePerPerson { get { return feePerPerson; } set {
                if (value >= 0.0) { feePerPerson = value;  }
                 } }

        /// <summary>
        /// Propeties for title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// This method returns the instance variable.
        /// </summary>
        public ParticipantManager ParticipantManager { get { return participantManager; } }

        #endregion

        /// <summary>
        /// Constructor thats instancite instance variable.
        /// </summary>
        public EventManager() 
        { 
            participantManager = new ParticipantManager();
        }


        #region Methods

        /// <summary>
        /// This method is returning the total fees for the event.
        /// </summary>
        /// <returns>double</returns>
        public double CalcTotalFees()
        {
            return feePerPerson * participantManager.Count;
        }

        /// <summary>
        /// This method is returning the total cost for the event.
        /// </summary>
        /// <returns>double</returns>
        public double CalcTotalCost()
        {
            return costPerPerson * participantManager.Count;
        }
        #endregion
    }
}

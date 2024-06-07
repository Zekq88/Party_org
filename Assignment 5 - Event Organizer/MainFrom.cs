using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment_5___Event_Organizer
{
    public partial class MainFrom : Form
    {
        // Variable.
        private bool notCreated = false;

        // Instance variable.
        private EventManager eventManager;


        /// <summary>
        /// Constructor that starts InitializeComponent() and AddCountries().
        /// </summary>
        public MainFrom()
        {
            InitializeComponent();
            AddCountries();
        }

        #region Create related methods


        /// <summary>
        /// This event method executes when the user clicks the Create button.
        /// It executes the methods ClearAllValues() and EventCreate().
        /// </summary>
        private void CreateBtn_Click(object sender, EventArgs e)
        {
                ClearAllValues();
                EventCreate();
        }

        /// <summary>
        /// This method take the user input and evauluate it using if-statements and informs the user of errors or if the event was created
        ///  using Messageboxes.
        /// </summary>
        private void EventCreate()
        {
            try
            {
                if (!string.IsNullOrEmpty(titleBox.Text.Trim()))
                {
                    eventManager = new EventManager();

                    eventManager.Title = titleBox.Text.Trim();
                    if (!string.IsNullOrEmpty(costPerPartBox.Text) && !string.IsNullOrEmpty(feePerPartBox.Text))
                    {
                        eventManager.CostPerPerson = double.Parse(costPerPartBox.Text.Replace(".", ","));
                        eventManager.FeePerPerson = double.Parse(feePerPartBox.Text.Replace(".", ","));
                    }
                    else
                    {
                        eventManager.CostPerPerson = eventManager.CostPerPerson;
                        eventManager.FeePerPerson = eventManager.FeePerPerson;
                    }
                    
                    notCreated = true;
                    MessageBox.Show("The Event was Created\nContinue by adding participents to the event", $"{eventManager.Title}");
                } else
                {
                    MessageBox.Show("The Event was not Created\nEvent title is manditory to continue", "Incomplete event data");
                }
            } catch (Exception ex) { MessageBox.Show(ex.Message + "\nYou've to type in text at event title and numbers at cost or fee", "Not correct data type"); }
        }

        /// <summary>
        /// This method takes all the countries from the enum and inserts it into the combo box while executing ClearAllValues().
        /// </summary>
        private void AddCountries()
        {
            CountryBox.Items.AddRange(Enum.GetNames(typeof(Countries)));
            CountryBox.SelectedIndex = (int)Countries.Sverige;

            ClearAllValues();
        }

        #endregion

        #region Add related methods


        /// <summary>
        /// This event method executes when the user clicks the Add button.
        /// If the boolean notCreated is true it will execute progress by adding a new participant object using the ReadInput() as a
        /// condition, if true then UpdateEventParticipants() and ClearValues() will be executed.
        /// </summary>
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (notCreated) { 
            Participant participant = new Participant();

            if (ReadInput(ref participant))
            {
                UpdateEventParticipants();
                ClearValues();
            }
        }
            else
            {
                MessageBox.Show("You most create the event before adding the participent to the event!", "Hold your horses");

            }
        }

        
        /// <summary>
        /// This method is used as an condition for evaluate if the address contains atleast a city variable
        /// while adding first and last name to the participent object
        /// </summary>
        /// <param name="participant"></param>
        /// <returns></returns>
        private bool GetParticipantInfo(ref Participant participant)
        {
            Address address = GetAddress();

            bool accepted = address.Validate();

            participant.FirstName = FirstNameBox.Text;
            participant.LastName = LastNameBox.Text;
            participant.Address = address;

            return accepted;
        }

        
        /// <summary>
        /// This method uses GetParticipantInfo() as a condition meanwhile evaluates user inputs before adding the participant to the list. 
        /// </summary>
        /// <param name="participant"></param>
        /// <returns>boolean</returns>
         
        private bool ReadInput(ref Participant participant)
        {
            bool cheack = GetParticipantInfo(ref participant);

            try
            {
                if (cheack && (!string.IsNullOrEmpty(FirstNameBox.Text) && !string.IsNullOrEmpty(LastNameBox.Text)))
                {
                    eventManager.ParticipantManager.AddParticipant(participant);
                }
                else
                {
                    MessageBox.Show("More Data is needed for registration\nFirst name, Last name and City are madatory data for registration",
                        "More Info about participent is needed");
                    return false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Try again"); }

            return cheack;

        }

        #endregion

        #region Change related methods


        /// <summary>
        /// This event method executes when the user clicks the Change button.
        /// It takes the selected participent as index and send the index with the new values to ChanngeParticipantAt() while updating the GUI.
        /// </summary>

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            int index = ResBox.SelectedIndex;

            if (index < 0)
            {
                return;
            } else
            {
                Participant participant = new Participant();

                Address address = GetAddress();

                bool accepted = address.Validate();

                if (accepted) {
                    participant.FirstName = FirstNameBox.Text;
                    participant.LastName = LastNameBox.Text;
                    participant.Address = address;

                    eventManager.ParticipantManager.ChanngeParticipantAt(participant, index);

                    UpdateEventParticipants();
                } else
                {
                    MessageBox.Show("More Data is needed for registration\nFirst name, Last name and City are madatory data for registration",
                        "More Info about participent is needed");
                }
            }
        }

        #endregion

        #region Delete related methods

        /// <summary>
        /// This event method executes when the user clicks the delete button.
        /// It takes the selected participent as index and deletes it using DeleteparticipantAt() while updating the GUI.
        /// </summary>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
           int index = ResBox.SelectedIndex;

            eventManager.ParticipantManager.DeleteParticipantAt(index);
            UpdateEventParticipants();
        }

        #endregion

        #region Multi-related methods

        /// <summary>
        /// This method getting data and updates amount of participants, both total costs and fees, and Surplus/Deficit to the GUI.
        /// </summary>
        private void UpdateEventEconomy()
    {
        ResBalanceBox.Text = ((double) eventManager.CalcTotalFees() - eventManager.CalcTotalCost()).ToString();
        ResTotalCostBox.Text = ((double) eventManager.CalcTotalCost()).ToString();
        ResTotalFeesBox.Text = ((double)eventManager.CalcTotalFees()).ToString();
        ResNumberBox.Text = (eventManager.ParticipantManager.Count).ToString();
    }

        /// <summary>
        /// This method clear out all the users input.
        /// </summary>
    private void ClearValues()
    {
        FirstNameBox.Text = string.Empty;
         LastNameBox.Text = string.Empty;
        StreetBox.Text = string.Empty;
        CityBox.Text = string.Empty;
        ZipCodeBox.Text = string.Empty;
        CountryBox.SelectedIndex = (int)Countries.Sverige;

    }

        /// <summary>
        /// This method inserts all the participants into the listbox and executes UpdateEventEconomy() and ClearValues().
        /// </summary>
        private void UpdateEventParticipants() 
    {
        string[] partArray = eventManager.ParticipantManager.GetParticipantInfo();

        if(partArray != null)
        {
            ResBox.Items.Clear();
            ResBox.Items.AddRange(partArray);
            UpdateEventEconomy();
            ClearValues();
        }
    }

        /// <summary>
        /// This method creates a Address object and gives it values using the users input from the GUI.
        /// </summary>
        /// <returns></returns>
        private Address GetAddress() 
        { 
            Address address = new Address();
            address.Street = StreetBox.Text;
            address.City = CityBox.Text;
            address.ZipCode = ZipCodeBox.Text;
            address.Country = (Countries) CountryBox.SelectedIndex;

            return address;
        }

        // This method clears out all the economical values and the listbox.
        private void ClearAllValues()
        {
            ResBox.Items.Clear();
            ResNumberBox.Text = string.Empty;
            ResTotalCostBox.Text = string.Empty;
            ResTotalFeesBox.Text = string.Empty;
            ResBalanceBox.Text = string.Empty;
        }

        #endregion


         /// <summary>
         /// This method puts the selected participants data back to the GUI for the user to watch, plays a part in edit participants data.
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void ResBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        int index = ResBox.SelectedIndex;

            if(index >= 0) {
                Participant participant = eventManager.ParticipantManager.GetParticipantAt(index);

                FirstNameBox.Text = participant.FirstName;
                LastNameBox.Text = participant.LastName;
                StreetBox.Text = participant.Address.Street;
                CityBox.Text = participant.Address.City;
                ZipCodeBox.Text = participant.Address.ZipCode;
                CountryBox.SelectedIndex = (int) participant.Address.Country;
            }
            else
            {
                MessageBox.Show("Please click on the participent before removing or editing the participent", "Lost focus");
            }

        }
    }
}

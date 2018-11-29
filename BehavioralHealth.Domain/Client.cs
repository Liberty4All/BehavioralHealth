using BehavioralHealth.SharedKernel.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralHealth.Domain
{
    public class Client : EntityBase<int>
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }
        public Gender Gender { get; }
        public Race Race { get; }
        public Ethnicity Ethnicity { get; }

        public Client(int id, string firstName, string lastName, DateTime dateOfBirth, Gender gender, Race race, Ethnicity ethnicity) : base(id)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentNullException("First Name", "Missing value");
            }
            FirstName = firstName;

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentNullException("Last Name", "Missing value");
            }
            LastName = lastName;

            if (dateOfBirth < DateTime.Now.Date.AddYears(-120))
            {
                throw new ArgumentOutOfRangeException("Date Of Birth", "More than 120 years ago");
            }
            DateOfBirth = dateOfBirth;

            Gender = gender;
            Race = race;
            Ethnicity = ethnicity;
        }
    }
}

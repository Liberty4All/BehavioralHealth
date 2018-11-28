using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralHealth.Domain
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Race Race { get; set; }
        public Ethnicity Ethnicity { get; set; }
    }
}

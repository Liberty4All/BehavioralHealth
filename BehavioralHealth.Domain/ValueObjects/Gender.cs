using System.Collections.Generic;

namespace BehavioralHealth.Domain
{
    public class Gender
    {
        public GenderType Value { get; }
        public string Text { get; }

        public Gender(GenderType genderType)
        {
            Value = genderType;
            switch (genderType)
            {
                case GenderType.Unknown:
                    Text = "Unknown";
                    break;
                case GenderType.Male:
                    Text = "Male";
                    break;
                case GenderType.Female:
                    Text = "Female";
                    break;
                default:
                    throw new System.Exception($"Unknown genderType: {genderType}");
            }
        }

        public List<Gender> GetAll()
        {
            var result = new List<Gender>()
            {
                new Gender(GenderType.Female),
                new Gender(GenderType.Male),
                new Gender(GenderType.Unknown)
            };

            return result;
        }
    }

    public enum GenderType
    {
        Unknown,
        Male,
        Female
    }
}
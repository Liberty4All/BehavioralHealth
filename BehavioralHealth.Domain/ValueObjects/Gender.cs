using BehavioralHealth.SharedKernel.Domain;
using System.Collections.Generic;

namespace BehavioralHealth.Domain
{
    public class Gender : ValueObjectBase<Gender>
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

        public override bool Equals(Gender other)
        {
            return this.Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Gender))
            {
                return false;
            }
            return this.Equals((Gender)obj);
        }

        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }
    }

    public enum GenderType
    {
        Unknown,
        Male,
        Female
    }
}
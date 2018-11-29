using BehavioralHealth.SharedKernel.Domain;
using System.Collections.Generic;

namespace BehavioralHealth.Domain
{
    public class Ethnicity : ValueObjectBase<Ethnicity>
    {
        public EthnicityType Value { get; }
        public string Text { get; }

        public Ethnicity(EthnicityType ethnicityType)
        {
            Value = ethnicityType;
            switch (ethnicityType)
            {
                case EthnicityType.Unknown:
                    Text = "Unknown";
                    break;
                case EthnicityType.Cuban:
                    Text = "Cuban";
                    break;
                case EthnicityType.Mexican:
                    Text = "Mexican";
                    break;
                case EthnicityType.PuertoRican:
                    Text = "Puerto Rican";
                    break;
                case EthnicityType.OtherSpecificHispanic:
                    Text = "Other Specific Hispanic";
                    break;
                case EthnicityType.HispanicOriginNotSpecified:
                    Text = "Hispanic - Specific Origin Not Specified";
                    break;
                case EthnicityType.NotOfHispanicOrigin:
                    Text = "Not of Hispanic Origin";
                    break;
                default:
                    throw new System.Exception($"Unknown ethnicityType: {ethnicityType}");
            }

        }

        public List<Ethnicity> GetAll()
        {
            var result = new List<Ethnicity>()
            {
                new Ethnicity(EthnicityType.Cuban),
                new Ethnicity(EthnicityType.Mexican),
                new Ethnicity(EthnicityType.PuertoRican),
                new Ethnicity(EthnicityType.OtherSpecificHispanic),
                new Ethnicity(EthnicityType.HispanicOriginNotSpecified),
                new Ethnicity(EthnicityType.NotOfHispanicOrigin),
                new Ethnicity(EthnicityType.Unknown)
            };

            return result;
        }

        public override bool Equals(Ethnicity other)
        {
            return this.Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Ethnicity))
            {
                return false;
            }
            return this.Equals((Ethnicity)obj);
        }

        public override int GetHashCode() => this.Value.GetHashCode() + Text.GetHashCode();
    }

    public enum EthnicityType
    {
        Unknown,
        Cuban,
        Mexican,
        PuertoRican,
        OtherSpecificHispanic,
        HispanicOriginNotSpecified,
        NotOfHispanicOrigin
    }
}
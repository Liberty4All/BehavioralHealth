using System.Collections.Generic;

namespace BehavioralHealth.Domain
{
    public class Ethnicity
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
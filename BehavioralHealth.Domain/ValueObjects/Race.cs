namespace BehavioralHealth.Domain
{
    public class Race
    {
        public RaceType Value { get; }
        public string Text { get; }

        public Race(RaceType raceType)
        {
            Value = raceType;
            switch (raceType)
            {
                case RaceType.Unknown:
                    Text = "Unknown";
                    break;
                case RaceType.AlaskaNative:
                    Text = "Alaska Native";
                    break;
                case RaceType.AmericanIndian:
                    Text = "American Indian";
                    break;
                case RaceType.Asian:
                    Text = "Asian";
                    break;
                case RaceType.Black:
                    Text = "Black/African-American";
                    break;
                case RaceType.NativeHawaiianOtherPacificIslander:
                    Text = "Native Hawaiian/Other Pacific Islander";
                    break;
                case RaceType.White:
                    Text = "White";
                    break;
                case RaceType.OtherSingleRace:
                    Text = "Other Single Race";
                    break;
                case RaceType.TwoOrMoreRaces:
                    Text = "Two or More Races";
                    break;
                default:
                    throw new System.Exception($"Unknown raceType: {raceType}");
            }
        }
    }

    public enum RaceType
    {
        Unknown,
        AlaskaNative,
        AmericanIndian,
        Asian,
        Black,
        NativeHawaiianOtherPacificIslander,
        White,
        OtherSingleRace,
        TwoOrMoreRaces        
    }
}
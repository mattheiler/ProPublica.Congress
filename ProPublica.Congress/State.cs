using System.Collections.Generic;
using System.Linq;

namespace ProPublica.Congress
{
    public class State
    {
        // States

        public static readonly State Alabama = new State("AL");
        public static readonly State Alaska = new State("AK");
        public static readonly State Arizona = new State("AZ");
        public static readonly State Arkansas = new State("AR");
        public static readonly State California = new State("CA");
        public static readonly State Colorado = new State("CO");
        public static readonly State Connecticut = new State("CT");
        public static readonly State Delaware = new State("DE");
        public static readonly State Florida = new State("FL");
        public static readonly State Georgia = new State("GA");
        public static readonly State Hawaii = new State("HI");
        public static readonly State Idaho = new State("ID");
        public static readonly State Illinois = new State("IL");
        public static readonly State Indiana = new State("IN");
        public static readonly State Iowa = new State("IA");
        public static readonly State Kansas = new State("KS");
        public static readonly State Kentucky = new State("KY");
        public static readonly State Louisiana = new State("LA");
        public static readonly State Maine = new State("ME");
        public static readonly State Maryland = new State("MD");
        public static readonly State Massachusetts = new State("MA");
        public static readonly State Michigan = new State("MI");
        public static readonly State Minnesota = new State("MN");
        public static readonly State Mississippi = new State("MS");
        public static readonly State Missouri = new State("MO");
        public static readonly State Montana = new State("MT");
        public static readonly State Nebraska = new State("NE");
        public static readonly State Nevada = new State("NV");
        public static readonly State NewHampshire = new State("NH");
        public static readonly State NewJersey = new State("NJ");
        public static readonly State NewMexico = new State("NM");
        public static readonly State NewYork = new State("NY");
        public static readonly State NorthCarolina = new State("NC");
        public static readonly State NorthDakota = new State("ND");
        public static readonly State Ohio = new State("OH");
        public static readonly State Oklahoma = new State("OK");
        public static readonly State Oregon = new State("OR");
        public static readonly State Pennsylvania = new State("PA");
        public static readonly State RhodeIsland = new State("RI");
        public static readonly State SouthCarolina = new State("SC");
        public static readonly State SouthDakota = new State("SD");
        public static readonly State Tennessee = new State("TN");
        public static readonly State Texas = new State("TX");
        public static readonly State Utah = new State("UT");
        public static readonly State Vermont = new State("VT");
        public static readonly State Virginia = new State("VA");
        public static readonly State Washington = new State("WA");
        public static readonly State WestVirginia = new State("WV");
        public static readonly State Wisconsin = new State("WI");
        public static readonly State Wyoming = new State("WY");

        // Territories

        public static readonly State Guam = new State("GU");
        public static readonly State PuertoRico = new State("PR");
        public static readonly State DistrictOfColumbia = new State("DC");
        public static readonly State VirginIslands = new State("VI");
        public static readonly State AmericanSamoa = new State("AS");
        public static readonly State NorthernMarianaIslands = new State("MP");

        private State(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public static IEnumerable<State> Values
        {
            get
            {
                // States

                yield return Alabama;
                yield return Alaska;
                yield return Arizona;
                yield return Arkansas;
                yield return California;
                yield return Colorado;
                yield return Connecticut;
                yield return Delaware;
                yield return Florida;
                yield return Georgia;
                yield return Hawaii;
                yield return Idaho;
                yield return Illinois;
                yield return Indiana;
                yield return Iowa;
                yield return Kansas;
                yield return Kentucky;
                yield return Louisiana;
                yield return Maine;
                yield return Maryland;
                yield return Massachusetts;
                yield return Michigan;
                yield return Minnesota;
                yield return Mississippi;
                yield return Missouri;
                yield return Montana;
                yield return Nebraska;
                yield return Nevada;
                yield return NewHampshire;
                yield return NewJersey;
                yield return NewMexico;
                yield return NewYork;
                yield return NorthCarolina;
                yield return NorthDakota;
                yield return Ohio;
                yield return Oklahoma;
                yield return Oregon;
                yield return Pennsylvania;
                yield return RhodeIsland;
                yield return SouthCarolina;
                yield return SouthDakota;
                yield return Tennessee;
                yield return Texas;
                yield return Utah;
                yield return Vermont;
                yield return Virginia;
                yield return Washington;
                yield return WestVirginia;
                yield return Wisconsin;
                yield return Wyoming;

                // Territories

                yield return Guam;
                yield return PuertoRico;
                yield return DistrictOfColumbia;
                yield return VirginIslands;
                yield return AmericanSamoa;
                yield return NorthernMarianaIslands;
            }
        }

        public static implicit operator string(State acronym)
        {
            return acronym?.ToString();
        }

        public static State Parse(string acronym)
        {
            return Values.Single(value => value.Name == acronym);
        }

        public static bool TryParse(string acronym, out State result)
        {
            return (result = Values.SingleOrDefault(value => value.Name == acronym)) != null;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
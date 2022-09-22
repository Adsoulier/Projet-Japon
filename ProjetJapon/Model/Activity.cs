namespace Model
{
    public class Activity : PointOfInterest
    {
        // Faire des TU pour voir si la liste marche
        private Dictionary<string, double> rangeOfPrices = new Dictionary<string, double> ();
        public Dictionary<string, double> RangeOfPrices { get => rangeOfPrices; set => rangeOfPrices = value; }


        public Activity(Accessibility accessibility, string description, string name, List<string> pictures, string coordinates) 
            : base(accessibility, description, name, pictures, coordinates)
        {
            RangeOfPrices.Add("For Everyone UwU", 0.00 );
        }

        public Activity(Accessibility accessibility, string description, string name, List<string> pictures, string coordinates, IEnumerable<string> condition, IEnumerable<double> prices) 
            : base(accessibility, description, name, pictures, coordinates)
        {
            if(condition.Count() != prices.Count()){
                //TODO Mettre code erreur
                return;
            }
            else{
                for (int i = 0; i < condition.Count(); i++)
                {
                    RangeOfPrices.Add(condition.ElementAt(i), prices.ElementAt(i));
                }
            }
        }

    }
}
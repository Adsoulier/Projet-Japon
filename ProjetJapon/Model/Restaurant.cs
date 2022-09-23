using Utils;

namespace Model
{
    public class Restaurant : PointOfInterest
    {
        private List<TypeOfFoodEnum> typesOfFood;

        private string webSite = "";

        public List<TypeOfFoodEnum> TypesOfFood {get => typesOfFood;}

        public string WebSite {get => webSite; set => webSite = value;}

        public Restaurant(Accessibility accessibility, string description, string name, List<string> pictures, string coordinates, IEnumerable<TypeOfFoodEnum> typesOfFood)
        : base(accessibility, description, name, pictures, coordinates)
        {
            if(typesOfFood == null || typesOfFood.Count() == 0)
                this.typesOfFood = new List<TypeOfFoodEnum>();
            else
                this.typesOfFood = new List<TypeOfFoodEnum> (typesOfFood);
        }

        public Restaurant(Accessibility accessibility, string description, string name, List<string> pictures, string coordinates, IEnumerable<TypeOfFoodEnum> typesOfFood, string webSite)
        : this(accessibility, description, name, pictures, coordinates, typesOfFood)
        {
            this.webSite = webSite;
        }
    }
}
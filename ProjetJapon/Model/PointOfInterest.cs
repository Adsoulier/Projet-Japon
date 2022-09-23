using Utils;

namespace Model
{
    public class PointOfInterest : Place
    {
        private string coordinates;
        private CategoryEnum category;
        public string Coordinates
        {
            get { return coordinates; }
            set { coordinates = value; }
        }
        public CategoryEnum Category
        {
            get { return category;}
            set { category = value;}
        }

        public PointOfInterest(Accessibility accessibility, string description, string name, List<string> pictures, string coordinates) 
        : base(accessibility, description, name, pictures)
        {
            this.coordinates = coordinates;
        }
    }
}
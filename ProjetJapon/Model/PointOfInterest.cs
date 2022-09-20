namespace Model
{
    public class PointOfInterest : Place
    {
        private string coordinates;

        public string Coordinates
        {
            get { return coordinates; }
            set { coordinates = value; }
        }
        

        public PointOfInterest(Accessibility accessibility, string description, string name, List<string> pictures, string coordinates) 
        : base(accessibility, description, name, pictures)
        {
            this.coordinates = coordinates;
        }
    }
}
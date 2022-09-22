namespace Model
{
    public class Restaurant : PointOfInterest
    {
        

        public Restaurant(Accessibility accessibility, string description, string name, List<string> pictures, string coordinates) : base(accessibility, description, name, pictures, coordinates)
        {
        }
    }
}
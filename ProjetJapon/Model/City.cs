namespace Model
{
    public class City : PointOfInterest
    {
        public City(Accessibility accessibility, string description, string name, List<string> pictures, string coordinates) : base(accessibility, description, name, pictures, coordinates)
        {
        }
    }
}
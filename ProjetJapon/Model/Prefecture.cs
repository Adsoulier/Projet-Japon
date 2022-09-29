namespace Model
{
    public class Prefecture : Place
    {
        private int surface;

        private List<PointOfInterest> pointsOfInterest = new List<PointOfInterest>();

        public int Surface
        {
            get { return surface; }
            set { surface = value; }
        }

        public List<PointOfInterest> PointsOfInterest {get => pointsOfInterest;}
        
        public Prefecture(Accessibility accessibility, string description, string name, List<string> pictures) 
        : base(accessibility, description, name, pictures)
        {
            
        }

        public Prefecture(Accessibility accessibility, string description, string name, List<string> pictures, List<PointOfInterest> pointsofInterest) 
        : base(accessibility, description, name, pictures)
        {
            this.PointsOfInterest.AddRange(pointsOfInterest);
        }
    }
}


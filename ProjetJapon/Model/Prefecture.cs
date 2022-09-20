namespace Model
{
    public class Prefecture : Place
    {
        private int surface;
        public int Surface
        {
            get { return surface; }
            set { surface = value; }
        }
        
        public Prefecture(Accessibility accessibility, string description, string name, List<string> pictures) 
        : base(accessibility, description, name, pictures)
        {
        }
    }
}


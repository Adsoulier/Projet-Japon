namespace Model
{
    public abstract class Place
    {
        private  Accessibility accessibility;
        private string description;
        private string name;
        private List<string> pictures = new List<string>();

        public string Description
        { 
            get { return description; }
            set { description = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Place(Accessibility accessibility, string description, string name, List<string> pictures)
        {
            this.accessibility = accessibility;
            this.description = description;
            this.name = name;
            this.pictures.AddRange(pictures);
        }
    }

}
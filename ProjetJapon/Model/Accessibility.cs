using Utils;

namespace Model
{
    
    public class Accessibility
    {
        private List<TransportEnum>? transports;

        public List<TransportEnum> Transports { get => transports; private set => transports = value; }

        public Accessibility(IEnumerable<TransportEnum>? transports){
            if (transports != null && transports.Count() != 0)
                this.Transports = new List<TransportEnum>(transports);
        }
    }
}


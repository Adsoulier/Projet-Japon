using Data;

namespace Model;

public class Manager
{
    private List<Place> places;
    private IDataManager dataManager;
    
    public List<Place> Places
    {
        get { return places;}
    }


}
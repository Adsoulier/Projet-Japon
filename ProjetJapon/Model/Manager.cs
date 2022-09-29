using Data;

namespace Model;

public class Manager
{
    private List<Place> places = new List<Place>();
    private IDataManager dataManager;
    
    public List<Place> Places
    {
        get { return places;}
    }

    public Manager(IDataManager dataManager)
    {
        this.dataManager = dataManager;
        //add the management of a loading failed here
        places.AddRange(dataManager.LoadData());
    }

    public List<Prefecture> GetAllPrefectures ()
    {
       // return new List<Prefecture>(Places.Where(p => p.GetType() == Prefecture));
        //return new List<Prefecture>(Places.Where(p => p.GetType() == typeof(Prefecture)));
        //A TESTER !!!!
        List<Prefecture> prefectures = new List<Prefecture>();
        foreach(var p in Places)
        {
            if (p.GetType() == typeof(Prefecture))
            {
                prefectures.Add((Prefecture)p);
            }
        }
        return prefectures;
    }

}
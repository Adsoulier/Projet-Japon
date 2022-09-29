using Data;
using Model;

namespace ViewModels;

public class ManagerViewModel : BaseViewModel{
    private Manager manager;

    public ManagerViewModel()
    {
        manager = new Manager(new Stub());
    }

    public IEnumerable<Prefecture> AllPrefectures => manager.GetAllPrefectures();
}
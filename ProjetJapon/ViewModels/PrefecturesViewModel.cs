using System.Collections.ObjectModel;
using Model;

namespace ViewModels;

public class PrefecturesViewModel : BaseViewModel
{
    private List<Prefecture> prefecturesModel = new List<Prefecture>();
    private ObservableCollection<Prefecture> prefectures = new ObservableCollection<Prefecture>();
    public ObservableCollection<Prefecture> Prefectures => prefectures;
    
    public PrefecturesViewModel ()
    {
        
    }

}
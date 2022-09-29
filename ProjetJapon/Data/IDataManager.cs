namespace Data;
using Model;

public interface IDataManager
{
    public List<Place> LoadData();

    public void SaveData(List<Place> places);
}
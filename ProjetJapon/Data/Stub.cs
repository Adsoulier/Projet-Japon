using Model;
using Utils;
namespace Data;

public class Stub : IDataManager
{
    public List<Place> LoadData()
    {
        return new List<Place> {
            new Prefecture(
                new Accessibility(new List<TransportEnum> {TransportEnum.Foot}),
                "Prefecture Test to see how it works", "Prefecture text", null)
        };
    }

    public void SaveData(List<Place> places)
    {
        throw new NotImplementedException();
    }
}
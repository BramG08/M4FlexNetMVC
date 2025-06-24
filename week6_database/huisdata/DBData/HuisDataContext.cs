using Microsoft.Data.Sqlite;
using huisdata.Models;
namespace huisdata.DBData;

public class HuisDataContext
{
    public string DBDPath { get; }

    public HuisDataContext()
    {
        string location = typeof(HuisDataContext).Assembly.Location;
        string folder = new FileInfo(location).Directory.FullName;
        DBDPath = Path.Join(folder, "huisdata.db");
    }

    public List<EnergyVerbruik> GetEnergyVebruik()
    {
        return new List<EnergyVerbruik>() { new EnergyVerbruik() };
    }
}

using NP.Support.Local.Models;

namespace NP.Support.Local.Datas;

public interface IOptionDataLoader
{
    List<Option> LoadOptions();
    List<Option> GetByCategory(string category);
}

using NP.Support.Local.Models;

namespace NP.Support.Local.Datas;

public interface ISpellsDataLoader
{
    List<Spell> LoadSpells();
}

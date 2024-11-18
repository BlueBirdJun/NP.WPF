using NP.Support.Local.Models;

namespace NP.Support.Local.Datas;

public interface IScheduleDataLoader
{
    List<Schedule> LoadSchedules();
}

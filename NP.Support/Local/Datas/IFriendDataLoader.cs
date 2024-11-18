using NP.Support.Local.Models;

namespace NP.Support.Local.Datas;
public interface IFriendDataLoader
{
    List<FriendCategory> LoadFriends();
}

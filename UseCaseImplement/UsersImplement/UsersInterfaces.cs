using DataAccesInterfaces.UsersDataAccesInterfaces;
using UseCaseInterfaces.UsersInterfaces;

namespace UseCaseImplement.UsersImplement;

public class UsersInterfaces : IUsersInterfaces
{
    private readonly IGetUsersData _getUsersData;

    public UsersInterfaces(IGetUsersData getUsersData)
    {
        _getUsersData = getUsersData;
    }

    public int GetUsers()
    {
        var userDat = _getUsersData.GetUserData();
        return userDat + 1;
    }
}
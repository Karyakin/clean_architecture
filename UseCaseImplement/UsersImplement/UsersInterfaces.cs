using DataAccesInterfaces.UsersDataAccesInterfaces;
using UseCaseInterfaces.UsersInterfaces;

namespace UseCaseImplement.UsersImplement;

public class UsersInterfaces : IUsersInterfaces
{
    private readonly IGetUsersDataInterfaces _getUsersDataInterfaces;

    public UsersInterfaces(IGetUsersDataInterfaces getUsersDataInterfaces)
    {
        _getUsersDataInterfaces = getUsersDataInterfaces;
    }

    public int GetUsers()
    {
        var userDat = _getUsersDataInterfaces.GetUserData();
        return userDat + 1;
    }
}
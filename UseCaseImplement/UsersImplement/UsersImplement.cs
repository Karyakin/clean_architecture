using DataAccesInterfaces.UsersDataAccesInterfaces;
using Entities.UserEntity;
using UseCaseInterfaces.UsersInterfaces;

namespace UseCaseImplement.UsersImplement;

public class UsersImplement : IUsersInterfaces
{
    private readonly IGetUsersDataInterfaces _getUsersDataInterfaces;

    public UsersImplement(IGetUsersDataInterfaces getUsersDataInterfaces)
    {
        _getUsersDataInterfaces = getUsersDataInterfaces;
    }

    public User GetUsers()
    {
        var user = _getUsersDataInterfaces.GetUserData();
        return user;
    }

}
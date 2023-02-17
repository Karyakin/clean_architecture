using DataAccesInterfaces.UsersDataAccesInterfaces;
using Entities.UserEntity;

namespace DataAcessImplement.UserDataAcessImplement;

public class GetUsersDataInterfaces: IGetUsersDataInterfaces
{
    public User GetUserData()
    {
        return new User
        {
            Name = "Дима",
            Age = 28
        };
    }
}
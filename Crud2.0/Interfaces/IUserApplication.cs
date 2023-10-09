namespace Crud2._0.Interfaces;

public interface IUser
{
    void Save(User user);
    User[] GetAll();
}
namespace MoqTesting
{
    public interface IUserRepository
    {
        User GetUserByUsername(string username);
        bool ValidatePassword(string username, string password); //Проверка пароля пользователя
    }
}
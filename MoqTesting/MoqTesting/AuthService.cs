namespace MoqTesting
{
    public class AuthService
    {
        private readonly IUserRepository _userRepository;
        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            return _userRepository.ValidatePassword(username, password);
        }
        /// <summary>
        /// Проверяет, что имя пользователя и пароль не пустые
        /// Если проверка не прошла - возвращает false (авторизация неуспешна)
        /// Если проверка прошла - делегирует проверку репозиторию пользователей
        /// Возвращает результат проверки от репозитория
        /// </summary>
    }
}
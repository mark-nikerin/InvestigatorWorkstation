using Storage.Models;

namespace Services.Services
{
    public static class CurrentUserService
    {
        private static Employee _currentUser;

        public static Employee GetCurrentUser()
        {
            return _currentUser;
        }

        public static bool IsAdmin()
        {
            return _currentUser?.IsAdmin ?? false;
        }

        public static void SetCurrentUser(Employee user)
        {
            _currentUser = user == null
                ? null
                : new Employee
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    IsAdmin = user.IsAdmin,
                    MiddleName = user.MiddleName,
                    LastName = user.LastName,
                    Login = user.Login,
                    Password = user.Password
                };
        }
    }
}

 namespace Services.Services
{ 
    public static class CurrentUserService
    {
        private static Storage.Models.Employee _currentUser;

        public static Storage.Models.Employee GetCurrentUser()
        {
            return _currentUser;
        }

        public static bool IsAdmin()
        {
            return _currentUser?.IsAdmin ?? false;
        }

        public static void SetCurrentUser(Storage.Models.Employee user)
        {
            _currentUser = user == null
                ? null
                : new Storage.Models.Employee
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

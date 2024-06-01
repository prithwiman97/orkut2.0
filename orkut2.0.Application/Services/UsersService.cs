using orkut2._0.Contracts.Models;

namespace orkut2._0.Application.Services
{
    public class UsersService : IUsersService
    {
        private static readonly List<Users> _users = new()
        {
            new()
            {
                Firstname = "Prithwiman",
                Lastname = "Mazumdar",
            },
            new()
            {
                Firstname = "John",
                Lastname = "Smith",
            },
            new()
            {
                Firstname = "Tyler",
                Lastname = "Jones",
            },
            new()
            {
                Firstname = "Stuart",
                Lastname = "William",
            }
        };

        public async Task<List<Users>> GetUsersAsync()
        {
            return _users;
        }

    }
}

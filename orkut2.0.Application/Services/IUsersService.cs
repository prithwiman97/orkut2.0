using orkut2._0.Contracts.Models;

namespace orkut2._0.Application.Services
{
    public interface IUsersService
    {
        Task<List<Users>> GetUsersAsync();
    }
}

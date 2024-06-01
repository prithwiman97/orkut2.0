using orkut2._0.Application.Models;

namespace orkut2._0.Application.Services
{
    public interface IUsersService
    {
        Task<List<Users>> GetUsersAsync();
    }
}

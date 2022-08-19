using System.Security.Claims;
using System.Threading.Tasks;
using Core.DTO;
using Core.Entities.UserEntity;

namespace Core.Interfaces.CustomService
{
    public interface IUserService
    {
        string GetCurrentUserNameIdentifier(ClaimsPrincipal currentUser);
        Task<string> GetUserRoleAsync(User user);
        Task<ProfileDTO> GetProfileUserAsync(string id);
        Task<UserFullNameDTO> GetFullNameImageAsync(string userId);
        Task EditProfileAsync(ProfileDTO profile);
    }
}

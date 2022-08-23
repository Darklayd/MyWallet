using System.Security.Claims;
using System.Threading.Tasks;
using Core.DTO;
using Core.Entities.UserEntity;
using Core.Modals;

namespace Core.Interfaces.CustomService
{
    public interface IUserService
    {
        string GetCurrentUserNameIdentifier(ClaimsPrincipal currentUser);
        Task<string> GetUserRoleAsync(User user);
        Task<ProfileModal> GetProfileUserAsync(string id);
        Task<UserFullNameDTO> GetFullNameImageAsync(string userId);
        Task EditProfileAsync(ProfileModal profile);
    }
}

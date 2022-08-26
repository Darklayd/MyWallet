using System.Security.Claims;
using System.Threading.Tasks;
using Core.DTO;
using Core.Entities.UserEntity;
using Core.Models;

namespace Core.Interfaces.CustomService
{
    public interface IUserService
    {
        string GetCurrentUserNameIdentifier(ClaimsPrincipal currentUser);
        Task<string> GetUserRoleAsync(User user);
        Task<ProfileModel> GetProfileUserAsync(string id);
        Task<UserFullNameDTO> GetFullNameImageAsync(string userId);
        Task EditProfileAsync(ProfileModel profile);
    }
}

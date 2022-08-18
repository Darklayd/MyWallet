using AutoMapper;
using Core.DTO;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Core.Resources;

namespace Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public UserService(
            IRepository<User> userRepository,
            IMapper mapper,
            UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userManager = userManager;

        }

        public async Task<ProfileDTO> GetProfileUser(string id)
        {
            if (id != null)
            {
                var User = await _userRepository.GetByIdAsync(id);
                return _mapper.Map<ProfileDTO>(User);
            }
            else
            {
                throw new HttpException("User ID null!", HttpStatusCode.BadRequest);
            }
        }

        public string GetCurrentUserNameIdentifier(ClaimsPrincipal currentUser)
        {
            return currentUser.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public async Task<string> GetUserRoleAsync(User user)
        {
            var userRoles = await _userManager.GetRolesAsync(user);

            if (userRoles == null)
            {
                throw new HttpException(ErrorMessages.RoleNotFound, HttpStatusCode.NotFound);
            }

            return userRoles.First();
        }
        public async Task<UserFullNameDTO> GetUserFullNameAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                throw new HttpException(ErrorMessages.RoleNotFound, HttpStatusCode.NotFound);
            }

            return _mapper.Map<UserFullNameDTO>(user);
        }
    }
}

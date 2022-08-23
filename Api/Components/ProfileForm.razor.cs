using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Components;
using System;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Core.Constants;
using Core.Modals;

namespace Api.Components
{
    public class RazorProfileModel : ComponentBase
    {
        [Inject] private IUserService _UserService { get; set; }

        [Parameter]
        public string UserId { get; set; }

        public ProfileModal Profile { get; set; }

        public RazorProfileModel()
        {
            SetDefaultProfile();
        }

        protected async Task ChangProfile()
        {
            await _UserService.EditProfileAsync(Profile);
        }

        public async Task GetUserId()
        {
            if (UserId != null)
            {
                Profile = await _UserService.GetProfileUserAsync(UserId);
                if (Profile == null)
                    SetDefaultProfile();
            }
        }

        protected override async Task OnInitializedAsync()
        {
            await GetUserId();
        }

        private void SetDefaultProfile()
        {
            Profile = new ProfileModal()
            {
                Id = "",
                FirstName = "Connect problem",
                LastName = "Connect problem",
                Email = "Connect problem",
                EmailConfirmed = false,
                AvatarImage = ProfileAvatar.Default
            };
        }
    }
}

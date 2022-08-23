using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Components;
using System;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Api.ModalWindows;
using Blazored.Modal;
using Blazored.Modal.Services;
using Core.Constants;
using Core.Modals;

namespace Api.Components
{
    public class RazorProfileModel : ComponentBase
    {
        [CascadingParameter]//додаєм каскадний параметр
        public IModalService Modal { get; set; } = default!;

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
            try
            {
                if (UserId != null)
                {
                    Profile = await _UserService.GetProfileUserAsync(UserId);
                    if (Profile == null)
                        SetDefaultProfile();
                }
            }
            catch (Exception e)
            {
                var parameters = new ModalParameters();
                parameters.Add(nameof(e.Message), e.Message);
                Modal.Show<ErrorModal>("Error", parameters);
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

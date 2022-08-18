using Core.DTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Components;
using System;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Api.Components
{
    public class RazorProfileModel : ComponentBase
    {
        [Inject] private IUserService _UserService { get; set; }

        [Parameter]
        public string UserId { get; set; }

        public ProfileDTO Profile { get; set; }

        public RazorProfileModel()
        {
            Profile = new ProfileDTO()
            {
                Id = "", 
                FirstName = "Connect problem", 
                LastName = "Connect problem", 
                Email = "Connect problem",
                EmailConfirmed = false
            };
        }

        protected void HandleValidSubmit()
        {
            // Process the valid form
            throw new NotImplementedException();
        }

        protected void ChangProfile()
        {
            //throw new NotImplementedException();
        }

        public async Task GetUserId()
        {
            if (UserId != null)
            {
                Profile = await _UserService.GetProfileUser(UserId);
                if (Profile == null)
                    Profile = new ProfileDTO()
                    {
                        Id = "",
                        FirstName = "Connect problem",
                        LastName = "Connect problem",
                        Email = "Connect problem",
                        EmailConfirmed = false
                    };
            }
        }

        protected override async Task OnInitializedAsync()
        {
            await GetUserId();
        }
    }
}

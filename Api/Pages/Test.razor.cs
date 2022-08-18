using AutoMapper;
using Core.DTO;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Api.Pages
{
    public class TestModel : ComponentBase
    {
        [Inject] private IMapper _Mapper { get; set; }
        //[Inject] private UserManager<User> _UserManager { get; }
        public ProfileDTO profile { get; set; }

        [Parameter] 
        public string UserName { get; set; }

        public async Task GetUserName()
        {
            if (UserName != null)
            {
                var user = new ProfileDTO(){LastName = "Pasichnik", FirstName = "Eugen", Email = UserName};
                    //await _UserManager.FindByNameAsync(UserName);
                profile = _Mapper.Map<ProfileDTO>(user);
            }
            
        }

        protected override async Task OnInitializedAsync()
        {
            await GetUserName();
        }

    }
}

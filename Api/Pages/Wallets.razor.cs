using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Api.ModalWindows;
using Blazored.Modal;
using Blazored.Modal.Services;
using Core.DTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;

namespace Api.Pages
{
    public class WalletsComponent : ComponentBase
    {
        [Inject]
        public IHttpContextAccessor HttpContextAccessor { get; set; } = default!;

        [Inject]
        public IWalletService WalletService { get; set; }

        [CascadingParameter]
        public IModalService Modal { get; set; } = default!;

        protected List<WalletDTO> UserWallets { get; set; }

        protected string UserId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            UserId = HttpContextAccessor.HttpContext.User
                .FindFirstValue(ClaimTypes.NameIdentifier);
            await ShowWalletsAsync(UserId);
        }

        protected void ShowModal()
        {
            var parameters = new ModalParameters();
            parameters.Add(
                nameof(AddWalletModal.UserId),
                UserId);

            parameters.Add(nameof(AddWalletModal.WalletsComponent),
                this);

            Modal.Show<AddWalletModal>("Create Wallet", parameters);
        }
        public async Task Rerender()
        {
            await ShowWalletsAsync(UserId);
            StateHasChanged();
        }

        protected async Task ShowWalletsAsync(string userId)
        {
            UserWallets = await WalletService
                .GetWalletsAsync(userId);
            if (UserWallets.Count == 0)
            {
                UserWallets = null;
            }
        }
    }
}

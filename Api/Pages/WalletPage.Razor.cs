using System.Threading.Tasks;
using Api.ModalWindows;
using Blazored.Modal;
using Blazored.Modal.Services;
using Core.DTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Components;

namespace Api.Pages
{
    public class WalletPageComponent: ComponentBase
    {
        [Inject]
        public IWalletService WalletService { get; set; }

        [Parameter]
        public int WalletId { get; set; }
        
        [CascadingParameter]
        public IModalService Modal { get; set; } = default!;

        public WalletInfoDTO WalletInfo { get; set; }

        public WalletPageComponent()
        {
            WalletInfo = new WalletInfoDTO();
        }

        protected override async Task OnInitializedAsync()
        {
            await GetWalletAsync();
        }

        async Task GetWalletAsync()
        {
            WalletInfo = await WalletService.GetWalletByIdAsync(WalletId);
        }

        protected void ShowModal()
        {
            var parameters = new ModalParameters();

            parameters.Add(nameof(AddCashModal.WalletPageComponent),
                this);

            Modal.Show<AddCashModal>("Add Cash", parameters);
        }
        protected void ShowConvertModal(double amount, string typeMoney)
        {
            var parameters = new ModalParameters();

            parameters.Add("Amount", amount);

            parameters.Add("TypeMoney", typeMoney);

            parameters.Add(nameof(AddCashModal.WalletPageComponent),
                this);

            Modal.Show<ConvertMoneyModal>("Currency Convert", parameters);
        }

        public async Task Rerender()
        {
            await ShowCashAsync();
            StateHasChanged();
        }

        protected async Task ShowCashAsync()
        {
            await GetWalletAsync();
            if (WalletInfo.Cash.Count == 0)
            {
                WalletInfo.Cash = null;
            }
        }
    }
}

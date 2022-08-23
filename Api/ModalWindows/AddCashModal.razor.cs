using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Api.Pages;
using Blazored.Modal;
using Blazored.Modal.Services;
using Core.DTO;
using Core.Interfaces.CustomService;
using Core.Modals;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;

namespace Api.ModalWindows
{
    public class AddCashModalComponent: ComponentBase
    {
        [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; } = default!;

        [Inject]
        public IHttpContextAccessor HttpContextAccessor { get; set; } = default!;

        [Inject]
        public ICashService CashService { get; set; }

        [Inject]
        public ITypeMoneyService TypeMoneyService { get; set; }

        [Inject]
        public ICardService CardService { get; set; }

        [Parameter]
        public WalletPage WalletPageComponent { get; set; }

        protected string UserId { get; set; }

        protected CashModal Cash { get; set; }

        protected List<TypeMoneyInfoDTO> TypeMoneyList { get; set; }

        protected List<CardInfoDTO> Cards { get; set; }

        public AddCashModalComponent()
        {
            Cash = new CashModal() {TypeMoneyId = 1, CardNumber = "-"};
        }

        protected override async Task OnInitializedAsync()
        {
            TypeMoneyList = await TypeMoneyService.GetListAsync();
        }

        protected override async Task OnParametersSetAsync()
        {
            UserId = HttpContextAccessor.HttpContext.User
                .FindFirstValue(ClaimTypes.NameIdentifier);
            Cards = await CardService.GetCardsByUser(UserId);
        }

        protected async Task AddCash()
        {
            if (Cash.Count != 0)
            {
                Cash.WalletId = WalletPageComponent.WalletId;
                await CashService.AddCashAsync(Cash);
                WalletPageComponent.Rerender();
            }
            await BlazoredModal.CloseAsync(ModalResult.Ok(true));
        }
    }
}

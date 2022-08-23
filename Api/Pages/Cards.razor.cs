﻿using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
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
    public class CardsComponent: ComponentBase
    {
        [CascadingParameter]
        public IModalService Modal { get; set; } = default!;
        
        [Inject]
        public IHttpContextAccessor HttpContextAccessor { get; set; } = default!;

        [Inject] public ICardService CardService { get; set; }

        internal List<CardInfoDTO> Cards { get; set; }

        protected string UserId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            UserId = HttpContextAccessor.HttpContext.User
                .FindFirstValue(ClaimTypes.NameIdentifier);
            await ShowCardsAsync(UserId);
        }

        protected async Task ShowModal()
        {
            var parameters = new ModalParameters();
            parameters.Add(
                nameof(AddCardModal.UserId),
                UserId);

            parameters.Add(nameof(AddCardModal.CardsComponent),
                this);

            Modal.Show<AddCardModal>("Add Card", parameters);
        }

        async Task ShowCardsAsync(string userId)
        {
            Cards = await CardService.GetCardsByUser(userId);
            if (Cards.Count == 0)
            {
                Cards = null;
            }
        }

        protected async Task DeleteCard(string number)
        {
            await CardService.DeleteCardByNumber(number);
            Thread.Sleep(1000);
            await ShowCardsAsync(UserId);
            StateHasChanged();
        }

        public async Task Rerender()
        {
            await ShowCardsAsync(UserId);
            StateHasChanged();
        }
    }
}
using Api.ModalWindows;
using Blazored.Modal;
using Blazored.Modal.Services;
using Core.DTO;
using Core.DTO.JsonModels;
using Core.Interfaces.CustomService;
using IgniteUI.Blazor.Controls;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Api.Pages
{
    public class IndexComponent : ComponentBase
        {
        [CascadingParameter]//додаєм каскадний параметр
        public IModalService Modal { get; set; } = default!;

        [Inject]
        public ITypeMoneyService TypeMoneyService { get; set; }

        public List<TypeMoneyInfoDTO> TypeMoneyList { get; set; }

        protected string TypeMoney { get; set; } = "USD";

        //початкова дата нарік менша від тривалогочасу
        protected string StartDate { get; set; } = DateTime.UtcNow.ToString($"{DateTime.UtcNow.Year - 1}.MM.dd");

        //кінцева дата тобто та що зараз триває
        protected string EndDate { get; set; } = DateTime.UtcNow.ToString("yyyy.MM.dd");

        private IgbCategoryChart _Chart;
        protected IgbCategoryChart Chart
        {
            get { return _Chart; }
            set
            {
                _Chart = value;
                StateHasChanged();
            }
        }

        protected List<RateItem> Data;

        //Клас який працює з запитами до API
        public HttpClient HttpClient { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                HttpClient = new HttpClient();
                await SetDataAsync();
                TypeMoneyList = await TypeMoneyService.GetListAsync();
            }
            catch (Exception e)
            {
                var parameters = new ModalParameters();
                parameters.Add(nameof(e.Message), e.Message);
                Modal.Show<ErrorModal>("Error", parameters);
            }

        }

        protected async Task OnReloadChart()
        {
            try
            {
                await SetDataAsync();
                await this.Chart.ReplayTransitionInAsync();
            }
            catch (Exception e)
            {
                var parameters = new ModalParameters();
                parameters.Add(nameof(e.Message), e.Message);
                Modal.Show<ErrorModal>("Error", parameters);
            }
        }

        //метод який отримує дані по вказаній валюті вказаний період
        async Task SetDataAsync()
        {
            try
            {
                var dataJson = await HttpClient
                    .GetStringAsync(
                        $"https://bank.gov.ua/NBU_Exchange/exchange_site?start={StartDate.Replace(".", "")}&end={EndDate.Replace(".", "")}&valcode={TypeMoney.ToLower()}&sort=exchangedate&order=desc&json");

                Data = JsonSerializer.Deserialize<List<RateItem>>(dataJson);
            }
            catch (Exception e)
            {
                var parameters = new ModalParameters();
                parameters.Add(nameof(e.Message), e.Message);

                Modal.Show<ErrorModal>("Error", parameters);
                TypeMoney = "USD";
            }
        }
    }
}

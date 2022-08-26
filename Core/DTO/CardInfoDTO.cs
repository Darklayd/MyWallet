//Тут і нище описані модельки в яких передаються дані

using System;

namespace Core.DTO
{
    public class CardInfoDTO
    {
        public string Number { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime CardTerm { get; set; }
        public string Type { get; set; }
        public string Logo { get; set; }
        public string CVC2 { get; set; }
    }
}

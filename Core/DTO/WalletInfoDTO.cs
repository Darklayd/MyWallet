using System;
using System.Collections.Generic;

namespace Core.DTO
{
    public class WalletInfoDTO
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public List<CashInfoDTO> Cash { get; set; }
    }
}

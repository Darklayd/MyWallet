using System;
using System.Collections.ObjectModel;
using Core.Entities.WalletEntity;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities.UserEntity
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string AvatarImage { get; set; }
        public Collection<Wallet> Wallets { get; set; }
    }
}

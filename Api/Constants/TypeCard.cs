//Сталі назви банківських карт
using System.Collections.Generic;

namespace Api.Constants
{
    public static class TypeCard
    {
        public static CardImageType Visa { get; } = new CardImageType()
            {
                TypeName = "Visa" , 
                ImageSrc = "Icons/visa_card_payment_icon.svg"
            };

        public static CardImageType MasterCard { get; } = new CardImageType()
        {
            TypeName = "Master Card",
            ImageSrc = "Icons/master_card_payment_icon.svg"
        };

        public static List<CardImageType> GetList()
        {
            return new List<CardImageType>()
                {
                    Visa,
                    MasterCard
                };
        }
    }

    public class CardImageType
        {
            public string TypeName { get; set; }
            public string ImageSrc { get; set; }
        }
}

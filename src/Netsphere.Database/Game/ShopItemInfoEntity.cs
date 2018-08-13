﻿using LinqToDB.Mapping;

namespace Netsphere.Database.Game
{
    [Table("shop_iteminfos")]
    public class ShopItemInfoEntity : Entity
    {
        [Column]
        public int ShopItemId { get; set; }

        [Column]
        public int PriceGroupId { get; set; }

        [Column]
        public int EffectGroupId { get; set; }

        [Column]
        public byte DiscountPercentage { get; set; }

        [Column]
        public bool IsEnabled { get; set; }

        [Association(CanBeNull = true, ThisKey = "ShopItemId", OtherKey = "Id")]
        public ShopItemEntity ShopItem { get; set; }
    }
}

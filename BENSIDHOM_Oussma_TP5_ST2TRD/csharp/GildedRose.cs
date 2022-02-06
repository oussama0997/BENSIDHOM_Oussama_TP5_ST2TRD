using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                switch (Items[i].Name)
                {
                    case ("+5 Dexterity Vest"):
                        if (Items[i].SellIn > 0)
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                        else if (Items[i].SellIn <= 0)
                        {
                            Items[i].Quality = Items[i].Quality - 2;
                        }
                        break;
                    case ("Aged Brie"):
                        if (Items[i].SellIn > 0)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                        else if (Items[i].SellIn <= 0)
                        {
                            Items[i].Quality = Items[i].Quality + 2;
                        }
                        break;
                    case ("Elixir of the Mongoose"):
                        if (Items[i].SellIn > 0)
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                        else if (Items[i].SellIn <= 0)
                        {
                            Items[i].Quality = Items[i].Quality - 2;
                        }
                        break;
                    case ("Backstage passes to a TAFKAL80ETC concert"):
                        if (Items[i].SellIn > 10)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                        else if (Items[i].SellIn > 5)
                        {
                            Items[i].Quality = Items[i].Quality + 2;
                        }
                        else if (Items[i].SellIn > 0)
                        {
                            Items[i].Quality = Items[i].Quality + 3;
                        }
                        else if (Items[i].SellIn <= 0)
                        {
                            Items[i].Quality = 0;
                        }
                        break;
                    case ("Conjured Mana Cake"):
                        if (Items[i].SellIn > 0)
                        {
                            Items[i].Quality = Items[i].Quality - 1 * 2;
                        }
                        else if (Items[i].SellIn <= 0)
                        {
                            Items[i].Quality = Items[i].Quality - 2 * 2;
                        }
                        break;
                    default:
                        break;
                }
                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                    if (Items[i].Quality < 0)
                    {
                        Items[i].Quality = 0;
                    }
                    if (Items[i].Quality > 50)
                    {
                        Items[i].Quality = 50;
                    }
                }



                //if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                //{
                //    if (Items[i].Quality > 0)
                //    {
                //        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                //        {
                //            Items[i].Quality = Items[i].Quality - 1;
                //        }
                //    }
                //}
                //else
                //{
                //    if (Items[i].Quality < 50)
                //    {
                //        Items[i].Quality = Items[i].Quality + 1;

                //        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                //        {
                //            if (Items[i].SellIn < 11)
                //            {
                //                if (Items[i].Quality < 50)
                //                {
                //                    Items[i].Quality = Items[i].Quality + 1;
                //                }
                //            }

                //            if (Items[i].SellIn < 6)
                //            {
                //                if (Items[i].Quality < 50)
                //                {
                //                    Items[i].Quality = Items[i].Quality + 1;
                //                }
                //            }
                //        }
                //    }
                //}

                //if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                //{
                //    Items[i].SellIn = Items[i].SellIn - 1;
                //}

                //if (Items[i].SellIn < 0)
                //{
                //    if (Items[i].Name != "Aged Brie")
                //    {
                //        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                //        {
                //            if (Items[i].Quality > 0)
                //            {
                //                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                //                {
                //                    Items[i].Quality = Items[i].Quality - 1;
                //                }
                //            }
                //        }
                //        else
                //        {
                //            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                //        }
                //    }
                //    else
                //    {
                //        if (Items[i].Quality < 50)
                //        {
                //            Items[i].Quality = Items[i].Quality + 1;
                //        }
                //    }
                //}


            }
        }
    }
}

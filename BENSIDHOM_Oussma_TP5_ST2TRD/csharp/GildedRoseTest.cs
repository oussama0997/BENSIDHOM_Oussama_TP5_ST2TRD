using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void non_negative_quality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 1, Quality = 0 } };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            app.UpdateQuality();

            Assert.AreEqual(0, Items[0].Quality);
        }
        [Test]
        public void non_sup_50_quality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -50, Quality = 50 } };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(50, Items[0].Quality);
        }
        [Test]
        public void negative_sellin_null_quality_concert()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 31 } };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(0, Items[0].Quality);
        }
        [Test]
        public void positive_sellin_increasing_quality_concert()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 35 } };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(38, Items[0].Quality);
        }
        [Test]
        public void negative_sellin_cheese_increasing_quality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -2, Quality = 30 } };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(32, Items[0].Quality);
        }
        [Test]
        public void positive_sellin_cheese_increasing_quality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 30 } };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(31, Items[0].Quality);
        }
        [Test]
        public void negative_sellin_cake_decreasing_quality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = -1, Quality = 30 } };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(28, Items[0].Quality);
        }
        [Test]
        public void positive_sellin_cake_decreasing_quality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 14, Quality = 30 } };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(29, Items[0].Quality);
        }
        [Test]
        public void negative_sellin_decreasing_quality_Elixir()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = -1, Quality = 30 } };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(28, Items[0].Quality);
        }
        [Test]
        public void positive_sellin_decreasing_quality_Elixir()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 30 } };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(29, Items[0].Quality);
        }
    }
}

using Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess
{
    public class VareDA
    {

        List<Item> itemDB = new List<Item>();

        public VareDA()
        {

            itemDB.Add(new Item() {Id = 1, Name = "Apple", Description = "Red danish Apple", PurchasePrice = 122.99, Gain = 20.0, StockLocation = 27  });
            itemDB.Add(new Item() {Id = 2, Name = "Pear", Description = "Green danish Pear", PurchasePrice = 312.99, Gain = 1.50, StockLocation = 21 });
            itemDB.Add(new Item() {Id = 3, Name = "Banana", Description = "Banana imported from Colombia", PurchasePrice = 1.99, Gain = 3.0, StockLocation = 22 });
            itemDB.Add(new Item() {Id = 4, Name = "Pinapple", Description = "Nice pinapple imported from Brazil", PurchasePrice = 1212.99, Gain = 5.0, StockLocation = 23 });
            itemDB.Add(new Item() {Id = 5, Name = "Mango", Description = "Mango imported from india", PurchasePrice = 127.99, Gain = 9.0, StockLocation = 27 });
            itemDB.Add(new Item() {Id = 6, Name = "Orange", Description = "Mango imported from india", PurchasePrice = 327.99, Gain = 9.0, StockLocation = 27 });
            itemDB.Add(new Item() {Id = 7, Name = "Lemon", Description = "Mango imported from india", PurchasePrice = 437.99, Gain = 9.0, StockLocation = 27 });
            itemDB.Add(new Item() {Id = 8, Name = "Lime", Description = "Mango imported from india", PurchasePrice = 127.99, Gain = 900.0, StockLocation = 27 });
            itemDB.Add(new Item() {Id = 9, Name = "Tomato", Description = "Mango imported from india", PurchasePrice = 7.99, Gain = 209.0, StockLocation = 27 });
            itemDB.Add(new Item() {Id = 10, Name = "Blackberry", Description = "Mango imported from india", PurchasePrice = 7.99, Gain = 9.0, StockLocation = 27 });

        }

        public List<Item> Get() { return itemDB; }

        public Item Get(int id)
        {
            Item item = new Item();
            for (int i = 0; i < itemDB.Count; i++)
            {
                if (itemDB[i].Id == id)
                {
                    item = itemDB[i];
                }


            }

            return item;


        }

        public bool Create(Item item) 
        {

            int highestID = 0;

            for (int i = 0; i < itemDB.Count; i++)
            {
                if (itemDB[i].Id > highestID)
                {
                    highestID = itemDB[i].Id;
                }
            }
        
            item.Id = highestID + 1;
            itemDB.Add(item);
            return true;

        }

        public bool Update(Item item)
        {

            bool UpdateSuccess = false;

            for (int i = 0; i < itemDB.Count; i++)
            {
                if (itemDB[i].Id == item.Id)
                {
                    itemDB[i] = item;
                    UpdateSuccess = true;

                }

            }

            return UpdateSuccess;

        }

        public bool Delete(int id)
        {
            bool DeleteSuccess = false;

            for (int i = 0; i < itemDB.Count; i++)
            {
                if (itemDB[i].Id == id)
                {
                    itemDB.RemoveAt(i);
                    DeleteSuccess = true;
                }


            }

            return DeleteSuccess;
        }

    }
}
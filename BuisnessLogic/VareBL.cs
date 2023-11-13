
using DataAccess;
using Models;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace BuisnessLogic
{
    public class VareBL
    {
        VareDA vareDA = new VareDA();
        
        public List<Item> Get()
        {
            List<Item> itemDB = vareDA.Get();
            return itemDB;

        }

        public Item Get(int id)
        {
            return vareDA.Get(id);
        }

        public bool Create(Item item)
        {
            bool isValid = IsItemValid(item);
            if (isValid) 
            {
                return vareDA.Create(item);
            }
            return false;

        }

        public bool Update(Item item) 
        {
            bool isValid = IsItemValid(item);
            if (isValid) 
            {
                return vareDA.Update(item);
            }
            return false;
        }

        public bool Delete(int id) 
        {
            return vareDA.Delete(id);
        }


        public List<Item> ItemsOverSalePrice(double price)
        {
            List<Item> data = vareDA.Get();

            List<Item> output = data.Where(item => item.SalePrice > price).ToList();

            return output;

        }

        public int NumberOfItemsOverBuyPrice(double price) 
        {
            List<Item> data = vareDA.Get();

            int output = data.Where(item => item.PurchasePrice > price).Count();

            return output;
        }


        public int LowestID()
        {
            List<Item> data = vareDA.Get();

            return data.Min(item => item.Id);

        }

        public List<Item> SortNavn() 
        {
            List<Item> data = vareDA.Get();
            
            return data.OrderByDescending(item => item.Name).ToList();

        }


        private bool IsItemValid(Item item) 
        {
            bool isValid = true;
            if (!ValidateName(item.Name)) {  isValid = false; }
            if (!ValidateDiscribtion(item.Name)) {  isValid = false; }
            if (!ValidateDiscribtion(item.Description)) {  isValid = false; }
            if (!ValidatePrice(item.PurchasePrice)) {  isValid = false; }
            
            return isValid;

        }


        private bool ValidateName(string name)
        {
            string namePattern = "^[a-zæøå -]+$";
            Regex navnRegex = new Regex(namePattern);

            if (navnRegex.IsMatch(name.ToLower()) && name.Length > 2 && name.Length < 50)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        private bool ValidateDiscribtion(string name)
        {
            string namePattern = "^[a-zæøå -]+$";
            Regex navnRegex = new Regex(namePattern);

            if (navnRegex.IsMatch(name.ToLower()) && name.Length > 1 && name.Length < 350)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private bool ValidatePrice(double price)
        {

            bool isValid = false;

            if (price > 0.0)
            {
                isValid = true;
            }

            return isValid;
        }

    }
}
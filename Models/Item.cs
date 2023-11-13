namespace Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double PurchasePrice { get; set; }
        public double Gain { get; set; }
        public double SalePrice 
        { 
            get
            {
                return PurchasePrice + Gain;
            }
            
            private set
            {

            }
        }

        public int StockLocation { get; set; } 
    }
}
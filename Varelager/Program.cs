using BuisnessLogic;
using Models;
using System.Data;

VareBL vareBL = new VareBL();

List<Item> overPris = vareBL.ItemsOverSalePrice(200);

foreach (Item vare in overPris)
{

    Console.WriteLine($"ID: {vare.Id} varenavn:{vare.Name} vi køber til {Math.Round(vare.PurchasePrice, 2)} og vi sælger til {Math.Round(vare.SalePrice, 2)}");


}

Console.WriteLine();


Console.WriteLine($"Antallet af vare med en pris over 200 er: {vareBL.NumberOfItemsOverBuyPrice(200)}");


Console.WriteLine();

Console.WriteLine($"mindste ID er {vareBL.LowestID()}");

Console.WriteLine();

List<Item> DataSorted = vareBL.SortNavn();

foreach (Item vare in DataSorted)
{

    Console.WriteLine($"ID: {vare.Id} varenavn:{vare.Name} vi køber til {Math.Round(vare.PurchasePrice, 2)} og vi sælger til {Math.Round(vare.SalePrice, 2)}");


}


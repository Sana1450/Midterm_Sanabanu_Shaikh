using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Method to sell an item
    public void SellItem(int quantitySold)
    {
        QuantityInStock -= quantitySold;
        Console.WriteLine($"Sold {quantitySold} {ItemName}(s).");
    }

    // Method to restock an item
    public void RestockItem(int additionalQuantity)
    {
        if (additionalQuantity >= 0)
        {
            QuantityInStock += additionalQuantity;
            Console.WriteLine($"Restocked {additionalQuantity} {ItemName}(s).");
        }
        else
        {
            Console.WriteLine("Error: Invalid quantity to restock.");
        }
    }

    // Method to display item details
    public void PrintDetails()
    {
        Console.WriteLine($"Item: {ItemName} (ID: {ItemId})");
        Console.WriteLine($"Price: ${Price:F2}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Print details of all items
        Console.WriteLine("Inventory Items:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Sell some items and print the updated details
        item1.SellItem(7);
        item2.SellItem(4);
        Console.WriteLine("\n Updated Inventory:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Restock an item and print the updated details
        item1.RestockItem(4);
        Console.WriteLine("\nUpdated Inventory:");
        item1.PrintDetails();
    }
}

using OOPsProblemStatement.InventoryManagement;
using System;

namespace OOPsProblemStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            InventoryOperation inventory = new InventoryOperation();
            inventory.ReadJsonFile(@"E:\pl_.net_exercise\OOPsProblemStatement1\InventoryManagementProblem\inventory.json");

            InventoryDataManagement dataManagement = new InventoryDataManagement();
            dataManagement.ReadJsonFile(@"E:\pl_.net_exercise\OOPsProblemStatement1\InventoryManagement\InventoryDetail.json");
        }
    }
}
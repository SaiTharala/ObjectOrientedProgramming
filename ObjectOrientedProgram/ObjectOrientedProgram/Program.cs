using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Object Oriented Programming!!");
                Console.WriteLine("Choose an Option..:\n 1.JSON \n 2.InventoryMangement\n 3.StockMangement\n 4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryMain inv = new InventoryMain();
                        inv.DisplayData(@"E:\GIT BL\ObjectOrientedProgramming\ObjectOrientedProgramming\ObjectOrientedProgram\ObjectOrientedProgram\InventoryMain.cs");
                        break;
                    case 2:
                        InventoryMain inventory = new InventoryMain();
                        inventory.DisplayData(@"CE:\GIT BL\ObjectOrientedProgramming\ObjectOrientedProgramming\ObjectOrientedProgram\ObjectOrientedProgram\Files1\InventoryFiles.json");
                        break;
                    case 3:
                        Stock stock = new Stock();
                        stock.DisplayData(@"E:\GIT BL\ObjectOrientedProgramming\ObjectOrientedProgramming\ObjectOrientedProgram\ObjectOrientedProgram\File\StockFile.json");
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
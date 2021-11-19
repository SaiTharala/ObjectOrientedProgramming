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
                Console.WriteLine("Choose an Option..:\n 1.JSON \n 2.Exit");
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
                        inventory.DisplayData("Rice");
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
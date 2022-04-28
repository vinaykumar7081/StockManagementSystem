using System;
using StockAccountManagementSystem;
using StockAccountManagementSystem.StockAccount;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(" ***** Welcome In The Stock Account Management ***** ");
        StockProtFolio stock = new StockProtFolio();
        Console.WriteLine(" Display Stock Data 1\n ");
        bool check = true;
        while (check)
        {
            Console.WriteLine("Enter the Above Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    stock.DisplayStockDetails();
                    break;
                case 0:
                    check = false;
                    break; 

            }
        }

    }
}
using Microsoft.VisualBasic.FileIO;
using System;

public  class Ecocash
{
    
    static void Main(string[] args)
    {
        int option ;
        string currency="ZWL";

        Console.WriteLine("Please select your currency\n1.Zimbabwean Dollar (ZWL)\n2.United States Dollar (USD) ");
        option = int.Parse(Console.ReadLine());
         

        switch (option)
        {
            case 1:
                currency = "ZWL";
                break;

            case 2:
                currency = "USD";
                break;

            default:
                Error();
                break;
        }

         

        if (Login(currency))
        {
            Menu(currency);
            
        }
        else
        {
            Console.WriteLine("PIN blocked you have entered wrong PIN 3 times");
        }
    }

    static void Menu(string currency)
    {
        int option;
        Console.WriteLine("1. Send Money");
        Console.WriteLine("2. Make Payment");
        Console.WriteLine("3. Cash Out");
        Console.WriteLine("4. Airtime & Bundles");
        Console.WriteLine("5. Junior Wallet");
        Console.WriteLine("6. Kashagi & Savings Club");
        Console.WriteLine("7. Wallet Services");
        Console.WriteLine("8. Banking Services");
        option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                SendMoney s=new SendMoney(currency);
                break;
            case 2:
                MakePayment();
                break;
            case 3:
                CashOut();
                break;
            case 4:
                Airtime();
                break;
            case 5:
                JuniorWallet();
                break;
            case 6:
                Kashagi();
                break;
            case 7:
                WalletServices();
                break;
            case 8:
                BankingServices();
                break;

            default:
                Error();
                break;
        }

    }
    public static void Error()
    {
        Console.WriteLine("Invalid Input");
        Environment.Exit(0);

    }
   public float bal = 100000f;
    public static float Balance(ref float balance, float amount)
    {
        balance-=amount;
        return balance; 

    }


    static bool Login(string currency)
    {
        int pin=2000;
        int userPin;
        int tries = 0;
        Console.WriteLine("Welcome to Ecocash "+currency+" wallet.");
        while(tries < 3)
        {
            Console.WriteLine("Please enter your PIN to Proceed:");
            userPin = int.Parse(Console.ReadLine());
            if(userPin == pin)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect Pin");
                tries++;
            }
            
        }
        
        return false;
    }
   
  
    static void MakePayment()
    {
        Console.WriteLine("Make Payment");

    }
    static void CashOut()
    {
        Console.WriteLine("Cash out");

    }

    static void Airtime()
    {
        Console.WriteLine("Airtime & Bundles");

    }
    static void JuniorWallet()
    {
        Console.WriteLine("Junior Wallet");

    }
    static void Kashagi()
    {
        Console.WriteLine("Kashagi & servings Club");

    }
    static void WalletServices()
    {
        Console.WriteLine("Wallet Services");

    }
    static void BankingServices()
    {
        Console.WriteLine("Banking Services");

    }
    static void More()
    {
        Console.WriteLine("Coming soon");

    }
}
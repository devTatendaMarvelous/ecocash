using System;

public class SendMoney
{
	public SendMoney(string currency)
	{
        int option;
        

        Console.WriteLine("1. Send to registered customer");
        Console.WriteLine("2. Send to unregistered customer");
        Console.WriteLine("3. Ecoshopper Purchase");
        Console.WriteLine("4. Check Wallet Balance");
        Console.WriteLine("5. Send to Account");
        Console.WriteLine("6. Request Money");
        option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
               RegisteredCustomer(currency);
                break;
            //case 2:
            //    MakePayment();
            //    break;
            //case 3:
            //    CashOut();
            //    break;
            //case 4:
            //    Airtime();
            //    break;
            //case 5:
            //    JuniorWallet();
            //    break;
            //case 6:
            //    Kashagi();
            //    break;
            //case 7:
            //    WalletServices();
            //    break;
            //case 8:
            //    BankingServices();
            //    break;

            default:
                Ecocash.Error();
                break;
        }
    }

    void RegisteredCustomer(string currency)
    {
        int number, option;
        float amount;
        Console.WriteLine("Enter Subscriber number: ");
        Console.WriteLine(" Press * for Main Menu and 0 For Previous");
        Console.WriteLine("Menu");
        number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Amount:");
        Console.WriteLine(" Press * for Main Menu and 0 For Previous");
        Console.WriteLine("Menu");
        amount = float.Parse(Console.ReadLine());

        Console.WriteLine("Sending "+currency+" to "+number+" SIMBARASHE CHINZUNZA");
        Console.WriteLine("Enter");
        Console.WriteLine("1. Confirm");
        Console.WriteLine("2. Cancel");
        Console.WriteLine(" \n Press * for Main Menu and 0 For Previous\nMenu");
        option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.WriteLine("You have sent " + currency + " to " + number + " SIMBARASHE CHINZUNZA");
                Ecocash obj=new Ecocash();
                Console.WriteLine(" Your new wallet balance is " + currency + Ecocash.Balance(ref obj.bal,(amount * 1.03f)));
                break;
            //case 2:
            //    MakePayment();
            //    break;
            //case 3:
            //    CashOut();
            //    break;
            //case 4:
            //    Airtime();
            //    break;
            //case 5:
            //    JuniorWallet();
            //    break;
            //case 6:
            //    Kashagi();
            //    break;
            //case 7:
            //    WalletServices();
            //    break;
            //case 8:
            //    BankingServices();
            //    break;

            default:
                Ecocash.Error();
                break;
        }
    }
}

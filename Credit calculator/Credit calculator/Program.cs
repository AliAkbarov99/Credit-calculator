

string username = "admin";
string password = "admin";
int price;
int month;
string percent;
int sumprice;
int monpayment;
int operation;
int agree;
tryagain:
Console.WriteLine("Istifadeci adi daxil edin.");
string logusername = Console.ReadLine();
Console.WriteLine("Sifreni daxil edin.");
string logpassword = Console.ReadLine();

if (username == logusername && password == logpassword)
{
    backoperations:
    Console.WriteLine("\n \n 1.Kredit goturmek \n 2.Kredit odemek \n 3.Hesabat ");

    Console.WriteLine("\nEmeliyyati secin.");
    operation = Convert.ToInt32(Console.ReadLine());
    if(operation == 1)
    {
        Console.WriteLine("Ay daxil edin");
        month =Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Mebleg daxil edin");
        price = Convert.ToInt32(Console.ReadLine());

        sumprice = price + price / 100 * month;
        
        if(month <= 12)
        {
            Console.WriteLine($"Umumi mebleg:{sumprice}");
        }
        else
        {
            Console.WriteLine($"Umumi mebleg:{sumprice}");
        }

        Console.WriteLine($"Ayliq odenis:{sumprice / month}");

        Console.WriteLine("Razisiniz? \n 1.Beli \n 2.Xeyir");
        agree = Convert.ToInt32(Console.ReadLine());
        if(agree == 1)
        {
            Console.WriteLine($"Emeliyyat ugurlu oldu! \n Indiki borcunuz: {sumprice} AZN");
        }
        goto backoperations;

    }
    else if(operation == 2)
    {
        Console.WriteLine("2 desiz");
    }

}
else
{
    Console.WriteLine("Istifadeci adi ve ya sifre yanlisdir. Xahis olunur yeniden yoxlayin.");
    goto tryagain;
}

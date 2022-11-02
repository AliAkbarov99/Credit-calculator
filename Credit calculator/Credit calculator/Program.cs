

string username = "admin";
string password = "admin";
int price =0;
int month = 0;
string percent = " ";
int monpayment = 0 ;
int operation = 0;
int agree = 0;
int sumprice = 0;
int remprice = 0;
int remmonth = 0;
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
        monpayment = sumprice / month;
        if(month <= 12)
        {
            Console.WriteLine($"Umumi mebleg:{sumprice}");
        }
        else
        {
            Console.WriteLine($"Umumi mebleg:{sumprice}");
        }

        Console.WriteLine($"Ayliq odenis:{monpayment}");

        Console.WriteLine("Razisiniz? \n 1.Beli \n 2.Xeyir");
        agree = Convert.ToInt32(Console.ReadLine());
        if(agree == 1)
        {
            Console.WriteLine($"Emeliyyat ugurlu oldu! \n Indiki borcunuz: {sumprice} AZN");
            remprice = sumprice;
            remmonth = month;
        }
        goto backoperations;

    }
    else if(operation == 2)
    {
        Console.WriteLine($"Ayliq odenis: {monpayment}");
        paymentnum:
        Console.WriteLine("Odemek ucun 1 basin");
        int paymentnum =Convert.ToInt32(Console.ReadLine());
        if (paymentnum == 1)
        {
            Console.WriteLine("Odenis ugurlu oldu !");
            
            remprice = remprice - monpayment;
            remmonth = remmonth - 1;
            Console.WriteLine($"Qalan borc:{remprice}\n Qalan ay:{remmonth}");
            goto backoperations;
        }
        else
        {
            Console.WriteLine("Odenis olmadi.Yeniden daxil edin.");
            goto paymentnum;
        }
    }

    else if (operation == 3)
    {
        Console.WriteLine($"Qalan borc:{remprice}");
        Console.WriteLine($"Qalan ay:{remmonth}");
        goto backoperations;
    }

}
else
{
    Console.WriteLine("Istifadeci adi ve ya sifre yanlisdir. Xahis olunur yeniden yoxlayin.");
    goto tryagain;
}

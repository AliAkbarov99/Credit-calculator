

string username = "admin";
string password = "admin";
int price;
int month;
string percent;
int sumprice;
int monpayment;
tryagain:
Console.WriteLine("Istifadeci adi daxil edin.");
string logusername = Console.ReadLine();
Console.WriteLine("Sifreni daxil edin.");
string logpassword = Console.ReadLine();

if (username == logusername && password == logpassword)
{
    Console.WriteLine("\n \n 1.Kredit goturmek \n 2.Kredit odemek \n 3.Hesabat ");
}
else
{
    Console.WriteLine("Istifadeci adi ve ya sifre yanlisdir. Xahis olunur yeniden yoxlayin.");
    goto tryagain;
}

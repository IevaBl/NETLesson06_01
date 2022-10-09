// See https://aka.ms/new-console-template for more information
/* Prašyti funkciją, kuri gražina KMI */


double sk1 = Convert.ToDouble(ReadData("Iveskite savo ugi metrais:"));

double sk2 = Convert.ToDouble(ReadData("Iveskite savo svori kg :"));

KMI(sk1, sk2);
static string ReadData(string displayedText)
{
    Console.WriteLine(displayedText);
    return Console.ReadLine();
}


static void KMI(double ugis, double svoris)
{
    var kmi = svoris/ ugis/ ugis;
    Console.WriteLine($" Jusu kmi yra :{kmi}");
}


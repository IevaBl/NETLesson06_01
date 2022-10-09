// See https://aka.ms/new-console-template for more information
/* Parašyti funkciją, kuri gauna stringtipo parametrą. 
 * Funkcija turi gražinti eilutę su tiek „#“,kiek simbolių gautame parametre. */

kazkas("Motiejus");

static void kazkas(string simbolis)
{
    var count = simbolis.Length;
    for (int i = 0; i < count; i++)
    {
        char sign = '#';
        Console.WriteLine(sign);
    }
}
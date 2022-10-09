// See https://aka.ms/new-console-template for more information
/* Parašyti funkciją, kuri išvedą į konsolę bet kokį vardą tiek kartų, kiek nurodo parametras.*/

PrintMyName(6, "Jonas");

static void PrintMyName(int kartai, string vardas)
{
    for (int i = 0; i < kartai; i++)
    {
        Console.WriteLine(vardas);
    }

}
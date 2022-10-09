// See https://ak.ms/new-console-template for more information

/* Parašyti funkciją, kuri pakelią vieną skaičių į antrojo laipsnįPvz.: 2 ^ 3 = 8 */

Console.WriteLine(Keitimas(4));

static double Keitimas(double num)
{
    double holder = num;
    double laipsnis = ++num;
    double galutinis = Math.Pow(holder, laipsnis);
    return galutinis;
}

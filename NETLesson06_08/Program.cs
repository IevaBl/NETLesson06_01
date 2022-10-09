// See https://aka.ms/new-console-template for more information

/* Parašyti 2 perkrautas funkcijas.
 * 1.Išveda skaičių sumą nuo .. Iki 
 * 2.Gauna parametrus: intnuo, intiki, bool rodyti Tarpine Suma
 * Pvz: nuo 1, iki 50 +1=1, 1+2=3, 3+4=7, 7+5=12 */

var test = new Test();

test.printSum(1, 30, true);

class Test
{
    public int printSum(int from, int to, bool print)
    {
        int sum = 0;

        for (int i = from; i <= to; i++)
        {
            sum +=i;
            Console.WriteLine(sum);
        }
        return 0;
    }

    public int printSum(double from, double to, bool print)
    {
        return 0;
    }
}
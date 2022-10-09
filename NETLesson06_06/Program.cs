// See https://aka.ms/new-console-template for more information

/* Parašyti funkciją, kuri paima int[] parametrą ir išveda elementų sumą,
 * bei kiek tų elementų yra.Pvz.: Suma: 123, viso: 7 elementai */

Console.WriteLine(Elementai(new int[] {3,4,5,6,7,8,9}));

static (int suma, int elem) Elementai(int[] num) 
{
    int sum = 0, elem = 0;
    foreach(int i in num)
    {
        sum = sum + i;
        elem++;
    }
    return (sum, elem);
}


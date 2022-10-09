// See https://aka.ms/new-console-template for more information

/* Parašyti rekursinę funkciją faktorialo skaičiavimui 
 * Faktorialas-natūrinių skaičių sandauga nuo 1 iki pasirinkto natūrinio skaičiaus (imtinai). 
 * Žymima šauktuko (!) ženklu. Pvz.: 5!=1*2*3*4*5=120 */


int finalResult = calc(5);

int calc(int factorial)
{
    if (factorial == 0)
    {
        return 1;
    }


    return factorial * calc(factorial-1);

}


Console.WriteLine(finalResult);
